using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseQuestion
{
    public class SortById : IComparer<StudentDo>
    {
        public int Compare(StudentDo x, StudentDo y)
        {
           return x.Id.CompareTo(y.Id);
        }
    }
}
