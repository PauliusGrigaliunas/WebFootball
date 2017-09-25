namespace Football
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplasianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 480);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edgeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1,
            this.pauseToolStripMenuItem1});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Picture";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplasianToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplasianToolStripMenuItem
            // 
            this.laplasianToolStripMenuItem.Name = "laplasianToolStripMenuItem";
            this.laplasianToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.laplasianToolStripMenuItem.Text = "Laplasian";
            this.laplasianToolStripMenuItem.Click += new System.EventHandler(this.laplasianToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click);
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.pauseToolStripMenuItem1.Text = "Pause";
            this.pauseToolStripMenuItem1.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplasianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
    }
}

