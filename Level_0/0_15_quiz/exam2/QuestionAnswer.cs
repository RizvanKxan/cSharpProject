using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam2
{
    public class QuestionAnswer
    {
        public string Question;
        public Dictionary<string, bool> answers;

        public QuestionAnswer(string question, Dictionary<string, bool> answers)
        {
            Question = question;
            this.answers = answers;
        }
    }
}
