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

        public override bool isCorrect()
        {
            return CorrectAnswer == UserAnswer.ToUpper();

        }
    }
}
