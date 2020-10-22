using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        //TODO: resolve problem with GradeBookType.Standard :<
        public GradeBookType BookType;

        public StandardGradeBook(string name) : base(name)
        {
        }
    }
}