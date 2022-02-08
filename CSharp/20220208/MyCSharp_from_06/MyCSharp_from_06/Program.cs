using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_from_06
{
    internal static class Program
    {

        //int abcdefg;
        //static int 이원만;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.WriteLine(abcdefg);
            //Console.WriteLine(이원만);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            Application.Run(f);
            // Application.Run(new Form1());
        }
    }
}
