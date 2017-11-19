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

      
        FootballEntities context;
        InputThread inputThread;
        Teams team = new Teams();
        Lazy<List<teamTable>> allTeams;
        Lazy<List<teamTable>> victories;
        Lazy<List<teamTable>> goals;
        Lazy<List<teamTable>> bestTeams;


        public FormAllTeams()
        {           
     
            InitializeComponent();

            allTeams = new Lazy<List<teamTable>>(() => team.AllDataToList());
            victories = new Lazy<List<teamTable>>(() => team.OrderByVictories());
            goals = new Lazy<List<teamTable>>(() => team.OrderByGoals());
            bestTeams = new Lazy<List<teamTable>>(() => team.BestToList());


        }
     
        
        private void FormAllTeams_Load(object sender, EventArgs e)
        {
            inputThread = InputThread.Instance;
            inputThread.Start();
            FillData();
        }
       
        public void FillData()
        {
            dataGridViewAll.DataSource = team.AllDataToList().Select(i => new { i.Name, i.Victories, i.Goals }).ToList();
  
        }

        private void Colour()
        {
           
            for(int i=0; i<3;i++)
            {
                dataGridViewAll.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
            }


        }
       
        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAll.DataSource = allTeams.Value.Select(i=>new { i.Name, i.Victories, i.Goals }).ToList();
            Colour();
        }

  
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = allTeams.Value.Select(i => new { i.Name, i.Victories, i.Goals }).ToList();
        }

        private void victoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = victories.Value.Select(i => new { i.Name, i.Victories, i.Goals }).ToList();
            Colour();
        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = goals.Value.Select(i => new { i.Name, i.Victories, i.Goals }).ToList();
            Colour();
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = bestTeams.Value.Select(i => new { i.Name, i.Victories, i.Goals }).ToList();
            Colour();
        }

     
    }

}
