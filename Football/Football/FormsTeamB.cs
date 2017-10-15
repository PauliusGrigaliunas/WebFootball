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
    public partial class FormsTeamB : Form
    {
        public FormsTeamB()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormsTeamB_Load(object sender, EventArgs e)
        {

        }
        public void loadInfo(String name, int victories, int goals)
        {
            label4.Text = name;
            label5.Text = victories.ToString();
            label6.Text = goals.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
