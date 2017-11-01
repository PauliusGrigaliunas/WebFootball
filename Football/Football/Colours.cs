using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public struct Colour
    {
        public string Name { get; set; }
        public Hsv Low { get; set; }
        public Hsv High { get; set; }

        /*
        public int LowH { get; set; }
        public int LowS { get; set; }
        public int LowV { get; set; }
        public int HighH { get; set; }
        public int HighS { get; set; }
        public int HighV { get; set; }


        public void CheckHSV() {
            LowH = (int)Low.Hue;
            LowS = (int)Low.Satuation;
            LowV = (int)Low.Value;
            HighH = (int)High.Hue;
            HighS = (int)High.Satuation;
            HighV = (int)High.Value;

        }*/

    }


}
