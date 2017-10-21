using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.UI;
using System.Diagnostics;
using Emgu.CV.CvEnum;

namespace Football
{
    class Video : Picture
    {
        private VideoCapture _capture;
        private Mat mat;
        private Stopwatch stopwatch = new Stopwatch();
        System.Windows.Forms.Timer _timer;
        GoalsChecker gcheck;
        Image<Bgr, byte> imgOriginal { get; set; }
        Image<Gray, byte> imgFiltered { get; set; }
        Ball ball = new Ball();
        int i = 0;
        int[] xCoords = new int[999999];
        private Form1 _home;

        public Video()
        {

        }
        public Video( Form1 hm )
        {
            mat = new Mat();
            this._home = hm;
        }

        public void Camera()
        {

            _capture = new Emgu.CV.VideoCapture(0);
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(TimeTick);
            _timer.Start();

        }

        public void TakeAVideo()
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

        public void TimeTick(object sender, EventArgs e)
        {
                gcheck = new GoalsChecker(stopwatch);
                _home.aTeamLabel.Text = gcheck.CheckForScoreA(_home.aTeamLabel.Text);
                _home.bTeamLabel.Text = gcheck.CheckForScoreB(_home.bTeamLabel.Text);


                Mat mat = _capture.QueryFrame();       //getting frames            
                if (mat == null) return;

                imgOriginal = mat.ToImage<Bgr, byte>().Resize(_home.pictureBox1.Width, _home.pictureBox1.Height, Inter.Linear); ;
                _home.pictureBox1.Image = imgOriginal.Bitmap;
                Image<Bgr, byte> imgCircles = imgOriginal.CopyBlank();     //copy parameters of original frame image

                var filter = new ImgFilter(imgOriginal);
                imgFiltered = filter.GetFilteredImage();

                ball.imgFiltered = imgFiltered; ball.imgOriginal = imgOriginal;
                ball.gcheck = gcheck; ball.xCoords = xCoords; ball.i = i;
                ball.BallPositionDraw(imgCircles);
                i = ball.i; xCoords = ball.xCoords; gcheck = ball.gcheck;

                _home.pictureBox2.Image = imgCircles.Bitmap;
        }


        public void StartVideo()
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            else TakeAVideo();
        }

        public void StartCamera()
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(TimeTick);
                _timer.Start();

            }
            Camera();
        }

        public void Pause()
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
            }
        }

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(TimeTick);
                _timer.Stop();
                _timer = null;
            }
        }



        public override Image<Gray, Byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed)
        {

            Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));

            return imgRange;
        }

    }
}
