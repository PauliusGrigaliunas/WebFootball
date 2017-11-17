using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Football
{
    public partial class TeamNames : Form
    {

        private string _name1;
        private string _name2;
        private string _name3;
        private string _name4;
        
        public TeamNames()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _name2 = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _name3 = textBox3.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            _name4 = textBox4.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predicate<String> compare = x => (x != null) && (Regex.IsMatch(x, @"([a-zA-Z0-9]{4,50})"));

            if ((compare(_name1)) && (compare(_name2))&& (compare(_name3)) && (compare(_name4)))
            {
                if ((_name1 != _name2) && (_name4 != _name3))   //pridet
                {
                    Tournament names = new Tournament(_name1, _name2, _name3, _name4);
                    names.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Team names must be different ");
                }
            }
            else
            {
                MessageBox.Show("Team names must be at least 4 charachters long ");
            }
        }


    }
}
