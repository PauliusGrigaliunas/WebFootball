using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Football
{
    public partial class FormAllTeams : Form
    {

        private int rows;
        Connector conector = new Connector();

        public FormAllTeams()
        {
            InitializeComponent();
            fillData();
        }
      
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
            fillData();
        }
        DataTable dt = new DataTable();
        public void fillData()
        {

            SqlConnection con = conector.Connect();


            SqlCommand cmd;
             SqlDataAdapter sa;
           
             con.Open();

             cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "SELECT * FROM teamTable";
          
             sa = new SqlDataAdapter(cmd);
             sa.Fill(dt);

             rows = dt.Rows.Count;
            
            DataView view = dt.DefaultView;
            view.Sort = "Victories DESC, Goals DESC";
            DataTable sortedDate = view.ToTable();
          
            dataGridView1.DataSource = sortedDate;
            dataGridView1.DataMember = sortedDate.TableName;
            con.Close();

                
            }

    }
}
