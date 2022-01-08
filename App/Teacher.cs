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
                while (sr.PeekChar() > 0)
                {
                    string name = sr.ReadString();
                    int grade = sr.ReadInt32();
                    TableGradeStudents.Rows.Add(name, grade + "%");
                    sum += grade;
                    count++;
                }
                lblStudentCountInExam.Text = "Count Of Students : " + count;
                lblAvgInExam.Text = "Average : " + sum / count;
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
                while (sr.PeekChar() > 0)
                {
                    string name = sr.ReadString();
                    int score = sr.ReadInt32();
                    TableScore.Rows.Add(name, score);
                    sum += score;
                    count++;
                }
                lblStudentCountInGame.Text = "Count Of Students : " + count;
                lblAvgInGame.Text = "Average : " + sum / count;
                sr.Close();
                file.Close();
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
                showStudentGrades();
                showStudentScore();
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
        }

        private void timerShowTables_Tick(object sender, EventArgs e)
        {
            if (panelGradeAndScore.Left > 44)
                panelGradeAndScore.Left -= 3;
            else
                timerShowTables.Stop();
            timerShowTables.Interval = 1;
        }
    }
}
