﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using System.Drawing.Drawing2D;

namespace App
{
    public partial class Form1 : Form
    {
        private void CreateExamTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Questions (Question nvarchar(70) ,Answer1 nvarchar(20) ,Answer2 nvarchar(20) ,Answer3 nvarchar(20) ,Answer4 nvarchar(20) ,Correct nvarchar(20));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertQuestions();
            }
            catch
            {
                try
                {
                    SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                    mySqlConnection.Open();
                    mySqlCommand.CommandText = "DROP TABLE Questions;";
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    CreateExamTable();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InsertQuestions()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+3=','1','2','4','5','5');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+7=','1','9','4','5','9');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('France ?','London','Beer Sheva','Paris','Dimona','Paris');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Italy ?','London','Beer Sheva','Paris','Roma','Roma');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Karam ?','turi','Beer Sheva','a','2','turi');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('turi ?','aaa','Beer Sheva','bb','KARAM','KARAM');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        bool dragging = false;
        Point startPoint = new Point(0, 0);

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateExamTable();
            CreateGradesTable();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            lblBtnExam.Enabled = false;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = true;


            dataGridView1.Rows.Clear();
            timer1.Start();

            timer2.Stop();
            timer3.Stop();
            panelName.Location = new Point(304, 526);
            panelQuestion.Location = new Point(304, 579);
            panelResultExam.Location = new Point(948, 34);

            panelName.Visible = true;
            panelName.Enabled = true;

            //btn color on click
            lblBtnExam.BackColor = this.BackColor;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void lblGame_Click(object sender, EventArgs e)
        {
            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = false;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = true;

            timer1.Start();
            timer6.Start();
            timer2.Stop();
            timer3.Stop();
            panelName.Location = new Point(304, 526);
            panelQuestion.Location = new Point(304, 579);
            panelResultExam.Location = new Point(948, 34);
            //unShow panels
            panelName.Visible = false;
            panelQuestion.Visible = false;

            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = this.BackColor;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width < 844)
            {
                this.Width += 5;
                lblTitle.Width += 5;
                lblClose.Left += 5;
            }
            if (lblMenu.Width > 233)
            {
                lblMenu.Width -= 1;
                lblLine.Width -= 1;
            }
            if (lblBtnExam.Left != 0)
            {
                lblBtnExam.Left -= 1;
                lblBtnGame.Left -= 1;
                lblBtnIMGExam.Left -= 1;
                lblBtnTeacher.Left -= 1;
            }
            if (panelName.Top > 80)
                panelName.Top -= 5;


