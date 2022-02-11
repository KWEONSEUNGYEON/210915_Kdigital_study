using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_from_08
{
    public partial class Form1 : Form
    {
        int answer = 0;
        int timerCount = 0;
        public Form1()
        {
            InitializeComponent();
            //answer = new Random().Next(10) + 1;
            answer = new Random().Next(1,11); //1이상 11미만
            Console.WriteLine("정답 : " + answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = int.Parse(textBox1.Text);
            if(mychoice == answer)
            {
                MessageBox.Show("정답!");
                answer = new Random().Next(1,11);
                Console.WriteLine("answer : " +answer);
                label2.Text = "Finished!";
                timerCount = 0;
            }
            else
            {
                MessageBox.Show("오답!");
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            //if(timerCount %5 == 0)
            if(timerCount >= 5)
            {
                label2.Text = "Timeout";
            }
        }
    }
}
