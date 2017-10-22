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
    public partial class FormTeamA : Form
    {
        public FormTeamA()
        {
            InitializeComponent();
        }

        private void FormTeamA_Load(object sender, EventArgs e)
        {

        }
        public void loadInfo(String name, int victories, int goals, int goalsthis)
        {
            TeamName.Text = name;
            victAllLabel.Text = victories.ToString();
            allGoalsLabel.Text = goals.ToString();
            thisGameGoalsLabel.Text = goalsthis.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
