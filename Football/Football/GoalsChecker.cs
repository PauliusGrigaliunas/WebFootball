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
using Emgu.CV.CvEnum;
using Emgu.CV.Cuda;
using System.Drawing;
using System.Diagnostics;

namespace Football
{
    public class GoalsChecker
    {
        bool isBTeamScored = false;
        bool isATeamScored = false;
        int _xBallPosition { get; set; }
        int _timeElapsed = 0;
        private Stopwatch stopwatch = new Stopwatch();
        VideoCapture _capture { get; set; }
        Image<Bgr, byte> imgInput = null;
        public string aText;
        public string bText;

        public GoalsChecker(string a, string b)
        {
            aText = a;
            bText = b;
        }


        public void CheckForScore()
        {
            int temp;
            //stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            _timeElapsed = ts.Seconds;
            if (_timeElapsed >= 3 && isBTeamScored == true)
            {
                temp = int.Parse(bText);
                temp = temp + 1;
                bText = temp.ToString();
                stopwatch.Reset();
                isBTeamScored = false;
            }
            else if (_timeElapsed >= 3 && isATeamScored == true)
            {
                temp = int.Parse(aText);
                temp = temp + 1;
                aText = temp.ToString();
                stopwatch.Reset();
                isATeamScored = false;
            }
        }

        public void StartStopwatch(int x)
        {
            if (x > 440)
            {
                isATeamScored = false;
                isBTeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else if (x < 45)
            {
                isBTeamScored = false;
                isATeamScored = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else
            {
                isBTeamScored = false;
                isATeamScored = false;
                stopwatch.Reset();
            }

        }


    }
}
