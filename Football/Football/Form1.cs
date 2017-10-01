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
            else return;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToSobel(1, 1, 3).Bitmap;
            }
            else return;
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToLaplase(3).Bitmap;
            }
            else return;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageInput != null)
            {
                pictureBox2.Image = imageInput.ConvertToGray().Bitmap;
            }
            else if (video.GetVideo != null)
            {

            }
            else return;

        }

        //Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new VideoCapture(0);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            if (capture != null)
            {
                Application.Idle += ProcessFrame;
            }
        }


        private void ProcessFrame(object sender, EventArgs e)
        {
            try
            {
                Mat mat = new Mat();
                capture.Retrieve(mat);
                pictureBox1.Image = mat.ToImage<Bgr, byte>().Bitmap;
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
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }
        // Video
        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files |*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (capture == null)
                {


                    try
                    {
                        capture = new Emgu.CV.VideoCapture(ofd.FileName);

                    }
                    catch (NullReferenceException excpt)
                    {
                        MessageBox.Show(excpt.Message);
                    }
                }
                if (capture != null)
                {
                    Application.Idle += ProcessFrame;
                }
            }


        }


        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(video.ToString());
            if (capture != null)
            {
                Application.Idle -= ProcessFrame;

            }
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat mat = new Mat();
                capture.Retrieve(mat);
                pictureBox1.Image = mat.ToImage<Bgr, byte>().Bitmap;



                Image<Gray, Byte> imgRange = mat.ToImage<Bgr, byte>().InRange(new Bgr(0, 0, 140), new Bgr(80, 255, 255));

                /*
                                pictureBox2.Image = imgRange.Bitmap;
                                Thread.Sleep((int)
                                    video.GetVideo.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //-----------------------------
        // Ycc
        private void iccToolStripMenuItem_Click(object sender, EventArgs e)
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

        // colors
        // Blue

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Green
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Red
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            pictureBox2.Image = imgRange.Bitmap;

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
