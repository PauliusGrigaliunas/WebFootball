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

        

        public FormAllTeams()
        {
            InitializeComponent();
         
        }
      
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
          
        }
        
        public void fillData()
        {
            
                FootballEntities context = new FootballEntities();
            var team = from i in context.teamTables
                       orderby i.Victories descending
                       select i;

                BindingSource bi = new BindingSource();
            //   bi.DataSource = context.teamTables.ToList();
            bi.DataSource = team;
            dataGridView1.DataSource = bi;
                dataGridView1.Refresh();

           


        }

        private void FormAllTeams_Load(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
