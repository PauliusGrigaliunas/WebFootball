using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class FormTeamB : Form
    {
        public FormTeamB()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormsTeamB_Load(object sender, EventArgs e)
        {

        }
        public void loadInfo(String name, int victories, int goals, int goalsthis)
        {
            TeamNameLabel.Text = name;
            allVictLabel.Text = victories.ToString();
            allGoalsLabel.Text = goals.ToString();    
            thisGameGoalsLabel.Text = goalsthis.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
