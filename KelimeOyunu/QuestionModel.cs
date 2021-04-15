using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public QuestionModel(string question, string answer)
        {
            this.Question = question;
            this.Answer = answer;
        }
    }
}
