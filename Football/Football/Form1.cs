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
        private Stopwatch stopwatch = new Stopwatch();
        int _xBallPosition { get; set; }
        int _timeElapsed = 0;
        VideoCapture _capture { get; set; }
        Image<Bgr, byte> imgInput = null;
        Image<Bgr, byte> imgOriginal { get; set; }
        Image<Gray, byte> imgFiltered { get; set; }

       
        Picture picture = new Picture();
        GoalsChecker gcheck;
        Ball ball = new Ball();

        bool isTeamScored = false;
        int i = 0;
        int[] xCoords = new int[99999999];

        String name1;
        String name2;
        
        System.Windows.Forms.Timer _timer;

        Connector conector = new Connector();

        public Form1()
        {
            InitializeComponent();
        }

        public int TeamAScores { get; set; }
        public int TeamBScores { get; set; }
        public int VictA { get; set; }
        public int GoalA { get; set; }
        public int VictB { get; set; }
        public int GoalB { get; set; }

        public void setName1(String name)
        {
            this.name1 = name;
        }
        public void setName2(String name)
        {
            this.name2 = name;
        }

        private void Camera()
        {

            _capture = new Emgu.CV.VideoCapture(0);
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(TimeTick);
            _timer.Start();


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

        // Menu items------------
        //Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            Camera();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
                _timer = null;
            }
        }



        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            else Video();
        }


        private void startToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            else Video();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
                _timer = null;
            }
        }

        private void pauseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
        }

        private void stopToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
                _timer = null;
            }
        }
        // End Menu items------------
        // Buttons------------

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
        // End Buttons------------

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

            ball.imgFiltered = imgFiltered;  ball.imgOriginal = imgOriginal;
            ball.gcheck = gcheck; ball.xCoords = xCoords; ball.i = i;      
            ball.BallPositionDraw(imgCircles);
            i = ball.i;  xCoords = ball.xCoords;  gcheck = ball.gcheck;

            pictureBox2.Image = imgCircles.Bitmap;
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
    
        //Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picture.TakeAPicture().Bitmap;
        }
        //coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)                          //checking coordinates of the video
        {
            MessageBox.Show("X= " + e.X.ToString() + ";  Y= " + e.Y.ToString() + ";");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aTeamLabel.Text = "0";
            bTeamLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TeamBScores = int.Parse(bTeamLabel.Text);
            this.TeamAScores = int.Parse(aTeamLabel.Text);

            VictA = 0;
            GoalA = 0;
            VictB = 0;
            GoalB = 0;
            //kokia info lentelej
            Teams team = new Teams();

            VictA = team.GetVictories(name1);
            GoalA = team.GetGoals(name1);
            VictB = team.GetVictories( name2);
            GoalB = team.GetGoals( name2);

            GoalA = GoalA + TeamAScores;     
            GoalB = GoalB + TeamBScores;
            if (TeamAScores > TeamBScores)
            {
                VictA = VictA + 1;
            }
            else if (TeamAScores < TeamBScores)
            {
                VictB = VictB + 1;
            }
       
           team.InsertToTable(name1, VictA, GoalA);
           team.InsertToTable(name2, VictB, GoalB);

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
            form.loadInfo(name2, VictB, GoalB, TeamBScores);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTeamA form = new FormTeamA();
            form.loadInfo(name1, VictA, GoalA, TeamAScores);
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}