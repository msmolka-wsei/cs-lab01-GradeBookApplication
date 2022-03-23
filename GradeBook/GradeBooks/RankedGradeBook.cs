using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool boolean) : base(name, boolean)
        {
            Name = name;
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5) throw new InvalidOperationException();
            int average = 0;
            foreach (var student in this.Students)
            {
                if (Queryable.Average(student.Grades.AsQueryable()) > averageGrade)
                {
                    ++average;
                }
            }
            double n = average / (double)this.Students.Count;
            if (n < 0.2)
                return 'A';
            else if (n < 0.4)
                return 'B';
            else if (n < 0.6)
                return 'C';
            else if (n < 0.8)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }

            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }

            else
            {
                base.CalculateStudentStatistics(name);
            }
        }

    }
}
