using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
namespace UnitTestFootball
{
    [TestClass]
    public class Name
    {
        [TestMethod]
        public void NameExsists()
        {
            String nm = "labas";
            bool check = true;
            bool rezult;
            Teams team = new Teams();

            rezult = team.NameCheckIfExsist(nm);

            Assert.Equals(check, rezult);
        }
    }
}
