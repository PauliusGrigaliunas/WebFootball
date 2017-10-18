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

        public int blue { get; }

        public int green{ get; }

        public int red { get; }

        public int x { get; }

        public int y { get; }

        int i = 0;
        int[] xCoords = new int[99999999];

        Image<Bgr, byte> imgOriginal { get; set; }
        Image<Gray, byte> imgFiltered { get; set; }

        public Ball()
        {

        }


 /*       public void BallPosition(Image<Bgr, byte> imgCircles,  textXYradius)
        {

            foreach (CircleF circle in GetCircles(imgFiltered))          //searching circles
            {
                if (textXYradius.Text != "") textXYradius.AppendText(Environment.NewLine);

                /*textXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                circle.Radius.ToString("###,000").PadLeft(7));
                textXYradius.ScrollToCaret();

                _xBallPosition = (int)circle.Center.X;                          // get x coordinate(center of a ball)
                gcheck.StartStopwatch(_xBallPosition, imgOriginal.Width);       //start stopwatch to check if it is scored or not   
                gcheck.Direction(_xBallPosition, i, xCoords); i++;              // 
                imgCircles.Draw(circle, new Bgr(Color.Red), 3);                 //draw circles on smoothed image
            }
        }*/
        public CircleF[] GetCircles(Image<Gray, byte> imgGray)
        {
            Gray grayCircle = new Gray(12);
            Gray cannyThreshold = new Gray(26);
            double lAccumResolution = 2.0;
            double minDistanceBtwCircles = 1.0;
            int minRadius = 0;
            int maxRadius = 10;
            return imgGray.HoughCircles(grayCircle, cannyThreshold, lAccumResolution, minDistanceBtwCircles, minRadius, maxRadius)[0];
        }
    }
}
