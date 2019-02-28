using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWheighted) : base(name, isWheighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
