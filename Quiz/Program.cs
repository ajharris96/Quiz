using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz marvel = new Quiz("Marvel Cinematic Universe Quiz");

            MultiChoice question1 = new MultiChoice("How many infinity Stones are there?", "Six");
            question1.Choices = new Dictionary<char, string>{{ 'A', "Four" }, { 'B', "Six" }, { 'C', "Five" }, { 'D', "Three" } };

            TrueFalse question2 = new TrueFalse("Only Thor can lift his hammer.", "False");

            CheckBox question3 = new CheckBox("Who sided with Captain America in Civil War?", "ABD");
            question3.Choices = new Dictionary<char, string> { { 'A', "Bucky" }, { 'B', "Falcon" }, { 'C', "Spider-Man" }, { 'D', "Ant-Man" } };

            marvel.AddQuestion(question1);
            marvel.AddQuestion(question2);
            marvel.AddQuestion(question3);

            marvel.RunQuiz();

            Console.WriteLine("You scored: " + marvel.GradeQuiz() + "%");

        }
    }
}
