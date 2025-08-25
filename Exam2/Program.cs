using Exam2.Examination_system;
using Exam2.Examination_system.BuildExam;
using Exam2.Examination_system.Exams;
using System.Diagnostics;

namespace Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam exam = ExamBuilder.Build();
            var subject = new Subject(1, "General Subject", exam);

            Console.Write("Ready to start exam? (yes/no): ");
            string? ready = Console.ReadLine()?.Trim().ToLower();
            Console.Clear();

            if (ready == "yes")
            {
                Stopwatch sw = Stopwatch.StartNew();
                subject.Exam.ShowExam();
                sw.Stop();
                Console.WriteLine($"\nTime Taken: {sw.Elapsed.Minutes} minutes {sw.Elapsed.Seconds} seconds");
                Console.WriteLine("Thank you for attending the exam!");
            }
            else
            {
                Console.WriteLine("Exam Cancelled.");
            }
        }
    }
}
