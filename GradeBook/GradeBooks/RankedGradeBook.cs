using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        //TODO: resolve problem with GradeBookType.Ranked :<
        public GradeBookType Type;
        public RankedGradeBook(string name) : base(name)
        {
            
        }
    }
}