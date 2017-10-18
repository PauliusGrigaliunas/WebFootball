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
    public class Picture
    {
        //laukai
        private Image<Bgr, byte> imgInput;
        private Image<Gray, byte> imgGray;

        //properties
        public Image<Bgr, byte> GetImage
        {
            get
            {
                return imgInput;
            }
        }
        //--------------------------------------
        //Sigletono ideja * 
        //constructor * private
        public Picture()
        {

        }

        protected static Picture _obj;

        public static Picture GetObject()
        {
            if (_obj == null)
            {
                _obj = new Picture();
            }
            return _obj;
        }

        //--------------------------------------
        public Image<Bgr, byte> TakeAPicture()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
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
        //-----------------------------------------------------
        public Image<Gray, float> ConvertToLaplase(int x)
        {
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplasian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgLaplasian = imgGray.Laplace(3);
            return imgLaplasian;
        }

        public virtual Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed)
        {

            Image<Gray, Byte> imgRange = imgInput.InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));
            return imgRange;
        }
    }
}