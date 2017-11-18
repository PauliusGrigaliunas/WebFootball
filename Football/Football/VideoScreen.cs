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

    public partial class VideoScreen : Form
    {
        //objects
        Picture _picture = new Picture();
        Ball _ball = new Ball();
        Video _video;
        Commentator comment = new Commentator();

        public bool isTournament = false;

        //variables
        public String _nameFirstTeam { get; set; }
        public String _nameSecondTeam { get; set; }
        private string _ballColour = "Orange";

        public int _TeamAScores { get; set; }
        public int _TeamBScores { get; set; }
        public int _VictA { get; set; }
        public int _GoalA { get; set; }
        public int _VictB { get; set; }
        public int _GoalB { get; set; }
        public bool isRinged = false;

        public static bool isATeamScored = false;
        public static bool isBTeamScored = false;


        //picture variables
        Image<Gray, byte> _imgFiltered { get; set; }
        Image<Gray, byte> _ImgZones { get; set; }

        //variables
        private int _i = 0;
        public string ATeam, BTeam;
        //
        public List<int> _xCoordList = new List<int>();
        //

        GoalsChecker _gcheck;
        private Mat mat;
        private Stopwatch _stopwatch = new Stopwatch();

        public void TimeTick(object sender, EventArgs e)
        {
            _gcheck = new GoalsChecker(_stopwatch);
            aTeamLabel.Text = _gcheck.CheckForScoreA(aTeamLabel.Text);
            bTeamLabel.Text = _gcheck.CheckForScoreB(bTeamLabel.Text);

            mat = _video.Capture.QueryFrame();       //getting frames            
            if (mat == null) return;

            _video.ImgOriginal = mat.ToImage<Bgr, byte>().Resize(OriginalPictureBox.Width, OriginalPictureBox.Height, Inter.Linear);
            OriginalPictureBox.Image = _video.ImgOriginal.Bitmap;


            //_ball.BallDetection(_video, _gcheck, "Orange");
            BallDetection(_ballColour);

            //_home.FilteredPictureBox.Image = imgCircles.Bitmap;
        }

        public VideoScreen()
        {
            InitializeComponent();
            _video = new Video(this);
        }

        public VideoScreen(String teamA, String teamB)
        {
            InitializeComponent();
            _video = new Video(this);
            TeamALabel.Text = teamA;
            TeamBLabel.Text = teamB;

            ATeam = TeamALabel.Text;
            BTeam = TeamBLabel.Text;
        }
        //menu strip tool items
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

        public void BallDetection(string colourName = "Default", int colorNumber = 0)
        {
            Colour colour;
            //! pritaikyti protingai galime Enum
            if (colourName != "Default")
            {
                colour = _ball.colour.First(x => x.Name == colourName);
            }
            else
                colour = _ball.colour.First(x => x.Number == colorNumber);


            Colour clr;
            clr = _ball.colour.First(x => x.Name == "BlackDarkGates");
            clr = _ball.colour.First(x => x.Number == 101);
            _ImgZones = _video.GetFilteredImageZones(clr);
            _ball.ImgGates = _ImgZones;
            _ball.at = ATeam;
            _ball.bt = BTeam;


            Image<Bgr, byte> imgCircles = _video.ImgOriginal.CopyBlank();     //copy parameters of original frame image
            _ball.ImgFiltered = _video.GetFilteredImage(colour);
            _ball.ImgOriginal = _video.ImgOriginal;

            _ball.Gcheck = _gcheck;
            _ball.xCoordList = _xCoordList;
            _ball.Index = _i;
            _ball.BallPositionDraw(imgCircles);
            _i = _ball.Index;
            _xCoordList = _ball.xCoordList;
            _gcheck = _ball.Gcheck;
            if (_ball.PositionComment != BallPos.Text) isRinged = false;
            BallPos.Text = _ball.PositionComment;
            Comment();
        }

        private void Comment()
        {
            if (_ball.PositionComment == ATeam + " Team Defenders" || _ball.PositionComment == BTeam + " Team Defenders")
            {
                if ( isRinged == false)
                {
                    comment.StopAllTracks();
                    comment.PlayRandomSound(16, 18);
                    isRinged = true;
                }
            }
            else if (_ball.PositionComment == ATeam + " Team Attackers" || _ball.PositionComment == BTeam + " Team Attackers")
            {
                if (isRinged == false)
                {
                    comment.StopAllTracks();
                    comment.PlayRandomSound(14, 16);
                    isRinged = true;
                }
            }
            else if (_ball.PositionComment == ATeam + " Team Middle 5" || _ball.PositionComment == BTeam + " Team Middle 5")
            {
                if (isRinged == false)
                {
                    comment.StopAllTracks();
                    comment.PlayRandomSound(14, 16);
                    isRinged = true;
                }
            }
            else
            {
                if (isRinged == false)
                {
                    comment.StopAllTracks();
                    comment.PlayRandomSound(12, 14);
                    isRinged = true;
                }
            }
        }

        // Buttons------------
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "Start")
            {
                _video.StartVideo();
                btnPlay.Text = "Pause";
            }
            else
            {
                _video.Pause();
                btnPlay.Text = "Start";
            }
            comment.StopAllTracks();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _video.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _video.Stop();
            btnPlay.Text = "Start";
        }
        // End Buttons------------

        //closing form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _video.Pause();
            if(!isTournament) Application.Exit();

        }

        //Picture
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_picture != null)
            {
                OriginalPictureBox.Image = _picture.TakeAPicture().Bitmap;
            }
        }

        //Coordinates
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)                          //checking coordinates of the video
        {
            MessageBox.Show("X= " + e.X.ToString() + ";  Y= " + e.Y.ToString() + ";");
        }

        //+----------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            comment.StopAllTracks();
            aTeamLabel.Text = "0";
            bTeamLabel.Text = "0";
            comment.PlayIndexedSoundWithLoop(11);
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            _video.Stop();
            _TeamBScores = int.Parse(aTeamLabel.Text);
            _TeamAScores = int.Parse(bTeamLabel.Text);

            _VictA = 0;
            _GoalA = 0;
            _VictB = 0;
            _GoalB = 0;

            Teams team = new Teams();
            Predicate<String> compare = x => team.NameCheckIfExsist(x) == true;


            if (_TeamAScores > _TeamBScores)
            {
                _VictA=_VictA+1;
                comment.PlayIndexedSound(9);
                DialogResult result = MessageBox.Show("Winner: " + _nameFirstTeam + "!\nScore: " + _TeamAScores + " : " + _TeamBScores);
                if (result == DialogResult.Cancel || result == DialogResult.OK)
                {
                    comment.StopAllTracks();
                }
            }
            else if (_TeamAScores < _TeamBScores)
            {
                _VictB= _VictB +1;
                comment.PlayIndexedSound(9);
                DialogResult result = MessageBox.Show("Winner: " + _nameSecondTeam + "!\nScore: " + _TeamAScores + " : " + _TeamBScores);
                if (result == DialogResult.Cancel || result == DialogResult.OK)
                {
                    comment.StopAllTracks();
                }
            }
            else
            {
                comment.PlayIndexedSound(9);
                DialogResult result = MessageBox.Show("Draw!\nScore: " + _TeamAScores + " : " + _TeamBScores);
                if (result == DialogResult.Cancel || result == DialogResult.OK)
                {
                    comment.StopAllTracks();
                }
            }

            if (!compare(_nameFirstTeam))
            {
                team.AddToTable(_nameFirstTeam, _VictA, _TeamAScores);
                _GoalA = _TeamAScores;
            }
            else
            {
                _VictA = _VictA + team.GetVictories(_nameFirstTeam);
                _GoalA = team.GetGoals(_nameFirstTeam) + _TeamAScores;
                team.InsertToTable(_nameFirstTeam, _VictA, _GoalA);
            }

            if (!compare(_nameSecondTeam))
            {
                team.AddToTable(_nameSecondTeam, _VictB, _TeamBScores);
                _GoalB= _TeamBScores;
            }
            else
            {
                _VictB = _VictB + team.GetVictories(_nameSecondTeam);
                _GoalB = team.GetGoals(_nameSecondTeam) + _TeamBScores;
                team.InsertToTable(_nameSecondTeam, _VictB, _GoalB);
            }
            comment.PlayIndexedSound(11);
            
        }      


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
 //           MainMenu a = new MainMenu();
 //           a.
            FormAllTeams form = new FormAllTeams();
            form.Show();
        }

        private void teamAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamA form = new FormTeamA();
            form.loadInfo(_nameFirstTeam, _VictA, _GoalA, _TeamAScores);
            form.Show();
        }

        private void teamBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamB form = new FormTeamB();
            form.loadInfo(_nameSecondTeam, _VictB, _GoalB, _TeamBScores);
            form.Show();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ballColour = "Orange";
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ballColour = "Yellow";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_video.Check())
            {
                int temp = int.Parse(aTeamLabel.Text);
                temp = 0;
                aTeamLabel.Text = temp.ToString();

                temp = int.Parse(bTeamLabel.Text);
                temp = 0;
                bTeamLabel.Text = temp.ToString();
            }
        }
    }
}