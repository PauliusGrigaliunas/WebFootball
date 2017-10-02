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
    class Video : Picture
    {
        private VideoCapture capture;

        public Video()
        {
        }

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
            try
            {
                capture = new VideoCapture(0);
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            return capture;
        }

        public Image<Gray, Byte> ColorRange(Mat mat, int xBlue, int xGreen, int xRed, int yBlue, int yGreen, int yRed)
        {
            Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().InRange(new Bgr(xBlue, xGreen, xRed), new Bgr(yBlue, yGreen, yRed));

            return imgRange;
        }
        

    }
}
