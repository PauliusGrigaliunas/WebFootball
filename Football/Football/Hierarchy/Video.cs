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

    public class Video : Source
    {
        Image<Gray, byte> ImgOriginal { get; set; }
        Image<Gray, byte> ImgFiltered { get; set; }


        public Video( VideoScreen hm )
        {
            this._home = hm;
        }

        public override bool TakeASource()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files |*.mp4";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveUserSettings(ofd.FileName);
                Capture = new Emgu.CV.VideoCapture(ofd.FileName);
                return Starter();
            }
            else return false;
        }

        
        public override  Image<Gray, byte> ConvertToGray()
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
