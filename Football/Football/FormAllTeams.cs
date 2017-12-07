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

        InputThread inputThread;
        Teams team = new Teams();

        public FormAllTeams()
        {            
            InitializeComponent();        
        }
     
        
        private void FormAllTeams_Load(object sender, EventArgs e)
        {
            inputThread = InputThread.Instance;
            inputThread.Start();
            FillData();
        }
       
        public void FillData()
        {
            dataGridViewAll.DataSource = team.AllDataToList().Select(i => new { i.Name, i.Victories}).ToList();
  
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
            FillData();
            Colour();
        }

  
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillData();
            
        }

        private void victoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = team.OrderByVictories().Select(i => new { i.Name, i.Victories }).ToList();
            Colour();
        }


        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {// connect to names
            
            var games = team.AllGamesToList().Select(i => new { i.FirstTeam, i.SecondTeam,
                i.FirstTeamScore,i.SecondTeamScore }).ToList();
            var teams = team.AllDataToList().Select(i => new {i.Id, i.Name, i.Victories }).ToList();

            var list1 = (from t in teams
                        join g in games
                        on t.Id equals g.FirstTeam into allGames
                        from item in allGames
                        select new { t.Name , item.FirstTeamScore, item.SecondTeam, item.SecondTeamScore }).ToList();

            var list2 = (from i in list1
                         join t in teams
                         on i.SecondTeam equals t.Id into allGames1
                         from item in allGames1
                         let Team1 = i.Name
                         let Team2 = item.Name
                         orderby i.FirstTeamScore descending, i.SecondTeamScore descending
                         select new { Team1, i.FirstTeamScore, Team2, i.SecondTeamScore }).ToList();


           dataGridViewAll.DataSource = list2.ToList() ;
            Colour();
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var teams = team.AllDataToList().Select(i => new { i.Id, i.Name, i.Victories }).ToList();

            var team1 = team.AllGamesToList().
                Select(i => new {
                i.FirstTeam ,
                i.FirstTeamScore,
            }).ToList();
          
            var team2 = team.AllGamesToList().Select(i => new {
                i.SecondTeam,
                i.SecondTeamScore,
            }).ToList();
            var list2 = 
                ///concat

            dataGridViewAll.DataSource = list2.ToList();
            Colour();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
