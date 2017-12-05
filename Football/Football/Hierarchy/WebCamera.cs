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
            Path path = new Path();
            path.ShowDialog();
            Capture = new Emgu.CV.VideoCapture(path.PathString);
            return Starter();
        }
    }
}
