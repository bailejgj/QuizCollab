using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCollab.Model
{
    public class Quiz
    {
        Question _question;
        Options _options;
        //List<Options> _options;

        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }
        public Options Options
        {
            get { return _options; }
            set { _options = value; }
        }

        public Quiz(Question q, Options o)
        {
            Question = q;
            Options = o;
        }

        //public bool QuestionHasCorrectAnswer(Question q, Options options)
        //{

        //    var optionList = options.GetListOfOptions();

        //    foreach (var item in optionList)
        //    {
        //        Console.WriteLine($"You answered: {item}\nCorrect Answer is: {q.CorrectAnswer}");
        //        if (q.CorrectAnswer.ToLower() == item.ToLower())
        //            return true;
        //    }

        //    return false;

        //}


        //public void AddQuestion_Formula(Question q, Options options)
        //{
        //    //string cA = null;

        //    string[] optionArray = new string[] { options.Answer_A, options.Answer_B, options.Answer_C, options.Answer_D};

        //    foreach (var item in optionArray)
        //    {
        //        //if (q.CorrectAnswer.ToLower() == item.ToLower())
        //        //    cA = item;
        //        Console.WriteLine($"You answered: {item}\nCorrect Answer is: {q.CorrectAnswer}");
        //        if(q.CorrectAnswer.ToLower() == item.ToLower())
        //        {
        //            Console.WriteLine("You got the correct answer!!");
        //            break;
        //        }
        //    }

        //    //do
        //    //{

        //    //} while (q.CorrectAnswer != cA);

        //}
    }
}
