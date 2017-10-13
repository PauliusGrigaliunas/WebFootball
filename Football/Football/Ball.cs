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

namespace Football
{
    class Ball
    {
        private int _blue;
        private int _green;
        private int _red;
        private int _x;
        private int _y;
        
        public int blue
        {
            get
            {
                return _blue;
            }
        }

        public int green
        {
            get
            {
                return _green;
            }
        }

        public int red
        {
            get
            {
                return _red;
            }
        }

        public int x
        {
            get
            {
                return _x;
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
        }
    }
}
