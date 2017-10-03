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
using System.Threading;
using Emgu.CV.UI;

namespace Football
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        Image<Gray, byte> imgGray;
        Image<Ycc, byte> imgYcc;
        private Picture imageInput;
        private Video video;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "System message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        //Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageInput = new Picture();
            pictureBox1.Image = imageInput.TakeAPicture().Bitmap;
        }
        //layers
        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToCanny(20, 50).Bitmap;
            }
            else if (video != null)
            {
                /* bandymas
                Mat mat = new Mat();
                video.GetVideo.Retrieve(mat);
                pictureBox2.Image = mat.ToImage<Gray, byte>().Bitmap;
                */
            }
            else return;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToSobel(1, 1, 3).Bitmap;
            }
            else if (video != null)
            {

            }
            else return;
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToLaplase(3).Bitmap;
            }
            else if (video != null)
            {

            }
            else return;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToGray().Bitmap;
            }
            else if (video != null)
            {

            }
            else return;

        }

        //Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                video = new Video();
                capture = video.Camera();
            }
            if (capture != null)
            {
                Application.Idle += ProcessFrame;
            }
        }

//
        private void ProcessFrame(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = video.PutAVideo().Bitmap;
            }
            catch (Exception)
            {

                MessageBox.Show("klaida!");
                return;
            }
        }


        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                Application.Idle -= ProcessFrame;
                capture = null;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                Application.Idle -= ProcessFrame;
            }
        }
        // Video

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                video = new Video();
                capture = video.TakeAVideo();
                capture.ImageGrabbed += Capture_ImageGrabbed;
                capture.Start();
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.Image = video.PutAVideo().Bitmap;

                //pictureBox2.Image = video.ConvertToGray().Bitmap;
                //pictureBox2.Image = mat.ToImage<Gray, byte>().Bitmap;
                pictureBox2.Image = video.ColorRange( 0, 0, 140, 80, 255, 255).Bitmap;

                Thread.Sleep((int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(video.ToString());
            if (capture != null)
            {
                capture.Stop();
                capture = null;

            }
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }


        //-----------------------------+
        // Ycc
        private void yccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgYcc = imageInput.GetImage.Convert<Ycc, byte>();
            pictureBox2.Image = imgYcc.Bitmap;
        }

        //coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            Color pixelColor = bitmap.GetPixel(e.X, e.Y);
            MessageBox.Show(pixelColor.ToString());
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*int lowBlue = Convert.ToInt32(comboBox1.Text);
            int highBlue = Convert.ToInt32(comboBox4.Text);
            int lowGreen = Convert.ToInt32(comboBox2.Text);
            int highGreen = Convert.ToInt32(comboBox5.Text);
            int lowRed = Convert.ToInt32(comboBox3.Text);
            int highRed = Convert.ToInt32(comboBox6.Text); */


            if (imageInput.GetImage == null) return;
            //Image<Gray, Byte> imgRange = new Image<Bgr, byte>(imgInput.Width, imgInput.Height, new Bgr(0,0,0)); 

            Image<Gray, Byte> imgRange = imageInput.GetImage.InRange(new Bgr(0, 0, 187), new Bgr(100, 255, 255));
            //Image<Gray, Byte> imgRange = imgInput.InRange(new Bgr(lowBlue, lowGreen, lowRed), new Bgr(highBlue, highGreen, highRed));

            //imgRange.SmoothGaussian(9);

            pictureBox2.Image = imageInput.ColorRange(0, 0, 187, 100, 255, 255).Bitmap;

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}
