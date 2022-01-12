using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_01_last_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Name = "마티즈";
            c.Description = "토스에 조회해보니 0원";
            c.price = 0;
            c.quantity = 0;
            Console.WriteLine(c.quantity);
            c.quantity = 100;
            Console.WriteLine(c.quantity);

            Student s = new Student(111, "권승연", 29, 1);
            Student s2 = new Student();

            s2.Name = "권도균";

            s.DoStudy();
            s2.DoStudy();

            JamMin j = new JamMin(12, "권도균", 14, 2);
            j.DoStudy();
            j.Doplay();
        }
    }
}
