using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_chap07
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public  Animal()
        {
            Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "촵촵 먹는다.");
            System.Windows.Forms.MessageBox.Show(Name + "촵촵 먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + "이 잠을 잔다. zZZ....");
            System.Windows.Forms.MessageBox.Show(Name + "이 잠을 잔다. zZZ....");
        }
    }
}
