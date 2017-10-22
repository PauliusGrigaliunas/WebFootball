using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;

namespace UnitTestFootball
{
    [TestClass]
    public class BallChecker
    {
        [TestMethod]
        public void TestMethod1()
        {
            Picture picture = new Picture();
            Video video = new Video();


            var first = picture.TakeAPicture();
            var second = video.TakeAPicture();

            Assert.ReferenceEquals(first, second);
        }
    }
}
