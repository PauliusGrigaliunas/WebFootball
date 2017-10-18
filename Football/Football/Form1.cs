using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Cuda;
using System.Data.SqlClient;
namespace Football
{

    public partial class Form1 : Form
    {
        public static bool isBTeamScored = false;
        public static bool isATeamScored = false;
        int teamAScores;
        int teamBScores;
        private Stopwatch stopwatch = new Stopwatch();
        int _xBallPosition { get; set; }
        int _timeElapsed = 0;
        VideoCapture _capture { get; set; }
        Image<Bgr, byte> imgInput = null;
        Image<Bgr, byte> imgOriginal { get; set; }
        Image<Gray, byte> imgFiltered { get; set; }

        Teams team = new Teams();
        SqlCommand cmd;
        SqlDataAdapter sa;
        DataTable dt = new DataTable();
        Picture picture = new Picture();
        GoalsChecker gcheck;
        Ball ball = new Ball();

        bool isTeamScored = false;
        int i = 0;
        int[] xCoords = new int[99999999];

        String name1;
        String name2;
        private int victA ;
        private int goalA ;
        private int victB ;
        private int goalB ;
        System.Windows.Forms.Timer _timer;

        Connector conector = new Connector();

        public Form1()
        {
            InitializeComponent();
        }

        public int TeamAScores { get => teamAScores; set => teamAScores = value; }
        public int TeamBScores { get => teamBScores; set => teamBScores = value; }
        public int VictA { get => victA; set => victA = value; }
        public int GoalA { get => goalA; set => goalA = value; }
        public int VictB { get => victB; set => victB = value; }
        public int GoalB { get => goalB; set => goalB = value; }

        public void setName1(String name)
        {
            this.name1 = name;
        }
        public void setName2(String name)
        {
            this.name2 = name;
        }

