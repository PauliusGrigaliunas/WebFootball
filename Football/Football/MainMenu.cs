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
using System.Text.RegularExpressions;

namespace Football
{
    public partial class MainMenu : Form
    {
        //String name1;
        // String name2;
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
           
            if ((IfMatch(Name1)) && (IfMatch(Name2)))
            {
                if (Name1 != Name2)
                {
                    ToTable(Name1);
                    ToTable(Name2);
                    form.setName1(Name1);
                    form.setName2(Name2);
                    form.Show();
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
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1_TextChange = (TextBox)sender;
            Name1 = textBox1_TextChange.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox2_TextChange = (TextBox)sender;
            Name2 = textBox2_TextChange.Text;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private bool IfMatch(String data)
        {
            bool mtch = false;

            String pattern1 = @"([a-zA-Z0-9]{4,50})";  //gali buti skaiciai arba raides, bet 4 simboliai butinai

         
            if(data != null)
            {
                if (Regex.IsMatch(data, pattern1))
                {
                    mtch = true;
                }

            }


            return mtch;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ToTable(String data)
        {         
            Teams team = new Teams();
            if (team.NameCheckIfExsist(data) != true)
            {
                team.AddToTable(data, 0, 0);
            }
        }
    }
}
