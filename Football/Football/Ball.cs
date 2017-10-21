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
using System.Drawing;

namespace Football
{
    class Ball
    {
        public int _xBallPosition { get; set; }
        public GoalsChecker gcheck { get; set; }
        public int i { get; set; }
        public List<int> xCoordList = new List<int>();   // "List<T> is a generic collection"
        private int ix2, z;

        public Image<Bgr, byte> imgOriginal { get; set; }
        public Image<Gray, byte> imgFiltered { get; set; }

        public Ball()
        {

        }

        private CircleF[] GetCircles(Image<Gray, byte> imgGray)
        {
            Gray grayCircle = new Gray(12);
            Gray cannyThreshold = new Gray(26);
            double lAccumResolution = 2.0;
            double minDistanceBtwCircles = 1.0;
            int minRadius = 0;
            int maxRadius = 10;
            return imgGray.HoughCircles(grayCircle, cannyThreshold, lAccumResolution, minDistanceBtwCircles, minRadius, maxRadius)[0];
        }

        internal void BallPositionDraw(Image<Bgr, byte> imgCircles)
        {
            foreach (CircleF circle in GetCircles(imgFiltered))
            {
                _xBallPosition = (int)circle.Center.X;
                gcheck.StartStopwatch(_xBallPosition, imgOriginal.Width);
                gcheck.Direction(_xBallPosition, i, xCoordList); i++;
                imgCircles.Draw(circle, new Bgr(Color.Red), 3);
            }
            
            if(i >= 5)   // sarase saugomos paskutines 4 pozicijos, kad taupyt RAM
            {
                ix2 = i - 4;
                for(z = 0; z < ix2; z++)
                {
                    xCoordList.RemoveAt(0);
                }
                i -= ix2;
            }

            foreach (var coord in xCoordList)   // iterating through generic list
            {
                Console.WriteLine(coord);       // output ball's last 4 positions on the X axis
            }
        }
    }
}
