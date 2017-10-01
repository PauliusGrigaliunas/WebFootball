using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.UI;
using System.Windows.Forms;

namespace Football
{
    class Picture
    {
        private Image<Bgr, byte> imgInput;
        private Image<Gray, byte> imgGray;

        public Image<Bgr, byte> GetImage { get { return imgInput; } }
        //--------------------------------------
        public Image<Bgr, byte> TakeAPicture()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return imgInput;
        }
        //--------------------------------------------------
        public Image<Gray, byte> ConvertToGray()
        {
            return imgInput.Convert<Gray, byte>();
        }
        //--------------------------------------------------
        public Image<Gray, byte> ConvertToCanny(int x, int y)
        {
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(x, y);
            return imgCanny;
        }
        //-----------------------------------------------------
        public Image<Gray, float> ConvertToSobel(int x, int y, int z)
        {
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(x, y, z);
            return imgSobel;
        }

        public Image<Gray, float> ConvertToLaplase(int x)
        {
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplasian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgLaplasian = imgGray.Laplace(3);
            return imgLaplasian;
        }
    }
}
