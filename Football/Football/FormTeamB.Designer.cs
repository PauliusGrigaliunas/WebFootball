namespace Football
{
    partial class FormTeamA
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
            this.victLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.victAllLabel = new System.Windows.Forms.Label();
            this.allGoalsLabel = new System.Windows.Forms.Label();
            this.allLabel = new System.Windows.Forms.Label();
            this.thisGameLabel = new System.Windows.Forms.Label();
            this.thisGameGoalsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // victLabel
            // 
            this.victLabel.AutoSize = true;
            this.victLabel.Location = new System.Drawing.Point(41, 107);
            this.victLabel.Name = "victLabel";
            this.victLabel.Size = new System.Drawing.Size(47, 13);
            this.victLabel.TabIndex = 1;
            this.victLabel.Text = "Victories";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(41, 158);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(34, 13);
            this.goalLabel.TabIndex = 2;
            this.goalLabel.Text = "Goals";
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TeamName.Location = new System.Drawing.Point(157, 32);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(35, 13);
            this.TeamName.TabIndex = 3;
            this.TeamName.Text = "label4";
            // 
            // victAllLabel
            // 
            this.victAllLabel.AutoSize = true;
            this.victAllLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.victAllLabel.Location = new System.Drawing.Point(146, 107);
            this.victAllLabel.Name = "victAllLabel";
            this.victAllLabel.Size = new System.Drawing.Size(35, 13);
            this.victAllLabel.TabIndex = 4;
            this.victAllLabel.Text = "label5";
            // 
            // allGoalsLabel
            // 
            this.allGoalsLabel.AutoSize = true;
            this.allGoalsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.allGoalsLabel.Location = new System.Drawing.Point(146, 158);
            this.allGoalsLabel.Name = "allGoalsLabel";
            this.allGoalsLabel.Size = new System.Drawing.Size(35, 13);
            this.allGoalsLabel.TabIndex = 5;
            this.allGoalsLabel.Text = "label6";
            // 
            // allLabel
            // 
            this.allLabel.AutoSize = true;
            this.allLabel.Location = new System.Drawing.Point(146, 80);
            this.allLabel.Name = "allLabel";
            this.allLabel.Size = new System.Drawing.Size(18, 13);
            this.allLabel.TabIndex = 6;
            this.allLabel.Text = "All";
            // 
            // thisGameLabel
            // 
            this.thisGameLabel.AutoSize = true;
            this.thisGameLabel.Location = new System.Drawing.Point(232, 80);
            this.thisGameLabel.Name = "thisGameLabel";
            this.thisGameLabel.Size = new System.Drawing.Size(56, 13);
            this.thisGameLabel.TabIndex = 7;
            this.thisGameLabel.Text = "This game";
            // 
            // thisGameGoalsLabel
            // 
            this.thisGameGoalsLabel.AutoSize = true;
            this.thisGameGoalsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.thisGameGoalsLabel.Location = new System.Drawing.Point(232, 158);
            this.thisGameGoalsLabel.Name = "thisGameGoalsLabel";
            this.thisGameGoalsLabel.Size = new System.Drawing.Size(35, 13);
            this.thisGameGoalsLabel.TabIndex = 9;
            this.thisGameGoalsLabel.Text = "label9";
            // 
            // FormTeamA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 267);
            this.Controls.Add(this.thisGameGoalsLabel);
            this.Controls.Add(this.thisGameLabel);
            this.Controls.Add(this.allLabel);
            this.Controls.Add(this.allGoalsLabel);
            this.Controls.Add(this.victAllLabel);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.victLabel);
            this.Name = "FormTeamA";
            this.Text = "Team A";
            this.Load += new System.EventHandler(this.FormTeamA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label victLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label victAllLabel;
        private System.Windows.Forms.Label allGoalsLabel;
        private System.Windows.Forms.Label allLabel;
        private System.Windows.Forms.Label thisGameLabel;
        private System.Windows.Forms.Label thisGameGoalsLabel;
    }
}