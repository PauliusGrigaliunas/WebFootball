using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Connector
    {
        private string _conectionString = @"Server=tcp:paulius.database.windows.net,1433;Initial Catalog=Football;Persist Security Info=False;User ID=Kamikaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"; 

        public string ConnectionString {
            get {
                    return _conectionString;
                }
        }

        public SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            return con;
        }

    }
}
