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
using System.Threading;

namespace Football
{
    public partial class FormAllTeams : Form
    {
        Lazy<FootballEntities> lazy = new Lazy<Football.FootballEntities>();
        FootballEntities context;
        InputThread inputThread;

        public FormAllTeams()
        {           
            context = lazy.Value;
            InitializeComponent();       
        }
     
        
        public void FillData()
        {           
            var team = from i in context.teamTables
                         orderby i.Victories descending
                         select new { i.Name, i.Victories, i.Goals };

            dataAllTeamsGrid.DataSource = team.ToList();
            Colour();
        }

        private void FormAllTeams_Load(object sender, EventArgs e)
        {
            inputThread = InputThread.Instance;
            inputThread.Start();
            FillData();
        }

        private void VictoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var team = from i in context.teamTables
                       orderby i.Victories descending
                       select new{i.Name, i.Victories};
                       
            dataAllTeamsGrid.DataSource = team.ToList();
            Colour();

        }

        private void GoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var team = from i in context.teamTables
                       orderby i.Goals descending
                       select new { i.Name, i.Goals };


            dataAllTeamsGrid.DataSource = team.ToList();
            Colour();

        }

        private void VictoriesGoals0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var team = from i in context.teamTables
                       where i.Victories != 0
                       where i.Goals != 0
                       orderby i.Victories descending
                       select new { i.Name, i.Victories, i.Goals };

            dataAllTeamsGrid.DataSource = team.ToList();
            Colour();

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
            Colour();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Colour()
        {
           
            for(int i=0; i<3;i++)
            {
                dataAllTeamsGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
            }


        }

    }

}
