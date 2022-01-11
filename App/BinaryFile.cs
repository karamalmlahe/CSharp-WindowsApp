using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace App
{
    class BinaryFile
    {
        public void InsertStudentGrade(string FileName,string name, int grade)
        {
            try
            {
                FileStream f = new FileStream(FileName, FileMode.Append);
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
        public void InsertStudentGameScore(string name, int Score)
        {
            try
            {
                FileStream f = new FileStream("GameScore.my", FileMode.Append);
                BinaryWriter sr = new BinaryWriter(f);
                sr.Write(name);
                sr.Write(Score);

                sr.Close();
                f.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
