using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer2
{
    public partial class Form_myGame : Form
    {
        int limitTimer = 0;
        int answer = 0;
        int nowtime = 0;

        public Form_myGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_limit.Enabled = false;
            nowtime = 0;

            label2.Text = "Game Start!!!";
            answer = new Random().Next(1, 26); //1이상 25이하
            Console.WriteLine("answer : " + answer);

            int count = 1;

            //버튼을 코드상에서 그려주는 부분
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Button button = new Button();  
                    Point point = new Point();
                    point.X = 115 * j; //115임의로
                    point.Y = 50 * i;
                    button.Location = point;
                    button.Click += Button_Click;
                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button);
                }
            }

            timer_limit.Enabled=true;
            try
            {
                limitTimer = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                nowtime = -1;

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if( ((Button)sender).Text == answer.ToString() )
            {
                label2.Text = "you win";
                nowtime = 0;
                timer_limit.Enabled = false;
            }
            else
            {
                label2.Text = "이거 보물 아님";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime++;
            if(nowtime >= limitTimer || nowtime  <= -1)
            {
                label2.Text = "Game Over!!!";
                nowtime = 0;
                timer_limit.Enabled = false; //타이머끄기
            }
        }


    }
}
