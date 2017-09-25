using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Football
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void takeAPicture() {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = imgInput.Bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            takeAPicture();               
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "System message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takeAPicture();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(50, 20);
            pictureBox1.Image = imgCanny.Bitmap;


        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image <Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image <Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(1,1,3);
            pictureBox1.Image = imgSobel.Bitmap;
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplasian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgLaplasian = imgGray.Laplace(3);
            pictureBox1.Image = imgLaplasian.Bitmap;
        }
    }
}
