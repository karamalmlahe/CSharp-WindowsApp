using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace App
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        private bool GoUpp = false;
        private bool GoDown = false;
        private int Score;
        private Random rnd = new Random();

        private void lblUP_MouseDown(object sender, MouseEventArgs e)
        {
            GoUpp = true;
            TimerForBox.Start();
        }

        private void lblUP_MouseUp(object sender, MouseEventArgs e)
        {
            GoUpp = false;
        }

        private void lblDown_MouseDown(object sender, MouseEventArgs e)
        {
            GoDown = true;
            TimerForBox.Start();
        }

        private void lblDown_MouseUp(object sender, MouseEventArgs e)
        {
            GoDown = false;
        }

        public void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                GoUpp = true;
                TimerForBox.Start();
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                GoDown = true;
                TimerForBox.Start();
            }
        }

        public void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                GoUpp = false;
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                GoDown = false;
        }

        private void TimerForBox_Tick(object sender, EventArgs e)
        {
            if (GoUpp == true && lblBoxGame.Top > 0 )
                lblBoxGame.Top -= 2;
            else if (GoDown == true && lblBoxGame.Top < (panelGameZone.Size.Height - lblBoxGame.Size.Height))
                lblBoxGame.Top += 2;
            TimerForBox.Interval = 1;
        }

        private void SetLocationAndHeightToColumnsInGame()
        {
            //1 UP
            int randomSizeH = rnd.Next(0, 200);
            lblWallUp1.Size = new Size(lblWallDown1.Size.Width, randomSizeH);
            lblWallUp1.Location = new Point(488, 0);
            //1 Down
            randomSizeH = rnd.Next(0, 200 - randomSizeH);
            lblWallDown1.Size = new Size(lblWallDown1.Size.Width, randomSizeH);
            lblWallDown1.Location = new Point(488, panelGameZone.Size.Height - randomSizeH);

            //2 UP
            randomSizeH = rnd.Next(0, 200);
            lblWallUp2.Size = new Size(lblWallDown1.Size.Width, randomSizeH);
            lblWallUp2.Location = new Point(610, 0);
            //2 Down
            randomSizeH = rnd.Next(0, 200 - randomSizeH);
            lblWallDown2.Size = new Size(lblWallDown2.Size.Width, randomSizeH);
            lblWallDown2.Location = new Point(610, panelGameZone.Size.Height - randomSizeH);

            //3 UP
            randomSizeH = rnd.Next(0, 200);
            lblWallUp3.Size = new Size(lblWallDown3.Size.Width, randomSizeH);
            lblWallUp3.Location = new Point(732, 0);
            //3 Down
            randomSizeH = rnd.Next(0, 200 - randomSizeH);
            lblWallDown3.Size = new Size(lblWallDown3.Size.Width, randomSizeH);
            lblWallDown3.Location = new Point(732, panelGameZone.Size.Height - randomSizeH);

            //4 UP
            randomSizeH = rnd.Next(0, 200);
            lblWallUp4.Size = new Size(lblWallDown4.Size.Width, randomSizeH);
            lblWallUp4.Location = new Point(854, 0);
            //4 Down
            randomSizeH = rnd.Next(0, 200 - randomSizeH);
            lblWallDown4.Size = new Size(lblWallDown4.Size.Width, randomSizeH);
            lblWallDown4.Location = new Point(854, panelGameZone.Size.Height - randomSizeH);
        }

        private void lblStartGame_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != "")
            {
                Score = 0;
                lblUP.Enabled = true;
                lblDown.Enabled = true;
                lblStartGame.Enabled = false;
                txtBoxName.ReadOnly = true;
                SetLocationAndHeightToColumnsInGame();
                timerStartGame.Start();
            }
            else
                MessageBox.Show("Please Enter Name", "Karam App");
        }

        private void timerStartGame_Tick(object sender, EventArgs e)
        {
                int speed;
                if (Score < 1000)
                    speed = 1;
                else if (Score < 2000)
                    speed = 2;
                else if (Score < 3000)
                    speed = 3;
                else
                    speed = 4;


                lblScore.Text = "Score : " + Score;
                if (lblWallDown1.Left + lblWallDown1.Size.Width > 0 && lblWallUp1.Left + lblWallUp1.Size.Width > 0)
                {
                    lblWallDown1.Left -= speed;
                    lblWallUp1.Left -= speed;
                }
                else
                {
                    int randomSizeH = rnd.Next(0, 200);
                    lblWallUp1.Size = new Size(lblWallDown1.Size.Width, randomSizeH);
                    lblWallUp1.Location = new Point(488, 0);
                    randomSizeH = rnd.Next(0, 200 - randomSizeH);
                    lblWallDown1.Size = new Size(lblWallDown1.Size.Width, randomSizeH);
                    lblWallDown1.Location = new Point(488, panelGameZone.Size.Height - randomSizeH);
                }

                if (lblWallDown2.Left + lblWallDown2.Size.Width > 0 && lblWallUp2.Left + lblWallUp2.Size.Width > 0)
                {
                    lblWallDown2.Left -= speed;
                    lblWallUp2.Left -= speed;
                }
                else
                {
                    int randomSizeH = rnd.Next(0, 200);
                    lblWallUp2.Size = new Size(lblWallDown2.Size.Width, randomSizeH);
                    lblWallUp2.Location = new Point(488, 0);
                    randomSizeH = rnd.Next(0, 200 - randomSizeH);
                    lblWallDown2.Size = new Size(lblWallDown2.Size.Width, randomSizeH);
                    lblWallDown2.Location = new Point(488, panelGameZone.Size.Height - randomSizeH);
                }

                if (lblWallDown3.Left + lblWallDown3.Size.Width > 0 && lblWallUp3.Left + lblWallUp3.Size.Width > 0)
                {
                    lblWallDown3.Left -= speed;
                    lblWallUp3.Left -= speed;
                }
                else
                {
                    int randomSizeH = rnd.Next(0, 200);
                    lblWallUp3.Size = new Size(lblWallDown3.Size.Width, randomSizeH);
                    lblWallUp3.Location = new Point(488, 0);
                    randomSizeH = rnd.Next(0, 200 - randomSizeH);
                    lblWallDown3.Size = new Size(lblWallDown3.Size.Width, randomSizeH);
                    lblWallDown3.Location = new Point(488, panelGameZone.Size.Height - randomSizeH);
                }

                if (lblWallDown4.Left + lblWallDown4.Size.Width > 0 && lblWallUp4.Left + lblWallUp4.Size.Width > 0)
                {
                    lblWallDown4.Left -= speed;
                    lblWallUp4.Left -= speed;
                }
                else
                {
                    //4 UP
                    int randomSizeH = rnd.Next(0, 200);
                    lblWallUp4.Size = new Size(lblWallDown4.Size.Width, randomSizeH);
                    lblWallUp4.Location = new Point(488, 0);
                    //4 Down
                    randomSizeH = rnd.Next(0, 200 - randomSizeH);
                    lblWallDown4.Size = new Size(lblWallDown4.Size.Width, randomSizeH);
                    lblWallDown4.Location = new Point(488, panelGameZone.Size.Height - randomSizeH);
                }

                if (lblBoxGame.Bounds.IntersectsWith(lblWallUp1.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallDown1.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallUp2.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallDown2.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallUp3.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallDown3.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallUp4.Bounds)
                    || lblBoxGame.Bounds.IntersectsWith(lblWallDown4.Bounds))
                {
                timerStartGame.Stop();
                TimerForBox.Stop();

                lblDown.Enabled = false;
                lblUP.Enabled = false;
                lblStartGame.Enabled = true;
                txtBoxName.ReadOnly = false;


                BinaryFile f = new BinaryFile();
                f.InsertStudentGameScore(txtBoxName.Text, Score);
                txtBoxName.Text = "";
                MessageBox.Show("Your Score Is : "+Score.ToString(),"Karam APP");
                }
                Score++;
            timerStartGame.Interval = 1;
        }
    }
}
