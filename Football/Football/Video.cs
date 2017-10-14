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
using System.Drawing;

namespace Football
{
    public class Video 
    {
        /*
        //public event EventHandler TimeTick;

        bool isBTeamScored = false;
        bool isATeamScored = false;
        private Stopwatch stopwatch = new Stopwatch();
        int _xBallPosition { get; set; }
        int _timeElapsed = 0;
        VideoCapture _capture { get; set; }
        Image<Bgr, byte> imgInput = null;
        Image<Bgr, byte> imgOriginal { get; set; }
        Image<Gray, byte> imgFiltered { get; set; }
        System.Windows.Forms.Timer _timer;

        
        private void TakeVideo()
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



        private void CheckForScore()
        {
            int temp;
            //stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            _timeElapsed = ts.Seconds;
            if (_timeElapsed >= 3 && isBTeamScored == true)
            {
                temp = int.Parse(bTeamLabel.Text);
                temp = temp + 1;
                bTeamLabel.Text = temp.ToString();
                stopwatch.Reset();
                isBTeamScored = false;
            }
            else if (_timeElapsed >= 3 && isATeamScored == true)
            {
                temp = int.Parse(aTeamLabel.Text);
                temp = temp + 1;
                aTeamLabel.Text = temp.ToString();
                stopwatch.Reset();
                isATeamScored = false;
            }
        }




        public void TimeTick(object sender, EventArgs e)
        {
            CheckForScore();

            Mat mat = _capture.QueryFrame();       //getting frames            
            if (mat == null) return;

            imgOriginal = mat.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear); ;
            pictureBox1.Image = imgOriginal.Bitmap;
            Image<Bgr, byte> imgCircles = imgOriginal.CopyBlank();     //copy parameters of original frame image

            imgFiltered = GetFilteredImage(imgOriginal);
            foreach (CircleF circle in GetCircles(imgFiltered))          //searching circles
            {
                if (textXYradius.Text != "") textXYradius.AppendText(Environment.NewLine);

                textXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                circle.Radius.ToString("###,000").PadLeft(7));
                textXYradius.ScrollToCaret();

                //write coordinates to textbox

                _xBallPosition = (int)circle.Center.X;                          // get x coordinate(center of a ball)
                StartStopwatch(_xBallPosition);                                     //start stopwatch to check or it is scored or not
                imgCircles.Draw(circle, new Bgr(Color.Red), 3);                        //draw circles on smoothed image
            }


            pictureBox2.Image = imgCircles.Bitmap;
        }


        private void StartStopwatch(int x)
        {
            if (x > 440)
            {
                isATeamScored = false;
                isBTeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else if (x < 45)
            {
                isBTeamScored = false;
                isATeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else
            {
                isBTeamScored = false;
                isATeamScored = false;
                stopwatch.Reset();
            }

        }


        protected virtual void OnVideo()
        {
            if (TimeTick != null)
            {
                TimeTick(this, EventArgs.Empty);
            }
            
        }*/

    }
}
