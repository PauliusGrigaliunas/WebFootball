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
    public class Video : Picture
    {
        //objects
        private VideoCapture _capture;
        private Mat mat;
        private Stopwatch _stopwatch = new Stopwatch();
        System.Windows.Forms.Timer _timer;
        GoalsChecker _gcheck;
        Ball _ball = new Ball();
        private VideoScreen _home;

        //picture variables
        Image<Bgr, byte> _imgOriginal { get; set; }
        Image<Gray, byte> _imgFiltered { get; set; }

        //variables
        private int _i = 0;
        public List<int> _xCoordList = new List<int>();

        public Video()
        {

        }
        public Video( VideoScreen hm )
        {
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
            _gcheck = new GoalsChecker(_stopwatch);
            _home.aTeamLabel.Text = _gcheck.CheckForScoreA(_home.aTeamLabel.Text);
            _home.bTeamLabel.Text = _gcheck.CheckForScoreB(_home.bTeamLabel.Text);
            Process();
        }

        private void Process()
        {
            mat = _capture.QueryFrame();       //getting frames            
            if (mat == null) return;

            _imgOriginal = mat.ToImage<Bgr, byte>().Resize(_home.OriginalPictureBox.Width, _home.OriginalPictureBox.Height, Inter.Linear); ;
            _home.OriginalPictureBox.Image = _imgOriginal.Bitmap;
            Image<Bgr, byte> imgCircles = _imgOriginal.CopyBlank();     //copy parameters of original frame image


            _imgFiltered = _imgOriginal.GetFilteredImage(); // Method Extension

            _ball.ImgFiltered = _imgFiltered;
            _ball.ImgOriginal = _imgOriginal;
            _ball.gcheck = _gcheck;

            _ball.xCoordList = _xCoordList;
            _ball.i = _i;
            _ball.BallPositionDraw(imgCircles);
            _i = _ball.i;
            _xCoordList = _ball.xCoordList;
            _gcheck = _ball.gcheck;

             _home.FilteredPictureBox.Image = imgCircles.Bitmap;
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

        
        public override Image<Gray, byte> ConvertToGray()
        {
            Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().Convert<Gray, byte>();

            return imgRange;

        }

        public override Image<Gray, Byte> ColorRange(int lowBlue, int lowGreen, int lowRed,int highBlue, int highGreen, int highRed)
        {
            Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));
            return imgRange;
        }
    }
}
