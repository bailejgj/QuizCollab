using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCollab.Model
{
    public class Options
    {
        string _answerA;
        string _answerB;
        string _answerC;
        string _answerD;

        private string Answer_A
        {
            get { return _answerA; }
            set { _answerA = value; }
        }
        private string Answer_B
        {
            get { return _answerB; }
            set { _answerB = value; }
        }
        private string Answer_C
        {
            get { return _answerC; }
            set { _answerC = value; }
        }
        private string Answer_D
        {
            get { return _answerD; }
            set { _answerD = value; }
        }

        public Options(string a1, string a2, string a3, string a4)
        {
            Answer_A = a1;
            Answer_B = a2;
            Answer_C = a3;
            Answer_D = a4;
        }

        public List<string> GetListOfOptions()
        {
            List<string> optionList = new List<string>();

            optionList.Add(Answer_A);
            optionList.Add(Answer_B);
            optionList.Add(Answer_C);
            optionList.Add(Answer_D);

            return optionList;
        }

    }
}
