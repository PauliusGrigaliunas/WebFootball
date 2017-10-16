using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UnitTestFootball
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOrStopwatchStarted()
        {
            int seconds = 10;
            Form1 form = new Form1();
            Stopwatch stopwatch = new Stopwatch();
            form.isATeamScored = false;
            form.isBTeamScored = false;
            int mili;

            Stopwatch watch = new Stopwatch();
            form.stopwatch = new Stopwatch();
            form.StartStopwatch(450);
            watch = form.stopwatch;
            TimeSpan ts = watch.Elapsed;
            mili = ts.Miliseconds / 10;
            Assert.AreNotEqual(mili, 0);
        }
    }
}
