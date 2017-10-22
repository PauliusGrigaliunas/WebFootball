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
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Emgu.CV.CvEnum;

namespace Football
{
    public class Picture
    {
        //laukai
        private Image<Bgr, byte> imgInput;

        //properties
        public Image<Bgr, byte> GetImage
        {
            get
            {
                return imgInput;
            }
        }
        public Picture()
        {

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
        public virtual Image<Gray, byte> ConvertToGray()
        {
            try
            {
                return imgInput.Convert<Gray, byte>();
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        //--------------------------------------------------
        public Image<Gray, byte> ConvertToCanny(int x, int y)
        {
            try
            {
                Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                imgCanny = imgInput.Canny(x, y);
                return imgCanny;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        //-----------------------------------------------------
        public Image<Gray, float> ConvertToSobel(int x, int y, int z)
        {
            try
            {
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
                imgSobel = imgGray.Sobel(x, y, z);
                return imgSobel;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        //-----------------------------------------------------
        public Image<Gray, float> ConvertToLaplase(int x)
        {
            try
            {
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                Image<Gray, float> imgLaplasian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
                imgLaplasian = imgGray.Laplace(3);
                return imgLaplasian;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        //------------------------------------------------------
        public virtual Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed)
        {
            try
            {
                Image<Gray, Byte> imgRange = imgInput.InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));
                return imgRange;
            }
            catch (NullReferenceException)
            {
                return null;
            }

        }
    }
}