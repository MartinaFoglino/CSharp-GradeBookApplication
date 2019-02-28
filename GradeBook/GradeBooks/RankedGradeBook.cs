using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked Grade needs more than 5 students");
            }

            var threshold = (int)Math.Ceiling(0.2 * Students.Count);
            var grades = Students.OrderByDescending(e => e.AverageGrade)
                                 .Select(e => e.AverageGrade).ToList();
            if(grades[threshold - 1] < averageGrade)
            {
                return 'A';
            }
            else if(grades[2*threshold - 1] < averageGrade)
            {
                return 'B';
            }
            else if(grades[3*threshold - 1] < averageGrade)
            {
                return 'C';
            }
            else if(grades[4*threshold - 1] < averageGrade)
            {
                return 'D';
            }else
            {
                return 'F';
            }
        }
    }
}
