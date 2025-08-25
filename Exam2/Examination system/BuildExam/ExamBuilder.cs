using Exam2.Examination_system.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system.BuildExam
{
    internal static class ExamBuilder
    {

        public static Exam Build()
        {
            int examType = ChooseExamType();
            int time = ChooseExamTime();
            int numQuestions = ChooseNumQuestions();

            Console.Clear();
            var questions = new List<Question>();

            for (int i = 1; i <= numQuestions; i++)
                questions.Add(CreateQuestion(i, examType));

            return (examType == 1)
                ? new FinalExam(time, questions)
                : new PracticalExam(time, questions);
        }

        private static int ChooseExamType()
        {
            Console.Write("Enter Exam Type (1. Final / 2. Practical): ");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
                Console.Write("Invalid choice. Enter 1 for Final or 2 for Practical: ");
            return examType;
        }

        private static int ChooseExamTime()
        {
            int time;
            do
            {
                Console.Write("Enter Exam Time (30 - 180 minutes): ");
            } while (!int.TryParse(Console.ReadLine(), out time) || time < 30 || time > 180);
            return time;
        }

        private static int ChooseNumQuestions()
        {
            Console.Write("Enter number of questions: ");
            int numQuestions;
            while (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0)
                Console.Write("Invalid input. Enter a positive number of questions: ");
            return numQuestions;
        }

        private static Question CreateQuestion(int index, int examType)
        {
            Console.WriteLine($"--- Question {index} ---");

            int qType;
            if (examType == 2) // Practical → MCQ only
            {
                qType = 1;
                Console.WriteLine("Question Type: MCQ (Practical Exam only allows MCQ)");
            }
            else
            {
                Console.Write("Enter Question Type (1. MCQ / 2. T/F): ");
                while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2))
                    Console.Write("Invalid input. Enter 1 for MCQ or 2 for T/F: ");
            }

            Console.Write("Enter Question Body: ");
            string body = Console.ReadLine() ?? "";

            Console.Write("Enter Question Mark: ");
            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                Console.Write("Invalid input. Enter a positive mark: ");

            var answers = new List<Answer>();
            if (qType == 1) // MCQ
            {
                Console.Write("How many options? ");
                int numOptions;
                while (!int.TryParse(Console.ReadLine(), out numOptions) || numOptions < 3)
                    Console.Write("Invalid input. Enter at least 3 options: ");

                for (int j = 1; j <= numOptions; j++)
                {
                    Console.Write($"Enter option {j}: ");
                    string opt = Console.ReadLine() ?? "";
                    answers.Add(new Answer(j, opt));
                }
            }
            else // True/False
            {
                answers.Add(new Answer(1, "True"));
                answers.Add(new Answer(2, "False"));
            }

            Console.Write("Enter Correct Answer Id: ");
            int rightId;
            while (!int.TryParse(Console.ReadLine(), out rightId) || !answers.Exists(a => a.AnswerId == rightId))
                Console.Write("Invalid input. Enter a valid answer Id: ");

            return (qType == 1)
                ? new MCQQuestion("MCQ", body, mark, answers, rightId)
                : new TrueFalseQuestion("True/False", body, mark, answers, rightId);
        }

    }
}