            timer1.Interval = 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        ListQuestions A = new ListQuestions();
        private List<Question> _Questions;
        private Question[] RandomQuest;
        private int[] ClinetChoiceNumber;
        private string[] ClinetChoiceAnswer;
        private Random rnd = new Random();
        private int QuestNum;
        private int counter;
        private string Date;
        private string StartingExam;
        private int WorngAnswers;
        private void lblStart_Click(object sender, EventArgs e)
        {
            _Questions = A.GetQuestions();
            if (txtBoxName.Text != "")
            {
                if (_Questions.Count >= 1)
                {
                    RandomQuest = new Question[10];
                    ClinetChoiceNumber = new int[10];
                    ClinetChoiceAnswer = new string[10];
                    //Enabled Btns Menu
                    lblBtnGame.Enabled = false;
                    lblBtnIMGExam.Enabled = false;
                    lblBtnTeacher.Enabled = false;

                    timer2.Start();
                    panelQuestion.Enabled = true;

                    Date = DateTime.Now.ToString("dd/MM/yyyy");
                    StartingExam = DateTime.Now.ToString("hh:mm:ss tt");

                    WorngAnswers = 0;
                    counter = 0;
                    QuestNum = 0;
                    QuestNum++;
                    for (int i = 0; i < RandomQuest.Length && i < A.GetQuestions().Count; i++)
                    {
                        int index = rnd.Next(0, _Questions.Count);
                        RandomQuest[i] = new Question(_Questions[index].GetQuestion(), _Questions[index].GetAnswer1(), _Questions[index].GetAnswer2(), _Questions[index].GetAnswer3(), _Questions[index].GetAnswer4(), _Questions[index].GetCorrect());
                        _Questions.RemoveAt(index);
                    }
                    lblQuestion.Text = RandomQuest[counter].GetQuestion();
                    radioBtnAnswer1.Text = RandomQuest[counter].GetAnswer1();
                    radioBtnAnswer2.Text = RandomQuest[counter].GetAnswer2();
                    radioBtnAnswer3.Text = RandomQuest[counter].GetAnswer3();
                    radioBtnAnswer4.Text = RandomQuest[counter].GetAnswer4();
                    lblQNumber.Text = "Question " + QuestNum;
                    panelName.Enabled = false;
                    panelQuestion.Visible = true;

                }
                else
                    MessageBox.Show("No Questions", "Karam App");

            }
            else
                MessageBox.Show("Please Enter A Name", "Karam App");
            if (counter == 0)
                lblBack.Enabled = false;
        }
        private void AddClinetChoice()
        {
            if (radioBtnAnswer1.Checked == true)
            {
                ClinetChoiceNumber[counter] = 1;
                ClinetChoiceAnswer[counter] = radioBtnAnswer1.Text;
                radioBtnAnswer1.Checked = false;

            }
            else if (radioBtnAnswer2.Checked == true)
            {
                ClinetChoiceNumber[counter] = 2;
                ClinetChoiceAnswer[counter] = radioBtnAnswer2.Text;
                radioBtnAnswer2.Checked = false;
            }
            else if (radioBtnAnswer3.Checked == true)
            {
                ClinetChoiceNumber[counter] = 3;
                ClinetChoiceAnswer[counter] = radioBtnAnswer3.Text;
                radioBtnAnswer3.Checked = false;
            }
            else if (radioBtnAnswer4.Checked == true)
            {
                ClinetChoiceNumber[counter] = 4;
                ClinetChoiceAnswer[counter] = radioBtnAnswer4.Text;
                radioBtnAnswer4.Checked = false;
            }
            else
                ClinetChoiceAnswer[counter] = "N/A";
        }
        private void CheckClinetChoice()
        {
            if (ClinetChoiceNumber[counter] == 1)
            {
                radioBtnAnswer1.Checked = true;
            }
            else if (ClinetChoiceNumber[counter] == 2)
            {
                radioBtnAnswer2.Checked = true;
            }
            else if (ClinetChoiceNumber[counter] == 3)
            {
                radioBtnAnswer3.Checked = true;
            }
            else if (ClinetChoiceNumber[counter] == 4)
            {
                radioBtnAnswer4.Checked = true;
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            if (A.GetQuestions().Count >= 1)
            {
                lblNext.Text = "Next";
                lblBack.Enabled = true;
                AddClinetChoice();
                counter++;
                if (counter < RandomQuest.Length)
                {
                    QuestNum++;
                    lblQuestion.Text = RandomQuest[counter].GetQuestion();
                    radioBtnAnswer1.Text = RandomQuest[counter].GetAnswer1();
                    radioBtnAnswer2.Text = RandomQuest[counter].GetAnswer2();
                    radioBtnAnswer3.Text = RandomQuest[counter].GetAnswer3();
                    radioBtnAnswer4.Text = RandomQuest[counter].GetAnswer4();
                    lblQNumber.Text = "Question " + QuestNum;
                    CheckClinetChoice();
                    if (counter == RandomQuest.Length - 1)
                        lblNext.Text = "Done";
                }
                else
                {
                    //Enabled to true Btns Menu When The Exam is Done
                    lblBtnGame.Enabled = true;
                    lblBtnIMGExam.Enabled = true;
                    lblBtnTeacher.Enabled = true;

                    timer1.Stop();
                    timer2.Stop();
                    panelName.Location = new Point(304, 526);
                    panelQuestion.Location = new Point(304, 579);

                    dataGridView1.Visible = true;

                    //Result Panel
                    lblName2.Text = "Name : " + txtBoxName.Text;
                    lblDateDay.Text = "Data : " + Date;
                    lblTimeStart.Text = "Starting In : " + StartingExam;
                    lblEndTime.Text = "Ending In : " + DateTime.Now.ToString("hh:mm:ss tt");//EndExam

                    InsertStudentGrade(txtBoxName.Text, GetGrade());

                    timer3.Start();

                    //MessageBox.Show(GetGrade().ToString());
                }
            }
            else
            {
                panelName.Enabled = true;
                panelQuestion.Visible = false;
                MessageBox.Show("No Questions", "Karam App");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            AddClinetChoice();
            if (counter > 0)
            {
                counter--;
                QuestNum--;
                CheckClinetChoice();
                lblQuestion.Text = RandomQuest[counter].GetQuestion();
                radioBtnAnswer1.Text = RandomQuest[counter].GetAnswer1();
                radioBtnAnswer2.Text = RandomQuest[counter].GetAnswer2();
                radioBtnAnswer3.Text = RandomQuest[counter].GetAnswer3();
                radioBtnAnswer4.Text = RandomQuest[counter].GetAnswer4();
                lblQNumber.Text = "Question " + QuestNum;
                if (counter < 1)
                    lblBack.Enabled = false;
            }
            else
            {
                lblBack.Enabled = true;
            }
        }
        private int GetGrade()
        {
            int sum = 0;
            for (int i = 0; i < ClinetChoiceAnswer.Length; i++)
            {
                if (ClinetChoiceAnswer[i] == RandomQuest[i].GetCorrect())
                    sum += 100 / ClinetChoiceNumber.Length;
                else
                {
                    dataGridView1.Rows.Add(RandomQuest[i].GetQuestion(), ClinetChoiceAnswer[i], RandomQuest[i].GetCorrect());
                    WorngAnswers++;
                }
            }
            lblWrongAnswers.Text = "Wrong Answers : " + WorngAnswers;
            if (WorngAnswers > 3)
            {
                lblResultExamColor.Text = "Failed";
                lblResultExamColor.ForeColor = Color.Red;
            }
            else
            {
                lblResultExamColor.Text = "Passed";
                lblResultExamColor.ForeColor = Color.Green;
            }
            return sum;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panelQuestion.Top > 130)
                panelQuestion.Top -= 3;
            timer2.Interval = 1;
        }

        private void lblBtnIMGExam_Click(object sender, EventArgs e)
        {
            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = false;
            lblBtnTeacher.Enabled = true;

            timer1.Start();

            //unShow panels
            panelName.Visible = false;
            panelQuestion.Visible = false;

            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = this.BackColor;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void lblBtnTeacher_Click(object sender, EventArgs e)
        {

            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = false;

            timer1.Start();

            //unShow panels
            panelName.Visible = false;
            panelQuestion.Visible = false;

            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = this.BackColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panelResultExam.Left > 250)
                panelResultExam.Left -= 5;
            timer3.Interval = 1;
        }


        //save name and grades in sql
        private void CreateGradesTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Grades (Name nvarchar(30) ,Grade int);";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertQuestions();
            }
            catch
            {

                //MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //insert Func
        private void InsertStudentGrade(string name, int grade)
        {
            //try
            //{

            //    SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
            //    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            //    mySqlConnection.Open();
            //    mySqlCommand.CommandText = "insert into Grades(Name ,Grade) values('"+name+"',"+grade+");";
            //    mySqlCommand.ExecuteNonQuery();
            //    mySqlConnection.Close();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                FileStream f = new FileStream("ExamGrade.my", FileMode.Append);
                BinaryWriter sr = new BinaryWriter(f);
                sr.Write(name);
                sr.Write(grade);

                sr.Close();
                f.Close();
                MessageBox.Show("Added...");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lblTryAgainExam_Click(object sender, EventArgs e)
        {
            lblTest_Click(sender, e);
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
        private bool GoUpp = false;
        private bool GoDown = false;
        private int Score;
        private void lblStartGame_Click(object sender, EventArgs e)
        {
            Score = 0;
            SetLocationAndHeightToColumnsInGame();
            timer5.Start();
        }


        private void lblUP_MouseDown(object sender, MouseEventArgs e)
        {
            GoUpp = true;
            timer4.Start();
        }
        private void lblUP_MouseUp(object sender, MouseEventArgs e)
        {
            GoUpp = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (GoUpp == true && lblBoxGame.Top != 0)
                lblBoxGame.Top -= 1;
            else if (GoDown == true && lblBoxGame.Top != (panelGameZone.Size.Height - lblBoxGame.Size.Height))
                lblBoxGame.Top += 1;
            timer4.Interval = 1;
        }

        private void lblDown_MouseDown(object sender, MouseEventArgs e)
        {
            GoDown = true;
            timer4.Start();
        }

        private void lblDown_MouseUp(object sender, MouseEventArgs e)
        {
            GoDown = false;
        }
        private void timer5_Tick(object sender, EventArgs e)
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
            //if(lblWallDown1.Left+lblWallDown1.Size.Width!=0 && lblWallUp1.Left + lblWallUp1.Size.Width != 0)
            //{
            //    lblWallDown1.Left -= 1;
            //    lblWallUp1.Left -= 1;
            //    if (lblBoxGame.Bounds.IntersectsWith(lblWallUp1.Bounds)|| lblBoxGame.Bounds.IntersectsWith(lblWallDown1.Bounds))
            //    {
            //        timer5.Stop();
            //    }
            //}
            //else
            //{
            //    SetLocationAndHeightToColumnsInGame();
            //}

            if (lblBoxGame.Bounds.IntersectsWith(lblWallUp1.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallDown1.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallUp2.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallDown2.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallUp3.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallDown3.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallUp4.Bounds)
                || lblBoxGame.Bounds.IntersectsWith(lblWallDown4.Bounds))
            {
                timer5.Stop();
                MessageBox.Show(Score.ToString());
            }
            Score++;
                timer5.Interval = 1;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (panelGame.Left > 250)
                panelGame.Left -= 5;
            timer6.Interval = 1;
        }
    }
}
