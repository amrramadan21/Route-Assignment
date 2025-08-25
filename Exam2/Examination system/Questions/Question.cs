using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }

        public string Body { get; set; }
         
        public int Mark { get; set; }

        public List<Answer> Answers  { get; set; }

        public int RightAnswerId { get; set; }

        protected Question(string header, string body, int mark, List<Answer> answers, int rightAnswerId)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header), "Header cannot be null");
            Body = body ?? throw new ArgumentNullException(nameof(body), "Body cannot be null");
            Mark = mark;
            Answers = answers ?? new List<Answer>();

            if (Answers.Any(a => a.AnswerId == rightAnswerId))
                RightAnswerId = rightAnswerId;
            else
                throw new ArgumentException("RightAnswerId must match one of the provided answers");
        }

        public abstract void ShowQuestion();

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}\nAnswers:\n{string.Join("\n", Answers)}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }
    }
}
