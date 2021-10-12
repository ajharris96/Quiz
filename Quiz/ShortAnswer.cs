using System;
namespace Quiz
{
    public class ShortAnswer : Question
    {
        public ShortAnswer()
        {
        }

        public ShortAnswer(string query, string answer)
        {
            Query = query;
            CorrectAnswer = answer;
            
        }

        public override string ToString()
        {
            return Query;
        }

        public override bool IsCorrect()
        {
            
            return CorrectAnswer.ToUpper() == UserAnswer.ToUpper();
        }
    }
}
