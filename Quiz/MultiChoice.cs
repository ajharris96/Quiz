using System;
using System.Collections.Generic;
namespace Quiz
{
    public class MultiChoice : Question
    {

       

        public MultiChoice()
        {
        }

        public MultiChoice(string query, string answer)
        {
            Query = query;
            CorrectAnswer = answer;
            Choices = new Dictionary<char, string>();
        }

        public MultiChoice(string query, string answer, Dictionary<char, string> choices)
        {
            Query = query;
            CorrectAnswer = answer;
            Choices = choices;
        }

        public void AddChoice(char index, string str)
        {
            Choices.Add(index, str);
        }


        public override bool IsCorrect()
        {
            return CorrectAnswer == Choices.GetValueOrDefault(char.Parse(UserAnswer.ToUpper()));

        }

    }
}
