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

        public void loadInfo(String name, int victories, int goals, int goalsthis)
        {
            TeamNameLabel.Text = name;
            allVictLabel.Text = victories.ToString();
            allGoalsLabel.Text = goals.ToString();    
            thisGameGoalsLabel.Text = goalsthis.ToString();
        }

    }
}
