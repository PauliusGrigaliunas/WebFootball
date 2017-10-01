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

namespace Football
{
    class Video
    {
        private VideoCapture capture;

        public VideoCapture GetVideo { get { return capture; } set { capture = value; } }

        public VideoCapture TakeAVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files |*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new Emgu.CV.VideoCapture(ofd.FileName);
            }
            return capture;
        }

        public VideoCapture Camera()
        {
            return new Emgu.CV.VideoCapture(0);
        }

        public void startVideo() {
            if (capture != null)
            {
                capture.Start();
            }
        }

        public void stopVideo() {

            if (capture != null)
            {
                capture.Stop();
                capture = null;
            }
        }

        public void pauseVideo() { 
            if (capture != null)
            {
                capture.Pause();
            }
        }  
    }
}
