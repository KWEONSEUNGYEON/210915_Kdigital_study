using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 인치?"); 

            int myinch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{ myinch}inch = { myinch * 2.54}cm");

            Console.WriteLine("몇 kg?");
            int mykg = int.Parse(Console.ReadLine());
            const double POUND = 2.20462262;
            //Console.WriteLine($"{mykg}kg = {mykg*POUND}");
            int ct = Console.CursorTop;
            int cl = Console.CursorLeft;
            Console.SetCursorPosition(cl + mykg.ToString().Length, ct - 1);
            Console.WriteLine($"kg = {mykg * POUND}");

            const double PI = 3.14;
            Console.WriteLine("원의 반지름 입력받아 원의 둘레와 넓이 구하기");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"둘레 = {2 * PI * r}");
            Console.WriteLine($"넓이 = {PI * r * r}");


            Console.WriteLine("첫 번째 숫자를 입력해주세요.");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력해주세요.");
            int second = int.Parse(Console.ReadLine());

            //alt+ctrl = 여러개를 마우스로 선택
            //alt+shift+방향키 : 여러개를 키보드로 선택 가능
            Console.WriteLine($"{first*(second % 10)}");
            Console.WriteLine($"{first*((second/10) % 10)}");
            Console.WriteLine($"{first*(second / 100)}");
            Console.WriteLine($"{first*second}");

            //'0'은 숫자 48로 대응되고, '9'는 숫자 57로 대응됨
            string str_second = second.ToString();
            Console.WriteLine($"{first*(str_second[2]-'0')}");
            Console.WriteLine($"{first*(str_second[1]-'0')}");
            Console.WriteLine($"{first*(str_second[0]-'0')}");

            //Char.GetNumericValue = 글자를 숫자로 바꿔주는 방법
            Console.WriteLine($"{first*Char.GetNumericValue(str_second[0])}");

            //Tostring과 parse 이용
            Console.WriteLine($"{first * int.Parse(str_second[2].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_second[1].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_second[0].ToString())}");
        }
    }
}
