using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            //ctrl누르고 k누르고c 주석처리
            //ctrl누르고 k 누르고u 누르면 주석해제
            //정렬
            //ctrl +k,f

            Console.WriteLine("문자 입력해보세요.");
            char c = Console.ReadLine()[0];
            Console.WriteLine("c="+c);
        }

    }
}
