using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.SqlClient;

namespace App
{
    public partial class FormExam : Form
    {
        public FormExam()
        {
            InitializeComponent();
        }

        public void CreateExamTable()
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
            catch(Exception err)
            {
                    //MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertQuestions()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('There are ________ months in a year.','6','9','12','8','12');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('How many hours are there in a day?','48 hours','24 hours','72 hours','12 hours','24 hours');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('How many fingers are there in a human body’s single hand?','10 fingers','12 fingers','15 fingers','5 fingers','5 fingers');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('How many letters are there in the English?','30 letters','26 letters','18 letters','10 letters','26 letters');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is the color of a sun?','Yellow','White','Pink','Blue','Yellow');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 2+7?','1','9','4','5','9');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Which number comes after 6?','4','5','7','8','7');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('How many colors are there in a rainbow?','10','12','7','8','7');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Which day comes after Friday?','Thursday','Monday','Saturday','Sunday','Saturday');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 2+2?','10','12','4','8','4');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Finish the sequence: 9, 18, 27, __','32','28','36','0','36');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Which number comes before 9?','8','10','11','7','8');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 5-3?','3','1','0','2','2');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Finish the sequence: 4, __, 12, 16','6','18','8','2','8');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormExam_Load(object sender, EventArgs e)
        {
            CreateExamTable();
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
        private DateTime StartingExam;
        private int WrongAnswers;
        private int TimeToEnd = 10;
 
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
            panelQuestion.Location = new Point(133, 591);


            //Result Panel
            lblName2.Text = "Name : " + txtBoxName.Text;
            lblDateDay.Text = "Data : " + Date;
            lblTimeStart.Text = "Starting In : " + StartingExam.ToString("hh:mm:ss tt"); ;
            lblEndTime.Text = "Ending In : " + DateTime.Now.ToString("hh:mm:ss tt");//EndExam

            InsertStudentGrade(txtBoxName.Text, GetGrade());

            panelResultExam.Visible = true;

            timerExamResult.Start();
        }
        private void lblStart_Click(object sender, EventArgs e)
        {
            TableWrongAnswers.Rows.Clear();
            _Questions = A.GetQuestions();
            if (txtBoxName.Text != "")
            {
                if (_Questions.Count >= 1)
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
        private void InsertStudentGrade(string name, int grade)
        {
            try
            {
                FileStream f = new FileStream("ExamGrade.my", FileMode.Append);
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
            lblGrade.Text = "Grade : " + sum+"%";
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

        private void timerPanelQuestion_Tick(object sender, EventArgs e)
        {
            if (panelQuestion.Top >147)
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
