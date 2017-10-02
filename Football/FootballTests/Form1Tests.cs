using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Football.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void DivideTest()
        {
            int expected = 100;
            int actual = Form1.Divide(600, 6);
            Assert.AreEqual(expected, actual);
        }
    }
}