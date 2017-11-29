using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public interface IShowable
    {
        bool TakeASource();

        Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed);

        Image<Gray, byte> ConvertToGray();
    }
}
