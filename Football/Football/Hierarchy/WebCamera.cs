using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football.Hierarchy
{
    public class WebCamera : Source
    {
        public override bool TakeASource()
        {
            Capture = new Emgu.CV.VideoCapture("http://192.168.8.101:8080/video");
            return Starter();
        }
    }
}
