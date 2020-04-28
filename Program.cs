using QuizCollab.Model;
using System;

namespace QuizCollab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gamer!\n");

            BuildingQuiestions();

            Console.ReadLine();
        }


        public static bool TestFuncQuizList(Quiz quiz)
        {
            var optionList = quiz.Options.GetListOfOptions();
            var q = quiz.Question;

            Console.WriteLine($"{q.GetQuestion()}\n");

            foreach (var item in optionList)
            {
                Console.WriteLine($"You answered: {item}\nCorrect Answer is: {q.GetCorrectAnswer()}");
                if (q.GetCorrectAnswer().ToLower() == item.ToLower())
                    return true;
            }

            return false;

        }

        public static void BuildingQuiestions()
        {

            string question = "What is my name?";
            string correctAnswer = "GINO";
            string o1 = "a";
            string o2 = "b";
            string o3 = "gInO";
            string o4 = "c";

            Question q = new Question(question,correctAnswer);
            Options o = new Options(o1, o2, o3, o4);
            Quiz quiz = new Quiz(q,o);


            if (TestFuncQuizList(quiz))
                Console.WriteLine("You got the correct answer!!");
            else
                Console.WriteLine("You fucked up..");
        }
    }
}
