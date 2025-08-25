using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system
{
    internal class Answer : ICloneable
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public Answer(int answerId,string answerText) 
        {
            AnswerId = answerId;
            AnswerText = answerText ?? throw new ArgumentNullException(nameof(answerText), "Answer text cannot be null");
        }

        public override string ToString()
        {
            return $"Answer Id : {AnswerId} ,Answer Text : {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(this.AnswerId, this.AnswerText);
        }
    }
}
