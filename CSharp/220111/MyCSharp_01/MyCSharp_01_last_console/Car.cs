using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_01_last_console
{
    public class Car
    {
        public string Name { get; set; } // 자동차 이름
        public string Description { get; set; } // 자동차에 대한 설명

        public int price; //자동차 가격


        private int q;
        public int quantity
        {
            get { return q; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"{value}는 음수입니다!!!");
                    q = 0;
                }
                else
                    q = value;
            }
        }
    }
}
