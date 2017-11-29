using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Football
{
    public class Camera : Video
    {
        public Camera(VideoScreen hm) : base(hm)
        {
        }

        public override Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed)
        {
            return base.ColorRange(lowBlue, lowGreen, lowRed, highBlue, highGreen, highRed);
        }

        public override Image<Gray, byte> ConvertToGray()
        {
            return base.ConvertToGray();
        }

        public override bool TakeASource()
        {
            Capture = new Emgu.CV.VideoCapture(0);
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(_home.TimeTick);
            _timer.Start();
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
