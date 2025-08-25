using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system.Exams
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time,List<Question> questions) : base(time, questions)
        {
        }

        public override void ShowExam()
        {
            int totalGrade = 0;
            int studentGrade = 0;

            Console.WriteLine("=========== Final Exam ===========\n");

            int qNum = 1;
            foreach (var q in Questions)
            {
                Console.WriteLine($"Q{qNum}: {q.Body}  ({q.Mark} marks)");

                foreach (var ans in q.Answers)
                {
                    Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");
                }

                Console.Write("Your Answer (enter Id): ");
                int.TryParse(Console.ReadLine(), out int studentAnswerId);

                totalGrade += q.Mark;

                if (studentAnswerId == q.RightAnswerId)
                {
                    studentGrade += q.Mark;
                }

                Console.WriteLine($"Correct Answer: {q.RightAnswerId}");
                Console.WriteLine($"Your Answer: {studentAnswerId}\n");

                qNum++;
            }

            Console.WriteLine("=================================");
            Console.WriteLine($"Your Grade: {studentGrade}/{totalGrade}");
            Console.WriteLine("=================================\n");
        }
    }
}
