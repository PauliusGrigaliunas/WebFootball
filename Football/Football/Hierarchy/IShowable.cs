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
        Image<Gray, byte> ImgOriginal { get; set; }
        Image<Gray, byte> ImgFiltered { get; set; }
        bool TakeASource();
        bool StartVideo();
        bool StartCamera();
        void Pause();
        void Stop();        
        bool StartLastUsedVideo();
        bool Check();
        Image<Gray, byte> ColorRange(int lowBlue, int lowGreen, int lowRed, int highBlue, int highGreen, int highRed);
        Image<Gray, byte> ConvertToGray();
        Image<Gray, byte> GetFilteredImageZones(Colour clr);
        Image<Gray, byte> GetFilteredImage(Colour colour);

    }
}
