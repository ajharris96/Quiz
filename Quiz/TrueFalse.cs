using System;
using System.Collections.Generic;


namespace Quiz
{
    public class TrueFalse : Question
    {
        

        public TrueFalse(string query, string answer)
        {
            Query = query;
            CorrectAnswer = answer;
            Choices = new Dictionary<char, string> { { 'A', "True" },{ 'B', "False" } };
        }

        public override bool IsCorrect()
        {
            return CorrectAnswer == UserAnswer || CorrectAnswer == Choices.GetValueOrDefault(char.Parse(UserAnswer.ToUpper()));

        }
    }
}
