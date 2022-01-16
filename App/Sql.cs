using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    class Sql
    {

        //IMG Exam
        public void CreateExamIMGTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table IMGQuestions (Image nvarchar(100),Question nvarchar(100) ,Answer1 nvarchar(50) ,Answer2 nvarchar(50) ,Answer3 nvarchar(50) ,Answer4 nvarchar(50) ,Correct nvarchar(50));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertIMGQuestions();
            }
            catch
            {
                    //MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertIMGQuestions()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('dog.jpg','How many dogs can you see in this picture?','6 dogs','9 dogs','5 dogs','1 dog','5 dogs');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('MonaLisa.jpg','What is the name of this famous painting?','Guernica','The Girl With A Pearl Earring','Mona Lisa','The Scream','Mona Lisa');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Cats.png','How many cats can you see in this picture?','5 cats','10 cats','12 cats','7 cats','10 cats');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('ThomasEdison.jpg','Who was the inventor of the light bulb?','Thomas Edison','Albert Einstein','Johannes Gutenberg','Grace Hopper','Thomas Edison');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('messi.jpg','Identify the football player.','Cristiano Ronaldo','Mohamed Salah','Karim Benzema','Messi','Messi');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Elephant.jpg','Identify the animal','Dog','Elephant','Chicken','Cow','Elephant');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Eiffel.jpg','In which country is the Eiffel Tower located?','Italy','Indonesia','United States','France','France');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('BMW.jpg','What is the name of this automotive brand?','Skoda','Citroen','BMW','Mersedes','BMW');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Burj Khalifa.jpg','How high is the Burj Khalifa in Dubai?','Around 830 metres','Around 960 metres','Around 750 metres','Around 1070 metres','Around 830 metres');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('KoreanFont.png','What is the name of this language?','Japanese','Chinese','Arabic','Korean','Korean');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('BTC.jpg','What is the name of this cryptocurrency?','Ethereum','Bitcoin','XRP','Dogcoin','Bitcoin');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('USA.jpg','What country flag is this?','Germany','Austria','United States','Russia','United States');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('tesla.jpg','What is the name of this automotive brand?','BMW','Tesla','Nissan','Hyundai','Tesla');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Ronaldo.jpg','Identify the football player.','Ronaldo','Messi','Neymar','Ramos','Ronaldo');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('tiger.jpg','Identify the animal','Donkey','Tiger','Mouse','Lion','Tiger');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('sun.jpg','What is the color of a sun?','Pink','Blue','Yellow','White','Yellow');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('English Letters.jpg','How many letters are there in the English?','20 letters','10 letters','18 letters','26 letters','26 letters');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('rainbow.png','How many colors are there in a rainbow?','10','12','7','8','7');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('numbers.png','Which number comes after 2?','4','1','3','7','3');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Apple.png','What is the name of this fruit?','Mango','Banana','Orange','Apple','Apple');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Normal Exam
        public void CreateExamTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Questions (Question nvarchar(150) ,Answer1 nvarchar(70) ,Answer2 nvarchar(70) ,Answer3 nvarchar(70) ,Answer4 nvarchar(70) ,Correct nvarchar(70));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertQuestions();
            }
            catch
            {
                //MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertQuestions()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('There are ________ days in a year.','316','365','360','325','365');";
                mySqlCommand.ExecuteNonQuery();
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
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 2-2?','40','1','0','2','0');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 7-0?','-7','70','0','7','7');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is 0+10?','100','0','10','11','10');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('What is the 15th letter of the English alphabet?','F','I','O','M','O');";
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('Which number comes after 6?','4','1','5','7','7');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        //teacher
        public void CreateTeacherTable()
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "create table Teacher (Username nvarchar(50) ,Password nvarchar(50));";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                InsertTeachers();
            }
            catch
            {
            }
        }
        public void InsertTeachers()
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
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

        public bool checkUsernameAndPassword(string user, string pass)
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
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
        public void InsertNormalQuestions(string Question, string Answer1, string Answer2, string Answer3, string Answer4, string Corr)
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into Questions(Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('" + Question + "','" + Answer1 + "','" + Answer2 + "','" + Answer3 + "','" + Answer4 + "','" + Corr + "');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertIMGQuestions(string imgPath, string Question, string Answer1, string Answer2, string Answer3, string Answer4, string Corr)
        {
            try
            {

                SqlConnection mySqlConnection = new SqlConnection("server=(local)\\SQLEXPRESS;database=KaramAPP;Integrated Security=SSPI;");
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "insert into IMGQuestions(Image ,Question ,Answer1 ,Answer2 ,Answer3,Answer4 ,Correct) values('" + imgPath + "','" + Question + "','" + Answer1 + "','" + Answer2 + "','" + Answer3 + "','" + Answer4 + "','" + Corr + "');";
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Karam App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
