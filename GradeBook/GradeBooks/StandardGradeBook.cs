using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool boolean) : base(name, boolean)
        {
            Name = name;
            Type = Enums.GradeBookType.Standard;
        }

    }
}
