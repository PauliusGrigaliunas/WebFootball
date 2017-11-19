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
using System.Drawing;
using System.Configuration;

namespace Football
{
    public class Video : Picture
    {
        //objects
        public VideoCapture Capture { get; set; }
        private Mat mat;
        private Stopwatch _stopwatch = new Stopwatch();
        System.Windows.Forms.Timer _timer;
        Ball _ball = new Ball();
        private VideoScreen _home;

        //picture variables
        public Image<Bgr, byte> ImgOriginal { get; set; }
        Image<Gray, byte> _imgFiltered { get; set; }

        //variables
        public List<int> _xCoordList = new List<int>();

        public Video()
        {

        }
        public Video( VideoScreen hm )
        {
            this._home = hm;
        }

        public bool Camera()
        {
            Capture = new Emgu.CV.VideoCapture(0);
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(_home.TimeTick);
            _timer.Start();
            return true;
        }

        public bool TakeAVideo(bool filepath_exists)  // user config -> saves last used file-path)
        {
            if (!filepath_exists)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Video Files |*.mp4";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SaveUserSettings(ofd.FileName);
                    Capture = new Emgu.CV.VideoCapture(ofd.FileName);
                    _timer = new System.Windows.Forms.Timer();
                    _timer.Interval = 1000 / 30;
                    _timer.Tick += new EventHandler(_home.TimeTick);
                    _timer.Start();
                    return true;
                }
                else return false;
            }
            else
            {
                Capture = new Emgu.CV.VideoCapture(Properties.Settings.Default.lastfilepath);
                _timer = new System.Windows.Forms.Timer();
                _timer.Interval = 1000 / 30;
                _timer.Tick += new EventHandler(_home.TimeTick);
                _timer.Start();
                return true;
            }
        }

        public bool StartVideo()
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(_home.TimeTick);
                _timer.Start();
                return true;
            }
             else return TakeAVideo(false);
        }

        public bool StartLastUsedVideo()
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(_home.TimeTick);
                _timer.Start();
                return true;
            }
            else return TakeAVideo(true);
        }

        public bool StartCamera()
        {
            if (_timer != null)
            {
                _timer.Tick += new EventHandler(_home.TimeTick);
                _timer.Start();
                return true;
            }
            else return Camera();
        }

        public void Pause()
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(_home.TimeTick);
                _timer.Stop();
            }
        }
        public bool Check() {
            if (_timer == null)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to reset" +
                    "points to 0 : 0?", "Adding another video", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) return true;
                else return false;
            }
            return false;
        }

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Tick -= new EventHandler(_home.TimeTick);
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

        public Image<Gray, byte> GetFilteredImage(Colour colour) 
        {
            Image<Gray, byte> imgSmoothed = ImgOriginal.Convert<Hsv, byte>().InRange(colour.Low, colour.High);

            var erodeImage = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(5, 5), new Point(-1, -1));
            CvInvoke.Erode(imgSmoothed, imgSmoothed, erodeImage, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
            var dilateImage = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(6, 6), new Point(-1, -1));
            CvInvoke.Dilate(imgSmoothed, imgSmoothed, dilateImage, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
            return imgSmoothed;
        }
        public Image<Gray, byte> GetFilteredImageZones(Colour colour)
        {
            Image<Gray, byte> imgSmoothed = ImgOriginal.Convert<Hsv, byte>().InRange(colour.Low, colour.High);
            return imgSmoothed;
        }

        public void SaveUserSettings(String filename)
        {
            //https://msdn.microsoft.com/en-us/library/a65txexh.aspx
            Properties.Settings.Default.lastfilepath = filename;
            Properties.Settings.Default.Save();
        }
    }
}
