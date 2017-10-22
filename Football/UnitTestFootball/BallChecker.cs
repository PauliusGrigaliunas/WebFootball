using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace UnitTestFootball
{
    [TestClass]
    public class BallChecker
    {
        [TestMethod]
        public void TestBallPositionDrawWithoutArgument()
        {

            Ball ball = new Ball();
            var a = ball.Index;
            ball.BallPositionDraw(null);
            var b = ball.Index;

            Assert.AreEqual(a, b);

        }
    }
}
