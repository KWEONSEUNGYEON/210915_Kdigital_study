using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            if(flag)
            {
            char hakjeom = 'A';
            switch (hakjeom)
            {
                case 'A':
                    Console.WriteLine("엘리트");
                    break;
                case 'B':
                    Console.WriteLine("나쁘지않음");
                    break;
                case 'C':
                case 'D':
                    Console.WriteLine("좀 문제있음");
                    break;
                case 'F':
                    Console.WriteLine("ㅠㅠ");
                    break;
                default:
                    Console.WriteLine($"{hakjeom}은 유효하지 않습니다.");
                    break;
            }

            int mynumber = 100;
            string result = mynumber % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(mynumber % 2 == 0 ? "짝수" : "홀수");
            Console.WriteLine(result);

            string Hello = "Hello World";
            bool t1 = Hello.Contains("Hell");
            bool t2 = Hello.Contains("HELL");
            Console.WriteLine("t1="+t1);
            Console.WriteLine("t2="+t2);
            }

            #region solve
            int nowYear = DateTime.Now.Year; 
            int nowMonth = DateTime.Now.Month;

            Console.WriteLine("올해의 띠는?");
            switch (nowYear%12)
            {
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                default:
                    break;
            }

            switch (nowMonth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(" 봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    break;
            }

            Console.WriteLine("나이를 입력해주세요.");
            int age = int.Parse(Console.ReadLine());
        
            //내가 만약 34살 이면 3.4가 되서, int 변수니까 3이 됨
            switch (age/10)
            {
                case 0:
                case 1:
                    Console.WriteLine("미성년자");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("청년");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("중년");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("노년");
                    break;
                case 10:
                case 11:
                case 12:
                    if(age>123)
                        Console.WriteLine("타노스");
                    else
                        Console.WriteLine("장수");
                    break;
                default:
                    Console.WriteLine("타노스");
                    break;
            }

            #endregion

        }
    }
}
