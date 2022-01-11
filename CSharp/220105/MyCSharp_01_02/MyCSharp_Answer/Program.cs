using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_Answer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for(int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine("숫자 입력하세요.");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            int min = numbers[0];
            foreach(var item in numbers)
            {
                if(max < item)
                    max = item;
                if(min > item)
                    min = item;
            }
            Console.WriteLine($"최댓값은 {max}, 최솟값은 {min}입니다.");
        }
    }
}