        private void Video()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files |*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _capture = new Emgu.CV.VideoCapture(ofd.FileName);
                _timer = new System.Windows.Forms.Timer();
                _timer.Interval = 1000 / 30;
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();
                
            }

        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            else Video();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
                _timer = null;
            }
        }


        private void TimeTick(object sender, EventArgs e)
        {

            gcheck = new GoalsChecker(stopwatch);
            aTeamLabel.Text = gcheck.CheckForScoreA(aTeamLabel.Text);
            bTeamLabel.Text = gcheck.CheckForScoreB(bTeamLabel.Text);


            Mat mat = _capture.QueryFrame();       //getting frames            
            if (mat == null) return;

            imgOriginal = mat.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear); ;
            pictureBox1.Image = imgOriginal.Bitmap;
            Image<Bgr, byte> imgCircles = imgOriginal.CopyBlank();     //copy parameters of original frame image

            var filter = new ImgFilter(imgOriginal);
            imgFiltered = filter.GetFilteredImage();

            BallPosition(imgCircles);

            pictureBox2.Image = imgCircles.Bitmap;
        }

        private void BallPosition(Image<Bgr, byte> imgCircles) {

            foreach (CircleF circle in ball.GetCircles(imgFiltered))          //searching circles
            {
                if (textXYradius.Text != "") textXYradius.AppendText(Environment.NewLine);

                /*textXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                circle.Radius.ToString("###,000").PadLeft(7));
                textXYradius.ScrollToCaret();*/

                _xBallPosition = (int)circle.Center.X;                          // get x coordinate(center of a ball)
                gcheck.StartStopwatch(_xBallPosition, imgOriginal.Width);       //start stopwatch to check if it is scored or not   
                gcheck.Direction(_xBallPosition, i, xCoords); i++;              // 
                imgCircles.Draw(circle, new Bgr(Color.Red), 3);                 //draw circles on smoothed image
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture = null;
            }
            if (MessageBox.Show("Are you sure you want to close?", "System message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        //Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture.TakeAPicture().Bitmap;
        }
        //layers

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                _capture = new Emgu.CV.VideoCapture(0);
            }
            _capture.ImageGrabbed += Capture_ImageGrabbed;
            _capture.Start();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat mat = new Mat();
                _capture.Retrieve(mat);
                pictureBox1.Image = mat.ToImage<Bgr, byte>().Bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // end camera
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
                _capture = null;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
            }
        }
        // Video
        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Video Files |*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _capture = new Emgu.CV.VideoCapture(ofd.FileName);
                }
                _capture.ImageGrabbed += Capture_ImageGrabbed1;
                _capture.Start();
            }
            MessageBox.Show("check");
        }

        private void Capture_ImageGrabbed1(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
            }
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
            }
        }
        //coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)                          //checking coordinates of the video
        {
            MessageBox.Show(e.X.ToString() + e.Y.ToString());
        }

        private string TrackBarSetting(TrackBar trackBar)
        {
            trackBar.Maximum = 255;         // max value
            trackBar.Minimum = 0;           // min value
            trackBar.TickFrequency = 10;    // distance between tick-mark
            trackBar.LargeChange = 5;       // when clicked on a side of a slider move by X
            trackBar.SmallChange = 1;       // move using keyboard arrows

            return trackBar.Value.ToString();

        }
        // colors:
        //low red
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = TrackBarSetting(trackBar1);
            redToolStripMenuItem_Click(sender, e);
        }

        //low green
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = TrackBarSetting(trackBar2);
            redToolStripMenuItem_Click(sender, e);
        }

        //low blue
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = TrackBarSetting(trackBar3);
            redToolStripMenuItem_Click(sender, e);
        }

        //high red
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label4.Text = TrackBarSetting(trackBar4);
            redToolStripMenuItem_Click(sender, e);
        }

        //high green
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label5.Text = TrackBarSetting(trackBar5);
            redToolStripMenuItem_Click(sender, e);
        }

        //high red
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label6.Text = TrackBarSetting(trackBar6);
            redToolStripMenuItem_Click(sender, e);
        }

        //ColorFilter
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lowBlue = Convert.ToInt32(label3.Text);
            int highBlue = Convert.ToInt32(label6.Text);
            int lowGreen = Convert.ToInt32(label2.Text);
            int highGreen = Convert.ToInt32(label5.Text);
            int lowRed = Convert.ToInt32(label1.Text);
            int highRed = Convert.ToInt32(label4.Text);


            if (imgInput == null) return;
            //Image<Gray, Byte> imgRange = new Image<Bgr, byte>(imgInput.Width, imgInput.Height, new Bgr(0,0,0)); 

            //Image<Gray, Byte> imgRange = imgInput.InRange(new Bgr(0, 0, 187), new Bgr(100, 255, 255));
            Image<Gray, Byte> imgRange = imgInput.InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));

            imgRange.SmoothGaussian(9);

            pictureBox2.Image = imgRange.Bitmap;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            aTeamLabel.Text = "0";
            bTeamLabel.Text = "0";
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TeamBScores = int.Parse(bTeamLabel.Text);
            this.TeamAScores = int.Parse(aTeamLabel.Text);
            
             VictA=0;
             GoalA=0;
             VictB=0;
             GoalB=0;

            SqlConnection con = conector.Connect();
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM teamTable";
            cmd.ExecuteNonQuery();
            sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            //kokia info lentelej


            VictA = team.getVictories(dt, name1); 
            GoalA = team.getGoals(dt, name1);
            VictB = team.getVictories(dt, name2);
            GoalB = team.getGoals(dt, name2);

            GoalA = GoalA + TeamAScores;
            GoalB = GoalB + TeamBScores;
            if(teamAScores>TeamBScores)
            {
                VictA = VictA + 1;
            }
            else if(teamAScores < TeamBScores)
            {
                VictB = VictB + 1;
            }
            con.Close();

            team.insertToTable(name1, VictA, GoalA);
            team.insertToTable(name2, VictB, GoalB);
         
            MessageBox.Show("Saved");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAllTeams form = new FormAllTeams();

            form.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsTeamB form = new FormsTeamB();
            form.loadInfo(name2, VictB, GoalB,teamBScores);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTeamA form = new FormTeamA();
            form.loadInfo(name1, VictA, GoalA,teamAScores);
            form.Show();
        }
    }
}