using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseQuestion
{
    public class Executor
    {
        public static void Main(String[] args)
        {
            List<StudentDo> originalList = new List<StudentDo>();
            originalList.Add(new StudentDo(101, "ram", 20));
            originalList.Add(new StudentDo(102, "bhawna", 21));
            originalList.Add(new StudentDo(103, "komal", 22));
            originalList.Add(new StudentDo(104, "antim", 23));
            originalList.Add(new StudentDo(105, "raja", 24));
            originalList.Add(new StudentDo(106, "ram", 32));
            originalList.Add(new StudentDo(107, "ram", 24));
            originalList.Add(new StudentDo(108, "bhawna", 76));
            originalList.Add(new StudentDo(109, "raja", 45));
            originalList.Add(new StudentDo(110, "ram", 87));

            Console.WriteLine("originalList is = ");
            foreach (StudentDo e in originalList)
            {
                Console.WriteLine(e.Id+" "+e.Name+" "+e.Age);   
            }

            //SortByName sortByNameObj = new SortByName();
            //originalList.Sort(sortByNameObj);
            //Console.WriteLine("after sorting list is = ");
            //foreach (StudentDo e in originalList)
            //{
            //    Console.WriteLine(e.Id + " " + e.Name + " " + e.Age);
            //}



            //SortById sortByIdObj = new SortById();
            //originalList.Sort(sortByIdObj);
            //Console.WriteLine("after sorting list is = ");
            //foreach (StudentDo e in originalList)
            //{
            //    Console.WriteLine(e.Id + " " + e.Name + " " + e.Age);
            //}


            SortByAge sortByAgeObj = new SortByAge();
            originalList.Sort(sortByAgeObj);
            Console.WriteLine("after sorting list is = ");
            foreach (StudentDo e in originalList)
            {
                Console.WriteLine( e.Age+" "+ e.Id + " " + e.Name );
            }

        }

    }
}
