using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseQuestion
{
    public class StudentDo
    {
        public String Name { get; set; }    
        public int Age { get; set; } 
        public int Id { get; set; }

        public StudentDo() { }
        public StudentDo(int id,String name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
