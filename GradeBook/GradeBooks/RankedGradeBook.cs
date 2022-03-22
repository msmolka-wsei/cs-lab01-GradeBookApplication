using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Name = name;
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int numberOfStudents = Students.Count;

            double N = Convert.ToDouble(numberOfStudents / 5);
            if (Students.Count < 5)
                throw new InvalidOperationException();
            else if (averageGrade >= N)
                return 'A';
            else if (averageGrade >= 2*N)
                return 'B';
            else if (averageGrade >= 3*N)
                return 'C';
            else if (averageGrade >= 4*N)
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
