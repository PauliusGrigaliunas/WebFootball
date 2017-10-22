using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;

namespace UnitTestFootball
{
    [TestClass]
    public class PictureTest
    {
        [TestMethod]
        public void ConvertToGrayWithoutInput()
        {
            Picture picture = new Picture();

            var a = picture.ConvertToGray();

            Assert.ReferenceEquals(a, null);
        }

        [TestMethod]
        public void ConvertToSobelWithoutInput()
        {
            Picture picture = new Picture();

            var a = picture.ConvertToSobel(1, 1, 1);

            Assert.ReferenceEquals(a, null);
        }

        [TestMethod]
        public void ConvertToCannyWithoutInput()
        {
            Picture picture = new Picture();

            var a = picture.ConvertToCanny(1, 1);

            Assert.ReferenceEquals(a, null);
        }

        [TestMethod]
        public void ConvertToLaplaseWithoutInput()
        {
            Picture picture = new Picture();

            var a = picture.ConvertToLaplase(9);

            Assert.ReferenceEquals(a, null);
        }

        [TestMethod]
        public void ConvertInColorRangeWithoutInput()
        {
            Picture picture = new Picture();

            var a = picture.ColorRange(0,0,0,255,255,255);

            Assert.ReferenceEquals(a, null);
        }


    }
}
