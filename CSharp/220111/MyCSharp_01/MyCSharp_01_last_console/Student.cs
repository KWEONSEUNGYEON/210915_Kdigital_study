using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_01_last_console
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Student(int id, string name, int age, int number)
        {
            Id = id;
            Name = name;
            Age = age;
            Number = number;
        }

        public int Id { get; set; } 
        public string Name { get; set; }

        public int Age { get; set; }
        
        public int Number { get; set; }

        public void DoStudy()
        {
            Console.WriteLine(Name+"은 열심히 공부하고 있습니다.");
        }
    }
}
