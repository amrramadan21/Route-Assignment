using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time,List<Question> questions) : base(time, questions)
        {
            if (questions.Any(q => q is not MCQQuestion))
            {
                throw new ArgumentException("Practical Exam can only contain MCQ questions.");
            }
        }

        public override void ShowExam()
        {
            Console.WriteLine("=========== Practical Exam ===========\n");

            int qNum = 1;
            foreach (var q in Questions)
            {
                Console.WriteLine($"Q{qNum}: {q.Body}");

                foreach (var ans in q.Answers)
                {
                    Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");
                }

                Console.Write("Your Answer (enter Id): ");
                int.TryParse(Console.ReadLine(), out int _); 

                Console.WriteLine();
                qNum++;
            }

            Console.WriteLine("\n--- Correct Answers ---");
            qNum = 1;
            foreach (var q in Questions)
            {
                var correct = q.Answers.FirstOrDefault(a => a.AnswerId == q.RightAnswerId);
                Console.WriteLine($"Q{qNum}: {q.Body} -> {correct?.AnswerText}");
                qNum++;
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine("End of Practical Exam. Good Luck!");
            Console.WriteLine("=================================\n");

        }
    }
}
