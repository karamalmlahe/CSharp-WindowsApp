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
using System.Resources;

namespace App
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void CreateTeacherTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Teacher (Username nvarchar(50) ,Password nvarchar(50));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertTeachers();
            }
            catch
            {
                try
                {
                    SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                    mySqlConnection.Open();
                    mySqlCommand.CommandText = "DROP TABLE Teacher;";
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    CreateTeacherTable();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InsertTeachers()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Teacher(Username ,Password) values('admin','admin');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Teacher(Username ,Password) values('Karam','123');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkUsernameAndPassword(string user, string pass)
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "Select * from Teacher where Username='" + user + "'and Password='" + pass + "' ;";
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read())
                    return true;

                mySqlDataReader.Close();
                mySqlConnection.Close();
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
        private void showStudentGrades()
        {
            try
            {
                int sum = 0,count=0;
                FileStream file = new FileStream("ExamGrade.my", FileMode.Open);
                BinaryReader sr = new BinaryReader(file);
                TableStudentsResult.Rows.Clear();
                Column_2.HeaderText = "Grade";
                while (sr.PeekChar() > 0)
                {
                    string name = sr.ReadString();
                    int grade = sr.ReadInt32();
                    TableStudentsResult.Rows.Add(name, grade + "%");
                    sum += grade;
                    count++;
                }
                lblStudentCountInExam.Text = "Count Of Students : " + count;
                lblAvg.Text = "Average : " + sum / count;
                sr.Close();
                file.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void showStudentIMGExamGrades()
        {
            try
            {
                int sum = 0, count = 0;
                FileStream file = new FileStream("IMGExamGrade.my", FileMode.Open);
                BinaryReader sr = new BinaryReader(file);
                TableStudentsResult.Rows.Clear();
                Column_2.HeaderText = "Grade";
                while (sr.PeekChar() > 0)
                {
                    string name = sr.ReadString();
                    int grade = sr.ReadInt32();
                    TableStudentsResult.Rows.Add(name, grade + "%");
                    sum += grade;
                    count++;
                }
                lblStudentCountInExam.Text = "Count Of Students : " + count;
                lblAvg.Text = "Average : " + (sum / count);
                sr.Close();
                file.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void showStudentScore()
        {
            try
            {
                FileStream file = new FileStream("GameScore.my", FileMode.Open);
                BinaryReader sr = new BinaryReader(file);
                int sum = 0, count = 0;
                TableStudentsResult.Rows.Clear();
                Column_2.HeaderText = "Score";
                while (sr.PeekChar() > 0)
                {
                    string name = sr.ReadString();
                    int score = sr.ReadInt32();
                    TableStudentsResult.Rows.Add(name, score);
                    sum += score;
                    count++;
                }
                sr.Close();
                file.Close();
                lblStudentCountInExam.Text = "Count Of Students : " + count;
                lblAvg.Text = "Average : " + (sum / count);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lblBtnLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Enabled = false;
            if (checkUsernameAndPassword(textBoxUsername.Text, textBoxPassword.Text))
            {
                panelLogin.Visible = false;
                timerShowTables.Start();
            }
            else
            {
                MessageBox.Show("Wrong name or password");
                panelLogin.Enabled = true;
            }
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            CreateTeacherTable();


            IMGExam IMG = new IMGExam();
            IMG.CreateExamIMGTable();
            FormExam Exam = new FormExam();
            Exam.CreateExamTable();

        }

        private void timerShowTables_Tick(object sender, EventArgs e)
        {
            if (panelTeacher.Left > 15)
                panelTeacher.Left -= 3;
            else
                timerShowTables.Stop();
            timerShowTables.Interval = 1;
        }

        private void comboBoxTable_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.Text == "Exam Grades")
                showStudentGrades();
            else if (comboBoxTable.Text == "Game Score")
                showStudentScore();
            else if (comboBoxTable.Text == "IMG Exam Grades")
                showStudentIMGExamGrades();

        }

        private void comboBoxAddQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        string IMGName="";
        Bitmap b;
        private void labelBtnAddIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogIMG = new OpenFileDialog();
            
            if (dialogIMG.ShowDialog() == DialogResult.OK)
            {
                IMGName = dialogIMG.SafeFileName;
                b = new Bitmap(dialogIMG.FileName);
            }
        }
        private void addToComboBoxCorrect()
        {
            comboBoxCorrect.Items.Clear();
            comboBoxCorrect.Items.Add(textBoxAnswer1.Text);
            comboBoxCorrect.Items.Add(textBoxAnswer2.Text);
            comboBoxCorrect.Items.Add(textBoxAnswer3.Text);
            comboBoxCorrect.Items.Add(textBoxAnswer4.Text);
        }

        private void textBoxAnswer1_TextChanged(object sender, EventArgs e)
        {
            addToComboBoxCorrect();
        }

        private void textBoxAnswer2_TextChanged(object sender, EventArgs e)
        {
            addToComboBoxCorrect();
        }

        private void textBoxAnswer3_TextChanged(object sender, EventArgs e)
        {
            addToComboBoxCorrect();
        }

        private void textBoxAnswer4_TextChanged(object sender, EventArgs e)
        {
            addToComboBoxCorrect();
        }

        private void comboBoxCorrect_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxAddQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddQuestion.Text == "Normal Exam")
            {
                panelInputsToAddQuestion.Visible = true;
                labelBtnAddIMG.Enabled = false;
            }
            else if (comboBoxAddQuestion.Text == "IMG Exam")
            {
                panelInputsToAddQuestion.Visible = true;
                labelBtnAddIMG.Enabled = true;
            }
        }
        private void InsertNormalQuestions(string Question,string Answer1, string Answer2, string Answer3, string Answer4, string Corr)
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('"+ Question + "','"+ Answer1 + "','"+ Answer2 + "','"+Answer3+"','"+Answer3+"','"+Corr+"');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertIMGQuestions(string imgPath,string Question, string Answer1, string Answer2, string Answer3, string Answer4, string Corr)
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('"+imgPath+"','"+Question+"','"+Answer1+"','"+Answer2+"','"+Answer3+"','"+Answer4+"','"+Corr+"');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInputs()
        {
            IMGName = "";
            textBoxQuestion.Text = "";
            textBoxAnswer1.Text = "";
            textBoxAnswer2.Text = "";
            textBoxAnswer3.Text = "";
            textBoxAnswer4.Text = "";
            comboBoxCorrect.Text = "";
            comboBoxCorrect.Items.Clear();
        }

        private void lblAddQuestion_Click(object sender, EventArgs e)
        {
            if(IMGName!="" && textBoxQuestion.Text !="" && textBoxAnswer1.Text!="" && textBoxAnswer2.Text!="" && textBoxAnswer3.Text != "" && textBoxAnswer4.Text != "" && comboBoxCorrect.Text != "")
            {
                if (comboBoxAddQuestion.Text == "Normal Exam")
                {
                    InsertNormalQuestions(textBoxQuestion.Text, textBoxAnswer1.Text, textBoxAnswer2.Text, textBoxAnswer3.Text, textBoxAnswer4.Text, comboBoxCorrect.Text);
                    clearInputs();

                }
                else if (comboBoxAddQuestion.Text == "IMG Exam")
                {
                    b.Save("img/" + IMGName);
                    InsertIMGQuestions(IMGName, textBoxQuestion.Text, textBoxAnswer1.Text, textBoxAnswer2.Text, textBoxAnswer3.Text, textBoxAnswer4.Text, comboBoxCorrect.Text);
                    clearInputs();
                }
            }
            else
                MessageBox.Show("Please Add Text In All InputsText");
        }
    }
}
