using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_Chap08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Twice t = new Twice();
            MessageBox.Show(textBox1.Text+"의 2배는 "+t[int.Parse(textBox1.Text)]+"이다.");
            t[int.Parse(textBox1.Text)] = 100; //set 호출
            MessageBox.Show(textBox1.Text + "의 2배는 " + t[int.Parse(textBox1.Text)] + "이다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySquare m = new MySquare();
            MessageBox.Show(textBox1.Text+"의 제곱은 "+m[int.Parse(textBox1.Text)]+"이다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            bool result = int.TryParse(textBox1.Text, out a);
            if(result)
                MessageBox.Show(textBox1.Text+"의 제곱은 "+new MySquare()[a]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out int a);
            if (result)
                MessageBox.Show(textBox1.Text + "의 제곱은 " + new MySquare()[a]);
        }

        void nextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + (x * vx);
            ry = y + (y * vy);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int x);
            int.TryParse(textBox3.Text, out int y);

            int.TryParse(textBox4.Text, out int vx);
            int.TryParse(textBox5.Text, out int vy);

            nextPos(x, y, vx, vy, out x, out y);

            label5.Text = "x의 다음 위치 : " + x;
            label6.Text = "y의 다음 위치 : " + y;
        }

        void swapFunc(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        void swapFunc(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox6.Text, out int x);
            int.TryParse(textBox7.Text, out int y);

            swapFunc(x, y); //ref 없는거
            MessageBox.Show("x="+x+", y="+y);


            swapFunc(ref x, ref y);
            label9.Text = "x=" + x;
            label10.Text = "y=" + y;
        }
    }
}
