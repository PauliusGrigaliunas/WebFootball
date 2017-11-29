using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Football
{
    public abstract class Source : IShowable
    {

        public virtual bool TakeASource() {
            return false;
        }
        public virtual Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed) {
            return null;
        }
        public virtual Image<Gray, byte> ConvertToGray() {
            return null;
        }
    }
}
