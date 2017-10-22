using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Cuda;
using System.Data.SqlClient;
namespace Football
{

    public partial class Form1 : Form
    {
        //objects
        Picture _picture = new Picture();
        Ball _ball = new Ball();
        Video _video;

        //variables
        public String _nameFirstTeam { get; set; }
        public String _nameSecondTeam { get; set; }

        public int _TeamAScores { get; set; }
        public int _TeamBScores { get; set; }
        public int _VictA { get; set; }
        public int _GoalA { get; set; }
        public int _VictB { get; set; }
        public int _GoalB { get; set; }

        public static bool isATeamScored = false;
        public static bool isBTeamScored = false;

        public Form1()
        {
            InitializeComponent();
            _video = new Video(this);
        }
        //Camera
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _video.StartCamera();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _video.Pause();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _video.Stop();
        }


        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _video.StartVideo();
        }

        private void startToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _video.StartVideo();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _video.Pause();
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _video.Stop();
        }

        private void pauseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _video.Pause();
        }

        private void stopToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _video.Stop();
        }
        // End Menu items------------
        // Buttons------------

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _video.StartVideo();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _video.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _video.Stop();
        }
        // End Buttons------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _video.Pause();
            Application.Exit();
        }
    
        //Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_picture != null) { 
            pictureBox1.Image = _picture.TakeAPicture().Bitmap;
            }
        }
        //coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)                          //checking coordinates of the video
        {
            MessageBox.Show("X= " + e.X.ToString() + ";  Y= " + e.Y.ToString() + ";");
        }
        //+----------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            aTeamLabel.Text = "0";
            bTeamLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._TeamBScores = int.Parse(bTeamLabel.Text);
            this._TeamAScores = int.Parse(aTeamLabel.Text);

            _VictA = 0;
            _GoalA = 0;
            _VictB = 0;
            _GoalB = 0;
            //kokia info lentelej
            Teams team = new Teams();

            _VictA = team.GetVictories(_nameFirstTeam);
            _GoalA = team.GetGoals(_nameFirstTeam);
            _VictB = team.GetVictories(_nameSecondTeam);
            _GoalB = team.GetGoals(_nameSecondTeam);

            _GoalA = _GoalA + _TeamAScores;     
            _GoalB = _GoalB + _TeamBScores;
            if (_TeamAScores > _TeamBScores)
            {
                _VictA = _VictA + 1;
            }
            else if (_TeamAScores < _TeamBScores)
            {
                _VictB = _VictB + 1;
            }
       
           team.InsertToTable(_nameFirstTeam, _VictA, _GoalA);
           team.InsertToTable(_nameSecondTeam, _VictB, _GoalB);

            MessageBox.Show("Saved");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAllTeams form = new FormAllTeams();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsTeamB form = new FormsTeamB();
            form.loadInfo(_nameSecondTeam, _VictB, _GoalB, _TeamBScores);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTeamA form = new FormTeamA();
            form.loadInfo(_nameFirstTeam, _VictA, _GoalA, _TeamAScores);
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}