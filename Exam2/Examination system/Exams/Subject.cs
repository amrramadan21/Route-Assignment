using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Examination_system.Exams
{
    internal class Subject : ICloneable, IComparable<Subject>
    {

        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Exam = exam;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"Subject Id: {SubjectId}, Name: {SubjectName}, Exam: {(Exam != null ? Exam.GetType().Name : "No Exam")}";
        }

        public object Clone()
        {
            return new Subject(this.SubjectId, this.SubjectName, this.Exam);
        }

        public int CompareTo(Subject? other)
        {
            if (other == null) return 1;
            return this.SubjectId.CompareTo(other.SubjectId);
        }
    }
}
