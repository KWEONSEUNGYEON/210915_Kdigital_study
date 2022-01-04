using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("안녕하세요.");
            Console.WriteLine(Console.ReadLine());
            String name = Console.ReadLine();


            //도구->코드조각관리자->가져오기(만들어둔 곳의 경로)
            //cr tap*2
            Console.ReadLine();
            //intcr
            int.Parse(Console.ReadLine());
            //tryint
            int.TryParse(Console.ReadLine(), out int ex);  
        }
    }
}
