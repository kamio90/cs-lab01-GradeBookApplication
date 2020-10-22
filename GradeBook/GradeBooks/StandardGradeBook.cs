using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {

        public StandardGradeBook(string name) : base(name)
        {
            Type type = typeof(GradeBookType);
        }
    }
}