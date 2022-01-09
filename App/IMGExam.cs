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
using System.IO;

namespace App
{
    public partial class IMGExam : Form
    {
        public IMGExam()
        {
            InitializeComponent();
        }

        private void CreateExamIMGTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table IMGQuestions (Image nvarchar(100),Question nvarchar(70) ,Answer1 nvarchar(20) ,Answer2 nvarchar(20) ,Answer3 nvarchar(20) ,Answer4 nvarchar(20) ,Correct nvarchar(20));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertIMGQuestions();
            }
            catch
            {
                try
                {
                    SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                    mySqlConnection.Open();
                    mySqlCommand.CommandText = "DROP TABLE IMGQuestions ;";
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    CreateExamIMGTable();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InsertIMGQuestions()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog','There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IMGExam_Load(object sender, EventArgs e)
        {
            CreateExamIMGTable();
        }

        ListQuestions A = new ListQuestions();
        private List<Question> _IMGQuestions;
        private Question[] RandomQuest;
        private int[] ClinetChoiceNumber;
        private string[] ClinetChoiceAnswer;
        private Random rnd = new Random();
        private int QuestNum;
        private int counter;
        private string Date;
        private DateTime StartingExam;
        private int WrongAnswers;
        private int TimeToEnd = 10;

        private void lblStart_Click(object sender, EventArgs e)
        {
            TableWrongAnswers.Rows.Clear();
            _IMGQuestions = A.GetIMGQuestions();
            if (txtBoxName.Text != "")
            {
                if (_IMGQuestions.Count >= 1)
                {
                    RandomQuest = new Question[10];
                    ClinetChoiceNumber = new int[10];
                    ClinetChoiceAnswer = new string[10] { "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A" };
                    //Enabled Btns Menu
                    //lblBtnGame.Enabled = false;
                    //lblBtnIMGExam.Enabled = false;
                    //lblBtnTeacher.Enabled = false;


                    panelQuestion.Visible = true;
                    timerPanelQuestion.Start();

                    Date = DateTime.Now.ToString("dd/MM/yyyy");
                    StartingExam = DateTime.Now;

                    timerTimeToEnd.Start();
                    WrongAnswers = 0;
                    counter = 0;
                    QuestNum = 0;
                    QuestNum++;
                    for (int i = 0; i < RandomQuest.Length && i < A.GetIMGQuestions().Count; i++)
                    {
                        int index = rnd.Next(0, _IMGQuestions.Count);
                        RandomQuest[i] = new Question(_IMGQuestions[index].GetIMGPath(),_IMGQuestions[index].GetQuestion(), _IMGQuestions[index].GetAnswer1(), _IMGQuestions[index].GetAnswer2(), _IMGQuestions[index].GetAnswer3(), _IMGQuestions[index].GetAnswer4(), _IMGQuestions[index].GetCorrect());
                        _IMGQuestions.RemoveAt(index);
                    }
                    pictureBox1.Image = ((Image)Properties.Resources.ResourceManager.GetObject(RandomQuest[counter].GetIMGPath()));
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

        private void timerTimeToEnd_Tick(object sender, EventArgs e)
        {
            string s = (StartingExam.AddMinutes(TimeToEnd) - DateTime.Now).ToString().Substring(3, 5);
            lblEndT.Text = "End in : " + s;
            if (s == "00:00")
                ExamIsEnd();
            timerTimeToEnd.Interval = 1;
        }
        private void ExamIsEnd()
        {
            //Enabled to true Btns Menu When The Exam is Done
            //lblBtnGame.Enabled = true;
            //lblBtnIMGExam.Enabled = true;
            //lblBtnTeacher.Enabled = true;

            timerTimeToEnd.Stop();

            panelName.Visible = false;

            panelQuestion.Visible = false;
            panelQuestion.Location = new Point(133, 547);


            //Result Panel
            lblName2.Text = "Name : " + txtBoxName.Text;
            lblDateDay.Text = "Data : " + Date;
            lblTimeStart.Text = "Starting In : " + StartingExam.ToString("hh:mm:ss tt"); ;
            lblEndTime.Text = "Ending In : " + DateTime.Now.ToString("hh:mm:ss tt");//EndExam

            InsertStudentGrade(txtBoxName.Text, GetGrade());

            panelResultExam.Visible = true;

            timerExamResult.Start();
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
                    ExamIsEnd();
            }
            else
            {
                panelName.Enabled = true;
                MessageBox.Show("No Questions", "Karam App");
            }
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
        }
        private void CheckClinetChoice()
        {
            if (ClinetChoiceNumber[counter] == 1)
                radioBtnAnswer1.Checked = true;
            else if (ClinetChoiceNumber[counter] == 2)
                radioBtnAnswer2.Checked = true;
            else if (ClinetChoiceNumber[counter] == 3)
                radioBtnAnswer3.Checked = true;
            else if (ClinetChoiceNumber[counter] == 4)
                radioBtnAnswer4.Checked = true;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            AddClinetChoice();
            if (counter > 0)
            {
                lblNext.Text = "Next";
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
                lblBack.Enabled = false;
        }

        private void timerPanelQuestion_Tick(object sender, EventArgs e)
        {
            if (panelQuestion.Top > 90)
                panelQuestion.Top -= 3;
            else
                timerPanelQuestion.Stop();
            timerPanelQuestion.Interval = 1;
        }

        private void timerExamResult_Tick(object sender, EventArgs e)
        {
            if (panelResultExam.Left > 15)
                panelResultExam.Left -= 3;
            else
                timerExamResult.Stop();
            timerExamResult.Interval = 1;
        }

        private void InsertStudentGrade(string name, int grade)
        {
            try
            {
                FileStream f = new FileStream("IMGExamGrade.my", FileMode.Append);
                BinaryWriter sr = new BinaryWriter(f);
                sr.Write(name);
                sr.Write(grade);

                sr.Close();
                f.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                    TableWrongAnswers.Rows.Add(RandomQuest[i].GetQuestion(), ClinetChoiceAnswer[i], RandomQuest[i].GetCorrect());
                    WrongAnswers++;
                }
            }
            lblWrongAnswers.Text = "Wrong Answers : " + WrongAnswers;
            lblGrade.Text = "Grade : " + sum + "%";
            if (WrongAnswers
                > 3)
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

        private void lblTryAgainExam_Click(object sender, EventArgs e)
        {
            panelResultExam.Visible = false;
            panelResultExam.Location = new Point(795, 30);

            txtBoxName.Text = "";
            panelName.Visible = true;
            panelName.Enabled = true;
        }
    }

}
