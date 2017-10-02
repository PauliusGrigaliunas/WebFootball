using Emgu.CV;
using Emgu.CV.Structure;
using Football;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PictureTest
    {
            [TestMethod]
            private void Piture()
            {
            //Access


            Picture image = new Picture();

            //Act

            Image< Rgb ,byte > pictures;

            pictures = null;

            //Assert
            Assert.AreEqual(pictures, image.GetImage);

        }
        
    }
}

