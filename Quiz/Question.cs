using System;
using System.Collections.Generic;

namespace Quiz
{
    public abstract class Question
    {

        public string Query { get; set; }

        public Dictionary<char,string> Choices { get; set; }

        public string CorrectAnswer;

        public string UserAnswer;


        public Question()
        {

        }

        abstract public bool isCorrect();
        

        public override string ToString()
        {
            string str= Query + "\n";
            foreach (KeyValuePair<char,string> choice in Choices)
            {
                str += choice.Key + ": " + choice.Value + "\n";
            }
            return str;
        }

    }
}
