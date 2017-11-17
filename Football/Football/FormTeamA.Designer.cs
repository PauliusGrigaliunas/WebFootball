namespace Football
{
    partial class FormTeamB
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
            this.goalsLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.allVictLabel = new System.Windows.Forms.Label();
            this.allGoalsLabel = new System.Windows.Forms.Label();
            this.allLabel = new System.Windows.Forms.Label();
            this.thisGameLabel = new System.Windows.Forms.Label();
            this.thisGameGoalsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // victLabel
            // 
            this.victLabel.AutoSize = true;
            this.victLabel.Location = new System.Drawing.Point(49, 103);
            this.victLabel.Name = "victLabel";
            this.victLabel.Size = new System.Drawing.Size(47, 13);
            this.victLabel.TabIndex = 1;
            this.victLabel.Text = "Victories";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(50, 159);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(34, 13);
            this.goalsLabel.TabIndex = 2;
            this.goalsLabel.Text = "Goals";
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TeamNameLabel.Location = new System.Drawing.Point(177, 20);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(35, 13);
            this.TeamNameLabel.TabIndex = 3;
            this.TeamNameLabel.Text = "label4";
            // 
            // allVictLabel
            // 
            this.allVictLabel.AutoSize = true;
            this.allVictLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.allVictLabel.Location = new System.Drawing.Point(163, 103);
            this.allVictLabel.Name = "allVictLabel";
            this.allVictLabel.Size = new System.Drawing.Size(35, 13);
            this.allVictLabel.TabIndex = 4;
            this.allVictLabel.Text = "label5";
            // 
            // allGoalsLabel
            // 
            this.allGoalsLabel.AutoSize = true;
            this.allGoalsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.allGoalsLabel.Location = new System.Drawing.Point(163, 159);
            this.allGoalsLabel.Name = "allGoalsLabel";
            this.allGoalsLabel.Size = new System.Drawing.Size(35, 13);
            this.allGoalsLabel.TabIndex = 5;
            this.allGoalsLabel.Text = "label6";
            // 
            // allLabel
            // 
            this.allLabel.AutoSize = true;
            this.allLabel.Location = new System.Drawing.Point(163, 77);
            this.allLabel.Name = "allLabel";
            this.allLabel.Size = new System.Drawing.Size(18, 13);
            this.allLabel.TabIndex = 6;
            this.allLabel.Text = "All";
            // 
            // thisGameLabel
            // 
            this.thisGameLabel.AutoSize = true;
            this.thisGameLabel.Location = new System.Drawing.Point(241, 77);
            this.thisGameLabel.Name = "thisGameLabel";
            this.thisGameLabel.Size = new System.Drawing.Size(58, 13);
            this.thisGameLabel.TabIndex = 7;
            this.thisGameLabel.Text = "This Game";
            // 
            // thisGameGoalsLabel
            // 
            this.thisGameGoalsLabel.AutoSize = true;
            this.thisGameGoalsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.thisGameGoalsLabel.Location = new System.Drawing.Point(241, 159);
            this.thisGameGoalsLabel.Name = "thisGameGoalsLabel";
            this.thisGameGoalsLabel.Size = new System.Drawing.Size(35, 13);
            this.thisGameGoalsLabel.TabIndex = 9;
            this.thisGameGoalsLabel.Text = "label9";
            // 
            // FormTeamB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 250);
            this.Controls.Add(this.thisGameGoalsLabel);
            this.Controls.Add(this.thisGameLabel);
            this.Controls.Add(this.allLabel);
            this.Controls.Add(this.allGoalsLabel);
            this.Controls.Add(this.allVictLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.goalsLabel);
            this.Controls.Add(this.victLabel);
            this.Name = "FormTeamB";
            this.Text = "Team B";
            this.Load += new System.EventHandler(this.FormTeamB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label victLabel;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label allVictLabel;
        private System.Windows.Forms.Label allGoalsLabel;
        private System.Windows.Forms.Label allLabel;
        private System.Windows.Forms.Label thisGameLabel;
        private System.Windows.Forms.Label thisGameGoalsLabel;
    }
}