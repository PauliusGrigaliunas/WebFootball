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

namespace Football
{

    public partial class Form1 : Form
    {
        bool isBTeamScored = false;
        bool isATeamScored = false;
        private Stopwatch stopwatch = new Stopwatch();
        int _xBallPosition;
        int _timeElapsed = 0;
        VideoCapture _capture;
        Image<Bgr, byte> imgInput = null;
        Image<Bgr, byte> imgOriginal;
        System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(TimeTick);
            _timer.Start();
            _capture = new VideoCapture("C:\\Users\\Mode\\Videos\\test.mp4");

        }

        private void TimeTick(object sender, EventArgs e)
        {
                Mat mat = _capture.QueryFrame();
                if (mat == null) return;
                //resize to picture box params
                imgOriginal = mat.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear); ;
                pictureBox1.Image = imgOriginal.Bitmap;

            //dilate and erode img, filter img
            Image<Gray, byte> imgSmoothed = imgOriginal.Convert<Hsv, byte>().InRange(new Hsv(0, 140, 150), new Hsv(180, 255, 255));
            //pictureBox2.Image = imgSmoothed.Bitmap;

                var erodeImage = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(5, 5), new Point(-1, -1));
                CvInvoke.Erode(imgSmoothed, imgSmoothed, erodeImage, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                var dilateImage = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(6, 6), new Point(-1, -1));
                CvInvoke.Dilate(imgSmoothed, imgSmoothed, dilateImage, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));

                Image<Bgr, byte> imgCircles = imgOriginal.CopyBlank();

                foreach (CircleF circle in GetCircles(imgSmoothed))
                {
                    if (textXYradius.Text != "") textXYradius.AppendText(Environment.NewLine);
                    textXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                        circle.Radius.ToString("###,000").PadLeft(7));
                    textXYradius.ScrollToCaret();
                _xBallPosition = (int)circle.Center.X;
                AddPoint(_xBallPosition);
                imgCircles.Draw(circle, new Bgr(Color.Red), 3);
                }
                pictureBox2.Image = imgCircles.Bitmap;
        }
        private void AddPoint (int x)
        {
            int temp = 0;
            if (x > 440)
            {
                isATeamScored = false;
                isBTeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else if ( x < 45 )
            {
                isBTeamScored = false;
                isATeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else
            {
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                _timeElapsed = ts.Seconds;
                if (_timeElapsed >= 3 && isBTeamScored == true )
                {
                    temp = int.Parse(bTeamLabel.Text);
                    temp = temp + 1;
                    bTeamLabel.Text = temp.ToString();
                    stopwatch.Reset();
                    isBTeamScored = false;
                }
                else if (_timeElapsed >= 3 && isATeamScored == true )
                {
                    temp = int.Parse(aTeamLabel.Text);
                    temp = temp + 1;
                    aTeamLabel.Text = temp.ToString();
                    stopwatch.Reset();
                    isATeamScored = false;
                }
                else return;
            }
        }
        private void takeAPicture(Image<Bgr, byte> imgInput )
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //searching for cirxle shapes
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = imgInput.Bitmap;
  /*                  imgSmoothed = imgInput.InRange(new Bgr(0, 0, 140), new Bgr(80, 255, 255));
                    imgSmoothed = imgSmoothed.PyrDown().PyrUp();
                    imgSmoothed._SmoothGaussian(3);
                    imgSmoothed = imgSmoothed.Convert<Gray, byte>();

                    Image<Bgr, byte> imgCircles = imgInput.CopyBlank();

 //                   minDistanceBtwCircles = imgSmoothed.Height / 4;
 //                   circles = imgSmoothed.HoughCircles(cannyThreshold, grayCircle, lAccumRes, minDistanceBtwCircles, minRadius, maxRadius)[0];

                    foreach (CircleF circle in circles)
                    {
                        if (textXYradius.Text != "") textXYradius.AppendText(Environment.NewLine);
                        textXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                            circle.Radius.ToString("###,000").PadLeft(7));
                        textXYradius.ScrollToCaret();

                        CvInvoke.Circle(imgCircles,
                            new Point(((int)circle.Center.X), (int)circle.Center.Y), 3, new MCvScalar(0, 255, 0),
                            -1,
                            LineType.AntiAlias,
                            0);
                        imgCircles.Draw(circle, new Bgr(Color.Aqua), 3);
                    }
                    pictureBox2.Image = imgCircles.Bitmap;*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "System message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
//Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takeAPicture( imgInput );
        }
//layers
        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(50, 20);
            pictureBox2.Image = imgCanny.Bitmap;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(1, 1, 3);
            pictureBox2.Image = imgSobel.Bitmap;
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplasian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgLaplasian = imgGray.Laplace(3);
            pictureBox2.Image = imgLaplasian.Bitmap;
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
//Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if (_capture == null)
            {
                _capture = new Emgu.CV.VideoCapture(0);
            }
           _capture.ImageGrabbed += Capture_ImageGrabbed;
            _capture.Start();*/
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
           /* try
            {
                Mat mat = new Mat();
                _capture.Retrieve(mat);
                pictureBox1.Image = mat.ToImage<Bgr, byte>().Bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

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
           /* if (_capture == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Video Files |*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _capture = new Emgu.CV.VideoCapture(ofd.FileName);
                }
                _capture.ImageGrabbed += Capture_ImageGrabbed1;
                _capture.Start();
            }*/
        }

      /*  private void Capture_ImageGrabbed1(object sender, EventArgs e)
        {

        }*/
        private CircleF[] GetCircles(Image<Gray, byte> imgGray)
        {
            Gray grayCircle = new Gray(12);
            Gray cannyThreshold = new Gray(26);
            double lAccumResolution = 2.0;
            double minDistanceBtwCircles = 1.0;
            int minRadius = 0;
            int maxRadius = 10;
            return imgGray.HoughCircles(grayCircle, cannyThreshold, lAccumResolution, minDistanceBtwCircles, minRadius, maxRadius)[0];
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
                _capture = null;
            }
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
            }
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_capture != null || imgInput != null)
            {
                pictureBox2.Image = imgInput.Convert<Gray, byte>().Bitmap;
            }

        }

        private void iccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imgInput.Convert<Ycc, byte>().Bitmap;
        }
        
        //coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + e.Y.ToString());
        }

        // colors:
        //low red
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 255;         // max value
            trackBar1.Minimum = 0;           // min value
            trackBar1.TickFrequency = 10;    // distance between tick-mark
            trackBar1.LargeChange = 5;       // when clicked on a side of a slider move by X
            trackBar1.SmallChange = 1;       // move using keyboard arrows

            label1.Text = trackBar1.Value.ToString();
            redToolStripMenuItem_Click(sender, e);
        }

        //low green
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Maximum = 255;
            trackBar2.Minimum = 0;
            trackBar2.TickFrequency = 10;
            trackBar2.LargeChange = 5;
            trackBar2.SmallChange = 1;      

            label2.Text = trackBar2.Value.ToString();
            redToolStripMenuItem_Click(sender, e);
        }

        //low blue
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Maximum = 255;
            trackBar3.Minimum = 0;
            trackBar3.TickFrequency = 10;
            trackBar3.LargeChange = 5;
            trackBar3.SmallChange = 1;

            label3.Text = trackBar3.Value.ToString();
            redToolStripMenuItem_Click(sender, e);
        }

        //high red
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            trackBar4.Maximum = 255;
            trackBar4.Minimum = 0;
            trackBar4.TickFrequency = 10;
            trackBar4.LargeChange = 5;
            trackBar4.SmallChange = 1;

            label4.Text = trackBar4.Value.ToString();
            redToolStripMenuItem_Click(sender, e);
        }

        //high green
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            trackBar5.Maximum = 255;
            trackBar5.Minimum = 0;
            trackBar5.TickFrequency = 10;
            trackBar5.LargeChange = 5;
            trackBar5.SmallChange = 1;

            label5.Text = trackBar5.Value.ToString();
            redToolStripMenuItem_Click(sender, e);
        }

        //high red
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            trackBar6.Maximum = 255;
            trackBar6.Minimum = 0;
            trackBar6.TickFrequency = 10;
            trackBar6.LargeChange = 5;
            trackBar6.SmallChange = 1;

            label6.Text = trackBar6.Value.ToString();
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
    }
}
