using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, List<Answer> answers, int rightAnswerId) : base(header, body, mark, answers, rightAnswerId)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"[MCQ] {Header}");
            Console.WriteLine(Body);

            foreach (var ans in Answers)
            {
                Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");
            }

            Console.WriteLine($"Mark: {Mark}");
        }
    }
}
