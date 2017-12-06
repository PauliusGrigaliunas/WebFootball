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
    public partial class Path : Form
    {
        public string PathString { set;  get; } 

        public Path()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            PathString = textBox1.Text;
            this.Close();
        }
    }
}
