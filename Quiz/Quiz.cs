using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



namespace Quiz
{
    public class Quiz
    {
        List<Question> Questions;

        public string Title { get; set; }

        

        public Quiz()
        {
            Title = "Default Title";
            Questions = new List<Question>();
        }

        public Quiz(string title)
        {
            Title = title;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question q)
        {
            Questions.Add(q);
        }



        public double GradeQuiz()
        {
            double correct = 0;

            foreach (Question q in Questions)
            {
                if (q.IsCorrect())
                {
                    correct++;
                }
            }

            return Math.Round((correct / Questions.Count)*100,0);

        }

        public void RunQuiz()
        {
            Console.WriteLine(Title + ":");
            foreach (Question q in Questions)
            {
                Console.WriteLine(q.ToString());
                string input = Console.ReadLine().Trim();
                q.UserAnswer = Regex.Replace(input, "(\\p{P})", "");

                

                if (q.GetType().ToString() == "Quiz.ShortAnswer" && q.UserAnswer.Length > 80)
                {
                    Console.WriteLine("Short answer is too long. Try Again.");
                    q.UserAnswer = Console.ReadLine();
                }
            }

        }

    }
}
