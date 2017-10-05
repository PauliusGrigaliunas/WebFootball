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
        private Mat mat;

        public Video()
        {
            mat = new Mat();
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

        public VideoCapture TakeAVideo2()
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Video Files |*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    capture = new Emgu.CV.VideoCapture(ofd.FileName);
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
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

        private void CreateMat()
        {
            mat = new Mat();
        }

        public Image<Bgr, byte> PutAVideo()
        {

            CreateMat();
            capture.Retrieve(mat);
            return mat.ToImage<Bgr, byte>();


        }

        public override Image<Gray, Byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed)
        {

            Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));

            return imgRange;
        }

    }
}
