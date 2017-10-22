namespace Football
{
    partial class VideoScreen
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
            this.btnAllTeamStatistics = new System.Windows.Forms.Button();
            this.teamBButton = new System.Windows.Forms.Button();
            this.teamAButton = new System.Windows.Forms.Button();
            this.saveScoreButton = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bTeamLabel = new System.Windows.Forms.Label();
            this.aTeamLabel = new System.Windows.Forms.Label();
            this.TeamBLabel = new System.Windows.Forms.Label();
            this.TeamALabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.FilteredPictureBox = new System.Windows.Forms.PictureBox();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPauseStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAllTeamStatistics);
            this.panel1.Controls.Add(this.teamBButton);
            this.panel1.Controls.Add(this.teamAButton);
            this.panel1.Controls.Add(this.saveScoreButton);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bTeamLabel);
            this.panel1.Controls.Add(this.aTeamLabel);
            this.panel1.Controls.Add(this.TeamBLabel);
            this.panel1.Controls.Add(this.TeamALabel);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.FilteredPictureBox);
            this.panel1.Controls.Add(this.OriginalPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 767);
            this.panel1.TabIndex = 2;
            // 
            // btnAllTeamStatistics
            // 
            this.btnAllTeamStatistics.Location = new System.Drawing.Point(731, 542);
            this.btnAllTeamStatistics.Name = "btnAllTeamStatistics";
            this.btnAllTeamStatistics.Size = new System.Drawing.Size(176, 35);
            this.btnAllTeamStatistics.TabIndex = 39;
            this.btnAllTeamStatistics.Text = "All Teams Statistics";
            this.btnAllTeamStatistics.UseVisualStyleBackColor = true;
            this.btnAllTeamStatistics.Click += new System.EventHandler(this.button4_Click);
            // 
            // teamBButton
            // 
            this.teamBButton.Location = new System.Drawing.Point(582, 64);
            this.teamBButton.Name = "teamBButton";
            this.teamBButton.Size = new System.Drawing.Size(84, 35);
            this.teamBButton.TabIndex = 38;
            this.teamBButton.Text = "Team B ";
            this.teamBButton.UseVisualStyleBackColor = true;
            this.teamBButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // teamAButton
            // 
            this.teamAButton.Location = new System.Drawing.Point(302, 64);
            this.teamAButton.Name = "teamAButton";
            this.teamAButton.Size = new System.Drawing.Size(85, 35);
            this.teamAButton.TabIndex = 37;
            this.teamAButton.Text = "Team A";
            this.teamAButton.UseVisualStyleBackColor = true;
            this.teamAButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveScoreButton
            // 
            this.saveScoreButton.Location = new System.Drawing.Point(439, 135);
            this.saveScoreButton.Name = "saveScoreButton";
            this.saveScoreButton.Size = new System.Drawing.Size(96, 36);
            this.saveScoreButton.TabIndex = 36;
            this.saveScoreButton.Text = "Save Score";
            this.saveScoreButton.UseVisualStyleBackColor = true;
            this.saveScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(158, 551);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 28);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(90, 551);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(64, 27);
            this.btnPause.TabIndex = 34;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(10, 551);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 27);
            this.btnPlay.TabIndex = 33;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = ":";
            // 
            // bTeamLabel
            // 
            this.bTeamLabel.AutoSize = true;
            this.bTeamLabel.Location = new System.Drawing.Point(436, 98);
            this.bTeamLabel.Name = "bTeamLabel";
            this.bTeamLabel.Size = new System.Drawing.Size(66, 13);
            this.bTeamLabel.TabIndex = 31;
            this.bTeamLabel.Text = "bTeamLabel";
            // 
            // aTeamLabel
            // 
            this.aTeamLabel.AutoSize = true;
            this.aTeamLabel.Location = new System.Drawing.Point(510, 98);
            this.aTeamLabel.Name = "aTeamLabel";
            this.aTeamLabel.Size = new System.Drawing.Size(66, 13);
            this.aTeamLabel.TabIndex = 30;
            this.aTeamLabel.Text = "aTeamLabel";
            // 
            // TeamBLabel
            // 
            this.TeamBLabel.AutoSize = true;
            this.TeamBLabel.Location = new System.Drawing.Point(499, 64);
            this.TeamBLabel.Name = "TeamBLabel";
            this.TeamBLabel.Size = new System.Drawing.Size(47, 13);
            this.TeamBLabel.TabIndex = 29;
            this.TeamBLabel.Text = "Team B:";
            // 
            // TeamALabel
            // 
            this.TeamALabel.AutoSize = true;
            this.TeamALabel.Location = new System.Drawing.Point(424, 64);
            this.TeamALabel.Name = "TeamALabel";
            this.TeamALabel.Size = new System.Drawing.Size(47, 13);
            this.TeamALabel.TabIndex = 28;
            this.TeamALabel.Text = "Team A:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.scoreLabel.Location = new System.Drawing.Point(457, 29);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(61, 20);
            this.scoreLabel.TabIndex = 27;
            this.scoreLabel.Text = "Score:";
            // 
            // FilteredPictureBox
            // 
            this.FilteredPictureBox.Location = new System.Drawing.Point(495, 176);
            this.FilteredPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilteredPictureBox.Name = "FilteredPictureBox";
            this.FilteredPictureBox.Size = new System.Drawing.Size(480, 320);
            this.FilteredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilteredPictureBox.TabIndex = 1;
            this.FilteredPictureBox.TabStop = false;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Location = new System.Drawing.Point(11, 176);
            this.OriginalPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(480, 320);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            this.OriginalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startPauseStopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CameraToolStripMenuItem,
            this.VideoToolStripMenuItem,
            this.PictureToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // CameraToolStripMenuItem
            // 
            this.CameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartCameraToolStripMenuItem,
            this.StopCameraToolStripMenuItem,
            this.PauseCameraToolStripMenuItem});
            this.CameraToolStripMenuItem.Name = "CameraToolStripMenuItem";
            this.CameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CameraToolStripMenuItem.Text = "Camera";
            // 
            // StartCameraToolStripMenuItem
            // 
            this.StartCameraToolStripMenuItem.Name = "StartCameraToolStripMenuItem";
            this.StartCameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartCameraToolStripMenuItem.Text = "Start";
            this.StartCameraToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // StopCameraToolStripMenuItem
            // 
            this.StopCameraToolStripMenuItem.Name = "StopCameraToolStripMenuItem";
            this.StopCameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StopCameraToolStripMenuItem.Text = "Stop";
            this.StopCameraToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // PauseCameraToolStripMenuItem
            // 
            this.PauseCameraToolStripMenuItem.Name = "PauseCameraToolStripMenuItem";
            this.PauseCameraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PauseCameraToolStripMenuItem.Text = "Pause";
            this.PauseCameraToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // VideoToolStripMenuItem
            // 
            this.VideoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartVideoToolStripMenuItem,
            this.StopVideoToolStripMenuItem,
            this.PauseVideoToolStripMenuItem});
            this.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem";
            this.VideoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.VideoToolStripMenuItem.Text = "Video";
            // 
            // StartVideoToolStripMenuItem
            // 
            this.StartVideoToolStripMenuItem.Name = "StartVideoToolStripMenuItem";
            this.StartVideoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartVideoToolStripMenuItem.Text = "Start";
            this.StartVideoToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // StopVideoToolStripMenuItem
            // 
            this.StopVideoToolStripMenuItem.Name = "StopVideoToolStripMenuItem";
            this.StopVideoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StopVideoToolStripMenuItem.Text = "Stop";
            this.StopVideoToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click);
            // 
            // PauseVideoToolStripMenuItem
            // 
            this.PauseVideoToolStripMenuItem.Name = "PauseVideoToolStripMenuItem";
            this.PauseVideoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PauseVideoToolStripMenuItem.Text = "Pause";
            this.PauseVideoToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // PictureToolStripMenuItem
            // 
            this.PictureToolStripMenuItem.Name = "PictureToolStripMenuItem";
            this.PictureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PictureToolStripMenuItem.Text = "Picture";
            this.PictureToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // startPauseStopToolStripMenuItem
            // 
            this.startPauseStopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.PauseToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.startPauseStopToolStripMenuItem.Name = "startPauseStopToolStripMenuItem";
            this.startPauseStopToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.startPauseStopToolStripMenuItem.Text = "Start/Pause/Stop";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem2_Click);
            // 
            // PauseToolStripMenuItem
            // 
            this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
            this.PauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PauseToolStripMenuItem.Text = "Pause";
            this.PauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem2_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem2_Click);
            // 
            // VideoScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 609);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VideoScreen";
            this.Text = "Let\'s play Foosball!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseVideoToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TeamBLabel;
        private System.Windows.Forms.Label TeamALabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button saveScoreButton;
        private System.Windows.Forms.Button btnAllTeamStatistics;
        private System.Windows.Forms.Button teamBButton;
        private System.Windows.Forms.Button teamAButton;
        private System.Windows.Forms.ToolStripMenuItem startPauseStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        internal System.Windows.Forms.Label aTeamLabel;
        internal System.Windows.Forms.PictureBox OriginalPictureBox;
        internal System.Windows.Forms.Label bTeamLabel;
        internal System.Windows.Forms.PictureBox FilteredPictureBox;
    }
}

