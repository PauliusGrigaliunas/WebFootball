using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UnitTestFootball
{
    [TestClass]
    public class GoalsCheckerTests
    {
        private Stopwatch stopwatch = new Stopwatch();
        GoalsChecker gcheck;
        List<int> testList;

        [TestMethod()]
        public void StartStopwatch1Test()
        {
            //declare
            gcheck = new GoalsChecker(stopwatch);
            //act
            gcheck.StartStopwatch(390, 480);
            //assert
            Assert.IsTrue(VideoScreen.isBTeamScored);
        }

        [TestMethod()]
        public void StartStopwatch2Test()
        {
            //declare
            gcheck = new GoalsChecker(stopwatch);
            //act
            gcheck.StartStopwatch(250, 500);
            //assert
            Assert.IsFalse(VideoScreen.isATeamScored);
            Assert.IsFalse(VideoScreen.isBTeamScored);
        }

        [TestMethod()]
        public void CheckForScoreATest()
        {
            //declare
            stopwatch.Start();
            System.Threading.Thread.Sleep(3500);
            gcheck = new GoalsChecker(stopwatch);
           // GoalsChecker.ballGoingRight = false;
            VideoScreen.isATeamScored = true;
            string text = "1";
            //act
            text = gcheck.CheckForScoreA(text);
            //assert
            Assert.AreEqual(2, int.Parse(text));
        }

        [TestMethod()]
        public void CheckForScoreBTest()
        {
            //declare
            stopwatch.Start();
            System.Threading.Thread.Sleep(3500);
            gcheck = new GoalsChecker(stopwatch);
          //  GoalsChecker.ballGoingRight = true;
            VideoScreen.isBTeamScored = true;
            string text = "199";
            //act
            text = gcheck.CheckForScoreB(text);
            //assert
            Assert.AreEqual(200, int.Parse(text));
        }

        [TestMethod()]
        public void DirectionTest()
        {
            //declare
            gcheck = new GoalsChecker(stopwatch);
            testList = new List<int>() { 350, 400, 450 };
            //act
            gcheck.Direction(500, 3, testList);
            //assert
          //  Assert.IsTrue(GoalsChecker.ballGoingRight);
        }
    }
}
