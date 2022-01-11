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

namespace App
{
    public partial class Teacher : Form
    {
        private Sql sql = new Sql();
        string IMGName = "";
        Bitmap b;
        public Teacher()
        {
            InitializeComponent();
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
            if (sql.checkUsernameAndPassword(textBoxUsername.Text, textBoxPassword.Text))
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
           sql.CreateTeacherTable();

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
        private void labelBtnAddIMG_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IMGName = openFileDialog1.SafeFileName;
                b = new Bitmap(openFileDialog1.FileName);
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
            comboBoxCorrect.Text = "";
            addToComboBoxCorrect();
        }

        private void textBoxAnswer2_TextChanged(object sender, EventArgs e)
        {
            comboBoxCorrect.Text = "";
            addToComboBoxCorrect();
        }

        private void textBoxAnswer3_TextChanged(object sender, EventArgs e)
        {
            comboBoxCorrect.Text = "";
            addToComboBoxCorrect();
        }

        private void textBoxAnswer4_TextChanged(object sender, EventArgs e)
        {
            comboBoxCorrect.Text = "";
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
            if(textBoxQuestion.Text !="" && textBoxAnswer1.Text!="" && textBoxAnswer2.Text!="" && textBoxAnswer3.Text != "" && textBoxAnswer4.Text != "" && comboBoxCorrect.Text != "")
            {
                if (comboBoxAddQuestion.Text == "Normal Exam")
                {
                    sql.InsertNormalQuestions(textBoxQuestion.Text, textBoxAnswer1.Text, textBoxAnswer2.Text, textBoxAnswer3.Text, textBoxAnswer4.Text, comboBoxCorrect.Text);
                    clearInputs();

                }
                else if (IMGName != "" && comboBoxAddQuestion.Text == "IMG Exam")
                {
                    b.Save("img/" + IMGName);
                    sql.InsertIMGQuestions(IMGName, textBoxQuestion.Text, textBoxAnswer1.Text, textBoxAnswer2.Text, textBoxAnswer3.Text, textBoxAnswer4.Text, comboBoxCorrect.Text);
                    clearInputs();
                }
            }
            else
                MessageBox.Show("Please Add Text In All InputsText");
        }
    }
}
