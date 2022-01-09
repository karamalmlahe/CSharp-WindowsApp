using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Question
    {
        private string _IMGPath;
        private string _Question;
        private string _Answer1;
        private string _Answer2;
        private string _Answer3;
        private string _Answer4;
        private string _Correct;

        public Question(string Question, string Answer1, string Answer2, string Answer3, string Answer4, string Correct)
        {
            this._Question = Question;
            this._Answer1 = Answer1;
            this._Answer2 = Answer2;
            this._Answer3 = Answer3;
            this._Answer4 = Answer4;
            this._Correct = Correct;
        }

        public Question(string img ,string Question, string Answer1, string Answer2, string Answer3, string Answer4, string Correct)
        {
            this._IMGPath = img;
            this._Question = Question;
            this._Answer1 = Answer1;
            this._Answer2 = Answer2;
            this._Answer3 = Answer3;
            this._Answer4 = Answer4;
            this._Correct = Correct;
        }
        public string GetIMGPath()
        {
            return this._IMGPath;
        }
        public string GetQuestion()
        {
            return this._Question;
        }
        public string GetAnswer1()
        {
            return this._Answer1;
        }
        public string GetAnswer2()
        {
            return this._Answer2;
        }
        public string GetAnswer3()
        {
            return this._Answer3;
        }
        public string GetAnswer4()
        {
            return this._Answer4;
        }
        public string GetCorrect()
        {
            return this._Correct;
        }
        public override string ToString()
        {
            return _Question + " " + _Answer1 + " " + _Answer2 + " " + _Answer3 + " " + _Answer4 + " " + _Correct;
        }
    }
}
