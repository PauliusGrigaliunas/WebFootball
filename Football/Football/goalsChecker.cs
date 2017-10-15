﻿using System;
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
        int _xBallPosition { get; set; }
        int _timeElapsed;
        private Stopwatch stopwatche = new Stopwatch();
        VideoCapture _capture { get; set; }
        public string aText;
        public string bText;
        private Stopwatch stopwatch = new Stopwatch();

        private bool isATeamScored = false;
        private bool isBTeamScored = false;

        public GoalsChecker(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }




        public string CheckForScore(string text, bool isTeamScored)
        {
            int temp;
            //stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            _timeElapsed = ts.Seconds;
            if (_timeElapsed >= 3 && isTeamScored == true)
            {
                temp = int.Parse(text);
                temp = temp + 1;
                text = temp.ToString();
                stopwatche.Reset();
                isTeamScored = false;
            }
            return text;
        }

/*
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



        }*/
    }
}