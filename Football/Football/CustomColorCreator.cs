using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Football
{
    public class CustomColorCreator : Form
    {
        private PictureBox pictureBox;
        private Button closeWindow;
        private Image<Bgr, byte> photo;
        int PointCounter = 0;

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.closeWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(628, 320);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseClick += new MouseEventHandler(this.RequestData);
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(705, 297);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(132, 35);
            this.closeWindow.TabIndex = 1;
            this.closeWindow.Text = "Set My Color!";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // CustomColorCreator
            // 
            this.ClientSize = new System.Drawing.Size(849, 347);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.pictureBox);
            this.Name = "CustomColorCreator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        public CustomColorCreator(Image<Bgr, byte> img)
        {
            InitializeComponent();
            photo = img;
            pictureBox.Image = photo.Bitmap;
            FindColor();
        }

        private void FindColor()
        {
            buttonClickability(false);

            if (PointCounter >= 3)
            {
                DoCalculations();
            }
            convert();
        }


        private void RequestData(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox.Image);
            Color color = b.GetPixel(e.X, e.Y);
            float hue = color.GetHue();
            float saturation = color.GetSaturation();
            float lightness = color.GetBrightness();
            
            MessageBox.Show("X=" + e.X.ToString() + ";  Y=" + e.Y.ToString() + "\nB=" + color.B + " G=" + color.G + " R=" + color.R + "\nH=" + hue + "\nS=" + saturation + "\nL=" + lightness + ";");

            PointCounter++;
            FindColor();
        }


        private void DoCalculations()
        {



            buttonClickability(true);
        }

        private void buttonClickability (bool enable)
        {
            if(enable)
            {
                closeWindow.Enabled = true;
            }
            else
            {
                closeWindow.Enabled = false;
            }
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void pictureBox_Click(object sender, EventArgs e)
        {
            //
        }

        private void convert()
        {
            Bitmap bmp = photo.ToBitmap();
            Image<Hsv, Byte> hsvImage = new Image<Hsv, byte>(bmp);

            Color color = bmp.GetPixel(100, 100);

            Hsv hsvColor = hsvImage[100, 100];
            System.Diagnostics.Debug.WriteLine(hsvColor.Hue + "  " + hsvColor.Satuation + "  " + hsvColor.Value);
            System.Diagnostics.Debug.WriteLine(color.R + "  " + color.G + "  " + color.B);
        }
    }
}
