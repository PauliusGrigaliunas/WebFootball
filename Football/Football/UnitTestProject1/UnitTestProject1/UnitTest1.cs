using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Football;
namespace UnitTesting1
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            MainMenu menu = new MainMenu();
            bool name = true;
            bool namet1;
          
            namet1 = menu.nameNotEmpty();
          
            Assert.AreEqual(name, namet1);

        }
    }
}
