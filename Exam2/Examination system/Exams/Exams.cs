using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system.Exams
{
    internal abstract class Exam
    {

        public int Time {  get; set; }

        public int NumberOfQuestion => Questions?.Count ?? 0;

        public List<Question> Questions { get; set; }

        protected Exam(int time, List<Question> question)
        {
            Time = time;
            //NumberOfQuestion = numberOfQuestion;
            Questions = question ?? new List<Question>();
        }

        public abstract void ShowExam();


    }
}
