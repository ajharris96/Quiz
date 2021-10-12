using System;
using System.Collections.Generic;
namespace Quiz
{
    public class CheckBox : Question
    {
      

        public CheckBox()
        {

        }

        public CheckBox(string query, string answer)
        {
            Query = query;
            CorrectAnswer = answer;
            Choices = new Dictionary<char, string>();
        }

        public CheckBox(string query, string answer, Dictionary<char,string> choices)
        {
            Query = query;
            CorrectAnswer = answer;
            Choices = choices;
        }

        public override bool IsCorrect()
        {
            return CorrectAnswer == UserAnswer.ToUpper();

        }
    }
}
