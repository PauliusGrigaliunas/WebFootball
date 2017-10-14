using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

 

namespace Football
{
   public  class Teams
    {
        private int teamNumber;
        private string teamName;
        //  private int victories;
        // private int goals;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Emilija.DELL-EMILIJOS\Documents\GitHub\FootBall\Football\Football\database121.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sa;
        DataTable dt = new DataTable();


        public Teams() { }


        public void addToTable(String name, int victories, int goals)
        {
            try
            {
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM teamTable";
                cmd.ExecuteNonQuery();

                
                sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                cmd.CommandText = "INSERT INTO teamTable (Name,Victories,Goals) VALUES('" + name + "','" + victories + "','" + goals + "')";
                cmd.ExecuteNonQuery();              //vykdom savo uzklausa virsuj parasyta

                //MessageBox.Show("Teams successfully registered!");

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public bool name_CheckIfExsist(String data)
        {
            bool exsists = false;
            for (int i = 1; i < dt.Rows.Count;i++)
            {
                try
                {
                    if (data == dt.Rows[i][1].ToString())
                    {
                        exsists = true;
                    }
                }
                catch (System.IndexOutOfRangeException ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            return exsists;

        }




    }
}
