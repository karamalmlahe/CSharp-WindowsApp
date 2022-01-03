using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using System.Drawing.Drawing2D;

namespace App
{
    public partial class Form1 : Form
    {
        private void CreateTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Questions (Question nvarchar(70) ,Answer1 nvarchar(20) ,Answer2 nvarchar(20) ,Answer3 nvarchar(20) ,Answer4 nvarchar(20) , Correct int );";
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
                    CreateTable();
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
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+3=','1','2','4','5',4);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+7=','1','9','4','5',2);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('France ?','London','Beer Sheva','Paris','Dimona',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Italy ?','London','Beer Sheva','Paris','Roma',4);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Karam ?','turi','Beer Sheva','a','2',1);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('2+2=','10','12','4','8',3);";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('turi ?','aaa','Beer Sheva','bb','KARAM',4);";
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
            CreateTable();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            lblBtnExam.ForeColor = Color.White;
            lblBtnGame.ForeColor = Color.Black;
            timer1.Start();
            panelExam.Visible = true;
            groupBox1.Visible = false;
        }

        private void lblGame_Click(object sender, EventArgs e)
        {
            lblBtnGame.ForeColor = Color.White;
            lblBtnExam.ForeColor = Color.Black;
            timer1.Start();
            groupBox1.Visible = true;
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
                lblClose.Left+= 5;
            }
            if (lblMenu.Width > 233)
            {
                lblMenu.Width -= 1;
                lblLine.Width -= 1;
            }
            if (lblBtnExam.Left != 0)
            {
                lblBtnExam.Left -= 1;
                lblBtnGame.Left -=1;
            }


            timer1.Interval=1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        ListQuestions A = new ListQuestions();
        private List<Question> _Questions;
        private Question[] RandomQuest = new Question[10];
        private int[] ClinetChoice = new int[10];
        private Random rnd = new Random();
        private int QuestNum;
        private int counter;
        private void lblStart_Click(object sender, EventArgs e)
        {
            _Questions = A.GetQuestions();
            if (txtBoxName.Text!= "")
            {
                if (_Questions.Count >= 1)
                {
                    counter = 0;
                    QuestNum = 0;
                    QuestNum++;
                    for (int i = 0; i < RandomQuest.Length && i< A.GetQuestions().Count; i++)
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
                ClinetChoice[counter] = 1;
                radioBtnAnswer1.Checked = false;
            }
            else if (radioBtnAnswer2.Checked == true)
            {
                ClinetChoice[counter] = 2;
                radioBtnAnswer2.Checked = false;
            }
            else if (radioBtnAnswer3.Checked == true)
            {
                ClinetChoice[counter] = 3;
                radioBtnAnswer3.Checked = false;
            }
            else if (radioBtnAnswer4.Checked == true)
            {
                ClinetChoice[counter] = 4;
                radioBtnAnswer4.Checked = false;
            }
        }

        private void CheckClinetChoice()
        {
            if (ClinetChoice[counter] == 1)
            {
                radioBtnAnswer1.Checked = true;
            }
            else if (ClinetChoice[counter] == 2)
            {
                radioBtnAnswer2.Checked = true;
            }
            else if (ClinetChoice[counter] == 3)
            {
                radioBtnAnswer3.Checked = true;
            }
            else if (ClinetChoice[counter] == 4)
            {
                radioBtnAnswer4.Checked = true;
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            if (A.GetQuestions().Count >= 1)
            {
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
                    if (counter== RandomQuest.Length - 1)
                        lblNext.Text = "Done";
                }
                else
                {
                    panelName.Enabled = true;
                    panelQuestion.Visible = false;
                    MessageBox.Show(GetGrade().ToString());
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
            if (counter >0)
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
            for(int i = 0; i < ClinetChoice.Length; i++)
            {
                if (ClinetChoice[i] == RandomQuest[i].GetCorrect())
                    sum += 100/ClinetChoice.Length;
            }
            return sum;
        }
    }
}
