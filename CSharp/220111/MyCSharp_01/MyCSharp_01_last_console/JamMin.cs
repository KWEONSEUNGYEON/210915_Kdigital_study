using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_01_last_console
{
    internal class JamMin : Student
    {
        public JamMin(int id, string name, int age, int number) : base(id, name, age, number)
        {
        }

        public void Doplay()
        {
            Console.WriteLine(Name+"은 하라는 공부는 안하고 게임한다.");
            Console.WriteLine("나이는 겨우 "+Age+"살이다.");
        }
    }
}
