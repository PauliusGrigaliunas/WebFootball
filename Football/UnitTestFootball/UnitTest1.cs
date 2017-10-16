using Football;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFootball
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Access
            Connector connector = new Connector();
            //SqlConnection first = connector.Connect();

            //Act
            string constring = @"Server=tcp:paulius.database.windows.net,1433;Initial Catalog=Football;Persist Security Info=False;User ID=Kamikaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

            //SqlConnection second = new SqlConnection(constring);

            int a = 0;


            //Assert
            Assert.AreEqual(a, a);
        }
    }
}
