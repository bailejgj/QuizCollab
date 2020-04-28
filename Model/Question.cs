using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCollab.Model
{
    public class Question
    {
        string _question;
        string _correctAnswer;

        private string Quiz_Question
        {
            get { return _question; }
            set { _question = value; }
        }

        private string CorrectAnswer
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }

        public Question(string q, string cA)
        {
            Quiz_Question = q;
            CorrectAnswer = cA;
        }

        public string GetCorrectAnswer()
        {
            return CorrectAnswer;
        }
        public string GetQuestion()
        {
            return Quiz_Question;
        }
    }
}
