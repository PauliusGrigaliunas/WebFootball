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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BallImgBox = new System.Windows.Forms.PictureBox();
            this.PlayerImgBox = new System.Windows.Forms.PictureBox();
            this.playGroundLabel = new System.Windows.Forms.Label();
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
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ballColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BallImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BallImgBox);
            this.panel1.Controls.Add(this.PlayerImgBox);
            this.panel1.Controls.Add(this.playGroundLabel);
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
            this.panel1.Controls.Add(this.OriginalPictureBox);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 823);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BallImgBox
            // 
            this.BallImgBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BallImgBox.BackgroundImage")));
            this.BallImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BallImgBox.Location = new System.Drawing.Point(425, 9);
            this.BallImgBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BallImgBox.Name = "BallImgBox";
            this.BallImgBox.Size = new System.Drawing.Size(80, 70);
            this.BallImgBox.TabIndex = 41;
            this.BallImgBox.TabStop = false;
            // 
            // PlayerImgBox
            // 
            this.PlayerImgBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerImgBox.BackgroundImage")));
            this.PlayerImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerImgBox.Location = new System.Drawing.Point(136, 9);
            this.PlayerImgBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerImgBox.Name = "PlayerImgBox";
            this.PlayerImgBox.Size = new System.Drawing.Size(88, 70);
            this.PlayerImgBox.TabIndex = 41;
            this.PlayerImgBox.TabStop = false;
            // 
            // playGroundLabel
            // 
            this.playGroundLabel.AutoSize = true;
            this.playGroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGroundLabel.Location = new System.Drawing.Point(243, 127);
            this.playGroundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playGroundLabel.Name = "playGroundLabel";
            this.playGroundLabel.Size = new System.Drawing.Size(125, 25);
            this.playGroundLabel.TabIndex = 40;
            this.playGroundLabel.Text = "PlayGround";
            // 
            // saveScoreButton
            // 
            this.saveScoreButton.Location = new System.Drawing.Point(425, 492);
            this.saveScoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveScoreButton.Name = "saveScoreButton";
            this.saveScoreButton.Size = new System.Drawing.Size(144, 54);
            this.saveScoreButton.TabIndex = 36;
            this.saveScoreButton.Text = "Save Score";
            this.saveScoreButton.UseVisualStyleBackColor = true;
            this.saveScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(259, 492);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 54);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(13, 118);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(85, 33);
            this.btnPause.TabIndex = 34;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(90, 492);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(147, 54);
            this.btnPlay.TabIndex = 33;
            this.btnPlay.Text = "Start";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = ":";
            // 
            // bTeamLabel
            // 
            this.bTeamLabel.AutoSize = true;
            this.bTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTeamLabel.Location = new System.Drawing.Point(255, 82);
            this.bTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bTeamLabel.Name = "bTeamLabel";
            this.bTeamLabel.Size = new System.Drawing.Size(101, 20);
            this.bTeamLabel.TabIndex = 31;
            this.bTeamLabel.Text = "bTeamLabel";
            // 
            // aTeamLabel
            // 
            this.aTeamLabel.AutoSize = true;
            this.aTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTeamLabel.Location = new System.Drawing.Point(351, 82);
            this.aTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aTeamLabel.Name = "aTeamLabel";
            this.aTeamLabel.Size = new System.Drawing.Size(101, 20);
            this.aTeamLabel.TabIndex = 30;
            this.aTeamLabel.Text = "aTeamLabel";
            // 
            // TeamBLabel
            // 
            this.TeamBLabel.AutoSize = true;
            this.TeamBLabel.Location = new System.Drawing.Point(336, 50);
            this.TeamBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamBLabel.Name = "TeamBLabel";
            this.TeamBLabel.Size = new System.Drawing.Size(61, 17);
            this.TeamBLabel.TabIndex = 29;
            this.TeamBLabel.Text = "Team B:";
            // 
            // TeamALabel
            // 
            this.TeamALabel.AutoSize = true;
            this.TeamALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamALabel.Location = new System.Drawing.Point(244, 50);
            this.TeamALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamALabel.Name = "TeamALabel";
            this.TeamALabel.Size = new System.Drawing.Size(61, 17);
            this.TeamALabel.TabIndex = 28;
            this.TeamALabel.Text = "Team A:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.scoreLabel.Location = new System.Drawing.Point(275, 11);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(76, 25);
            this.scoreLabel.TabIndex = 27;
            this.scoreLabel.Text = "Score:";
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Location = new System.Drawing.Point(13, 154);
            this.OriginalPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(628, 320);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            this.OriginalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(87, 823);
            this.menuStrip2.TabIndex = 42;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.teamAToolStripMenuItem,
            this.teamBToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // teamAToolStripMenuItem
            // 
            this.teamAToolStripMenuItem.Name = "teamAToolStripMenuItem";
            this.teamAToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.teamAToolStripMenuItem.Text = "TeamA";
            this.teamAToolStripMenuItem.Click += new System.EventHandler(this.teamAToolStripMenuItem_Click);
            // 
            // teamBToolStripMenuItem
            // 
            this.teamBToolStripMenuItem.Name = "teamBToolStripMenuItem";
            this.teamBToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.teamBToolStripMenuItem.Text = "TeamB";
            this.teamBToolStripMenuItem.Click += new System.EventHandler(this.teamBToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startPauseStopToolStripMenuItem,
            this.ballColourToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // CameraToolStripMenuItem
            // 
            this.CameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartCameraToolStripMenuItem,
            this.StopCameraToolStripMenuItem,
            this.PauseCameraToolStripMenuItem});
            this.CameraToolStripMenuItem.Name = "CameraToolStripMenuItem";
            this.CameraToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.CameraToolStripMenuItem.Text = "Camera";
            // 
            // StartCameraToolStripMenuItem
            // 
            this.StartCameraToolStripMenuItem.Name = "StartCameraToolStripMenuItem";
            this.StartCameraToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StartCameraToolStripMenuItem.Text = "Start";
            this.StartCameraToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // StopCameraToolStripMenuItem
            // 
            this.StopCameraToolStripMenuItem.Name = "StopCameraToolStripMenuItem";
            this.StopCameraToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StopCameraToolStripMenuItem.Text = "Stop";
            this.StopCameraToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // PauseCameraToolStripMenuItem
            // 
            this.PauseCameraToolStripMenuItem.Name = "PauseCameraToolStripMenuItem";
            this.PauseCameraToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
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
            this.VideoToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.VideoToolStripMenuItem.Text = "Video";
            // 
            // StartVideoToolStripMenuItem
            // 
            this.StartVideoToolStripMenuItem.Name = "StartVideoToolStripMenuItem";
            this.StartVideoToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StartVideoToolStripMenuItem.Text = "Start";
            this.StartVideoToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // StopVideoToolStripMenuItem
            // 
            this.StopVideoToolStripMenuItem.Name = "StopVideoToolStripMenuItem";
            this.StopVideoToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StopVideoToolStripMenuItem.Text = "Stop";
            this.StopVideoToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click);
            // 
            // PauseVideoToolStripMenuItem
            // 
            this.PauseVideoToolStripMenuItem.Name = "PauseVideoToolStripMenuItem";
            this.PauseVideoToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.PauseVideoToolStripMenuItem.Text = "Pause";
            this.PauseVideoToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // PictureToolStripMenuItem
            // 
            this.PictureToolStripMenuItem.Name = "PictureToolStripMenuItem";
            this.PictureToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.PictureToolStripMenuItem.Text = "Picture";
            this.PictureToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
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
            this.startPauseStopToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.startPauseStopToolStripMenuItem.Text = "Start/Pause/Stop";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem2_Click);
            // 
            // PauseToolStripMenuItem
            // 
            this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
            this.PauseToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.PauseToolStripMenuItem.Text = "Pause";
            this.PauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem2_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem2_Click);
            // 
            // ballColourToolStripMenuItem
            // 
            this.ballColourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orangeToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.ballColourToolStripMenuItem.Name = "ballColourToolStripMenuItem";
            this.ballColourToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.ballColourToolStripMenuItem.Text = "Ball Colour";
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // VideoScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(653, 629);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VideoScreen";
            this.Text = "Let\'s play Foosball!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BallImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem startPauseStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        internal System.Windows.Forms.Label aTeamLabel;
        internal System.Windows.Forms.PictureBox OriginalPictureBox;
        internal System.Windows.Forms.Label bTeamLabel;
        private System.Windows.Forms.Label playGroundLabel;
        private System.Windows.Forms.PictureBox BallImgBox;
        private System.Windows.Forms.PictureBox PlayerImgBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ballColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
    }
}

