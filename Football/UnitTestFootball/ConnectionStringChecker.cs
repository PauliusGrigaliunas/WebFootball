
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football;

namespace UnitTestFootball
{
    [TestClass]
    public class ConnectionStringChecker
    {
        [TestMethod]
        public void ConnectionString()
        {
            //Access
            //Connector connector = new Connector();
           // SqlConnection first = connector.Connect();

            //Act
C:\Users\Paulius\Documents\GitHub\FootBall\Football\Football\App.config            string constring = @"Server=tcp:paulius.database.windows.net,1433;Initial Catalog=Football;Persist Security Info=False;User ID=Kamikaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

            SqlConnection second = new SqlConnection(constring);

            //Assert
            //Assert.ReferenceEquals(first, second);
        }
    }
}
