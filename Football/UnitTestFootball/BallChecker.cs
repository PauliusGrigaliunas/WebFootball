using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;

namespace UnitTestFootball
{
    [TestClass]
    public class BallChecker
    {
        [TestMethod]
        public void TestVideoAndPictureHierarchy()
        {
            Ball ball = new Ball();

            Assert.Equals(ball.Index, ball.Index);

        }
    }
}
