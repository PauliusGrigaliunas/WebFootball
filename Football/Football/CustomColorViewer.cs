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
    public class CustomColorViewer : Form
    {
        private PictureBox pictureBox;
        private Button closeWindow;
        private Image<Bgr, byte> photo;
        int PointCounter = 0;
        public Hsv hsvColor, newLow, newHigh, hsv1, hsv2, hsv3;
        public Bgr bgr, bgr1, bgr2, bgr3;
        private Label label1;
        private Label hsvlow;
        private Label label2;
        private PictureBox colorRectangle;
        private Label label3;
        private Label hsvloww;
        private Label hsvhigh;
        private Label avgrgb;

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.closeWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hsvlow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorRectangle = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hsvloww = new System.Windows.Forms.Label();
            this.hsvhigh = new System.Windows.Forms.Label();
            this.avgrgb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(449, 251);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RequestData);
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(483, 207);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(171, 47);
            this.closeWindow.TabIndex = 1;
            this.closeWindow.Text = "Set custom color and get back to game";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the photo 3 times ";
            // 
            // hsvlow
            // 
            this.hsvlow.AutoSize = true;
            this.hsvlow.Location = new System.Drawing.Point(467, 40);
            this.hsvlow.Name = "hsvlow";
            this.hsvlow.Size = new System.Drawing.Size(69, 17);
            this.hsvlow.TabIndex = 4;
            this.hsvlow.Text = "HSV Low:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "HSV High:";
            // 
            // colorRectangle
            // 
            this.colorRectangle.Location = new System.Drawing.Point(497, 135);
            this.colorRectangle.Name = "colorRectangle";
            this.colorRectangle.Size = new System.Drawing.Size(132, 53);
            this.colorRectangle.TabIndex = 6;
            this.colorRectangle.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Avg BGR:";
            // 
            // hsvloww
            // 
            this.hsvloww.AutoSize = true;
            this.hsvloww.Location = new System.Drawing.Point(542, 40);
            this.hsvloww.Name = "hsvloww";
            this.hsvloww.Size = new System.Drawing.Size(89, 17);
            this.hsvloww.TabIndex = 8;
            this.hsvloww.Text = "Calculating...";
            // 
            // hsvhigh
            // 
            this.hsvhigh.AutoSize = true;
            this.hsvhigh.Location = new System.Drawing.Point(542, 75);
            this.hsvhigh.Name = "hsvhigh";
            this.hsvhigh.Size = new System.Drawing.Size(89, 17);
            this.hsvhigh.TabIndex = 9;
            this.hsvhigh.Text = "Calculating...";
            // 
            // avgrgb
            // 
            this.avgrgb.AutoSize = true;
            this.avgrgb.Location = new System.Drawing.Point(542, 105);
            this.avgrgb.Name = "avgrgb";
            this.avgrgb.Size = new System.Drawing.Size(89, 17);
            this.avgrgb.TabIndex = 10;
            this.avgrgb.Text = "Calculating...";
            // 
            // CustomColorViewer
            // 
            this.ClientSize = new System.Drawing.Size(666, 275);
            this.Controls.Add(this.avgrgb);
            this.Controls.Add(this.hsvhigh);
            this.Controls.Add(this.hsvloww);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorRectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hsvlow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.closeWindow);
            this.Name = "CustomColorViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public CustomColorViewer(Image<Bgr, byte> img)
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
        }

        private void RequestData(object sender, MouseEventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox.Image);
            Color color = b.GetPixel(e.X, e.Y);
            bgr.Blue = color.B;
            bgr.Green = color.G;
            bgr.Red = color.R;

            Image<Hsv, Byte> hsvImage = photo.Convert<Hsv, Byte>();
            System.Diagnostics.Debug.WriteLine(e.X + "  " + e.Y);
            hsvColor = hsvImage[e.Y, e.X];
           
            if (PointCounter == 0)
            {
                hsv1 = hsvColor;
                bgr1 = bgr;
            }
            if (PointCounter == 1)
            {
                hsv2 = hsvColor;
                bgr2 = bgr;
            }
            if (PointCounter == 2)
            {
                hsv3 = hsvColor;
                bgr3 = bgr;
            }

            PointCounter++;
            FindColor();
        }

        private void showStuff()
        {
            hsvloww.Text = newLow.ToString();
            hsvhigh.Text = newHigh.ToString();
            avgrgb.Text = bgr.ToString();
            Color clr = Color.FromArgb((int)bgr.Red, (int)bgr.Green, (int)bgr.Blue);
            colorRectangle.BackColor = clr;
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

            if (newLow.Hue >= 10)
                newLow.Hue = newLow.Hue - 10;
            else
                newLow.Hue = 0;

            if (newHigh.Hue <= 170)
                newHigh.Hue = newHigh.Hue + 10;
            else
                newHigh.Hue = 180;

            if (newLow.Satuation >= 10)
                newLow.Satuation = newLow.Satuation - 10;
            else
                newLow.Satuation = 0;

            if (newHigh.Satuation <= 245)
                newHigh.Satuation = newHigh.Satuation + 10;
            else
                newHigh.Satuation = 255;

            if (newLow.Value >= 10)
                newLow.Value = newLow.Value - 10;
            else
                newLow.Value = 0;

            if (newHigh.Value <= 245)
                newHigh.Value = newHigh.Value + 10;
            else
                newHigh.Value = 255;

            bgr.Blue = (int)(bgr1.Blue + bgr2.Blue + bgr3.Blue) / 3;
            bgr.Green = (int)(bgr1.Green + bgr2.Green + bgr3.Green) / 3;
            bgr.Red = (int)(bgr1.Red + bgr2.Red + bgr3.Red) / 3;

            showStuff();
            
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
