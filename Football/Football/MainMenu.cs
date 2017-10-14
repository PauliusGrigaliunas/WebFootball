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
    public partial class MainMenu : Form
    {
        String name1;
        String name2;
        Teams team = new Teams();
     

    
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            if(team.name_CheckIfExsist(name1) == false)
            {
                team.addToTable(name1,0,0);
            }

            if (team.name_CheckIfExsist(name2) == false)
            {
                team.addToTable(name2, 0, 0);
            }

            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1_TextChange = (TextBox)sender;
            this.name1 = textBox1_TextChange.Text;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox2_TextChange = (TextBox)sender;
            this.name2 = textBox2_TextChange.Text;
            
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        
    }
}
