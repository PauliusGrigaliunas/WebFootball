using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Ball
    {
        private int Red = 0;
        private int Green = 0;
        private int Blue = 0;

        public int colorRed { get { return Red; } set { Red = value; }}
        public int colorGreen { get { return Green; } set { Green = value; }}
        public int colorBlue { get { return Blue; } set { Blue = value; }}

        public float X { get; set; }
        public float Y { get; set; }
    }
}
