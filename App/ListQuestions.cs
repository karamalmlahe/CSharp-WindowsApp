using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    class ListQuestions
    {
        private List<Question> _Questions;

        public ListQuestions()
        {
        }

        public List<Question> GetQuestions()
        {
            try
            {
                _Questions = new List<Question>();
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=dugma;Integrated Security=SSPI;");//kesher to database
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "Select * from questions;";
                mySqlConnection.Open(); //open connection
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();



                while (mySqlDataReader.Read())
                {

                    _Questions.Add(new Question(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString(), mySqlDataReader[2].ToString(), mySqlDataReader[3].ToString(), mySqlDataReader[4].ToString(), int.Parse(mySqlDataReader[5].ToString())));
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return _Questions;
        }
        public string GetQuestion(int n)
        {
            return _Questions[n].GetQuestion();
        }
        public string GetAnswer1(int n)
        {
            return _Questions[n].GetAnswer1();
        }
        public string GetAnswer2(int n)
        {
            return _Questions[n].GetAnswer2();
        }
        public string GetAnswer3(int n)
        {
            return _Questions[n].GetAnswer3();
        }
        public string GetAnswer4(int n)
        {
            return _Questions[n].GetAnswer4();
        }
        public int GetCorrect(int n)
        {
            return _Questions[n].GetCorrect();
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _Questions.Count; i++)
                str += _Questions[i].ToString() + "\n";
            MessageBox.Show(str);
            return str;
        }
    }

}
