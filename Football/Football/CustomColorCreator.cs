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
        public Hsv hsvColor, newLow, newHigh, hsv1, hsv2, hsv3;
        

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
            this.pictureBox.Size = new System.Drawing.Size(1256, 640);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RequestData);
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(1275, 617);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(132, 35);
            this.closeWindow.TabIndex = 1;
            this.closeWindow.Text = "Set My Color!";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // CustomColorCreator
            // 
            this.ClientSize = new System.Drawing.Size(1419, 655);
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

                this.Close();
            }
            
        }


        private void RequestData(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox.Image);
            Color color = b.GetPixel(e.X, e.Y);
            float hue = color.GetHue();
            float saturation = color.GetSaturation();
            float lightness = color.GetBrightness();

            Image<Hsv, Byte> hsvImage = new Image<Hsv, byte>(b);

            hsvColor = hsvImage[e.X, e.Y];
            System.Diagnostics.Debug.WriteLine(hsvColor.Hue + "  " + hsvColor.Satuation + "  " + hsvColor.Value);
            System.Diagnostics.Debug.WriteLine(color.R + "  " + color.G + "  " + color.B);

            if (PointCounter == 0)
                hsv1 = hsvColor;
            if (PointCounter == 1)
                hsv2 = hsvColor;
            if (PointCounter == 2)
                hsv3 = hsvColor;

            PointCounter++;
            FindColor();
        }


        private void DoCalculations()
        {   // hue
            if(hsv1.Hue >= hsv2.Hue && hsv1.Hue >= hsv3.Hue)
            {
                newHigh.Hue = hsv1.Hue;
            }
            if (hsv2.Hue >= hsv1.Hue && hsv2.Hue >= hsv3.Hue)
            {
                newHigh.Hue = hsv2.Hue;
            }
            if (hsv3.Hue >= hsv1.Hue && hsv3.Hue >= hsv2.Hue)
            {
                newHigh.Hue = hsv3.Hue;
            }

            if (hsv1.Hue <= hsv2.Hue && hsv1.Hue <= hsv3.Hue)
            {
                newLow.Hue = hsv1.Hue;
            }
            if (hsv2.Hue <= hsv1.Hue && hsv2.Hue <= hsv3.Hue)
            {
                newLow.Hue = hsv2.Hue;
            }
            if (hsv3.Hue <= hsv1.Hue && hsv3.Hue <= hsv2.Hue)
            {
                newLow.Hue = hsv3.Hue;
            }
            // sat
            if (hsv1.Satuation >= hsv2.Satuation && hsv1.Satuation >= hsv3.Satuation)
            {
                newHigh.Satuation = hsv1.Satuation;
            }
            if (hsv2.Satuation >= hsv1.Satuation && hsv2.Satuation >= hsv3.Satuation)
            {
                newHigh.Satuation = hsv2.Satuation;
            }
            if (hsv3.Satuation >= hsv1.Satuation && hsv3.Satuation >= hsv2.Satuation)
            {
                newHigh.Satuation = hsv3.Satuation;
            }

            if (hsv1.Satuation <= hsv2.Satuation && hsv1.Satuation <= hsv3.Satuation)
            {
                newLow.Satuation = hsv1.Satuation;
            }
            if (hsv2.Satuation <= hsv1.Satuation && hsv2.Satuation <= hsv3.Satuation)
            {
                newLow.Satuation = hsv2.Satuation;
            }
            if (hsv3.Satuation <= hsv1.Satuation && hsv3.Satuation <= hsv2.Satuation)
            {
                newLow.Satuation = hsv3.Satuation;
            }
            //val
            if (hsv1.Value >= hsv2.Value && hsv1.Value >= hsv3.Value)
            {
                newHigh.Value = hsv1.Value;
            }
            if (hsv2.Value >= hsv1.Value && hsv2.Value >= hsv3.Value)
            {
                newHigh.Value = hsv2.Value;
            }
            if (hsv3.Value >= hsv1.Value && hsv3.Value >= hsv2.Value)
            {
                newHigh.Value = hsv3.Value;
            }

            if (hsv1.Value <= hsv2.Value && hsv1.Value <= hsv3.Value)
            {
                newLow.Value = hsv1.Value;
            }
            if (hsv2.Value <= hsv1.Value && hsv2.Value <= hsv3.Value)
            {
                newLow.Value = hsv2.Value;
            }
            if (hsv3.Value <= hsv1.Value && hsv3.Value <= hsv2.Value)
            {
                newLow.Value = hsv3.Value;
            }

            
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
    }
}
