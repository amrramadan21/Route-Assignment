using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, List<Answer> answers, int rightAnswerId)
           : base(header, body, mark,new List<Answer> { new Answer(1, "True"),new Answer(2, "False")}, rightAnswerId)
        {
            if (rightAnswerId != 1 && rightAnswerId != 2)
                throw new ArgumentException("True/False Question must have rightAnswerId = 1 (True) or 2 (False)");
            Answers = answers;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"[True/False] {Header}");
            Console.WriteLine(Body);
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            Console.WriteLine($"Mark: {Mark}");
        }
    }
}
