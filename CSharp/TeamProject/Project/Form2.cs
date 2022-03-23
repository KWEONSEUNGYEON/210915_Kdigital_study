using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        Form1 f1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;
            Color c = Color.FromArgb(224, 229, 236); //배경색
            Color d = Color.FromArgb(91, 91, 91); //글자색
            Color e = Color.FromArgb(64, 64, 64); //버튼색
            this.BackColor = c;
            this.ForeColor = d;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //경계 곡선
            park1.BackColor = e; park2.BackColor = e; park3.BackColor = e; park4.BackColor = e; park5.BackColor = e; park6.BackColor = e;
            park7.BackColor = e; park8.BackColor = e; park9.BackColor = e; park10.BackColor = e; park11.BackColor = e; park12.BackColor = e;
            park13.BackColor = e; park14.BackColor = e; park15.BackColor = e; park16.BackColor = e; park17.BackColor = e; park18.BackColor = e;
            park19.BackColor = e; park20.BackColor = e; park21.BackColor = e; park22.BackColor = e; park23.BackColor = e; park24.BackColor = e;
            park25.BackColor = e; park26.BackColor = e; park27.BackColor = e; park28.BackColor = e; park29.BackColor = e; park30.BackColor = e;
            ifCarOn(1, park1); ifCarOn(2, park2); ifCarOn(3, park3); ifCarOn(4, park4); ifCarOn(5, park5); ifCarOn(6, park6); ifCarOn(7, park7); ifCarOn(8, park8);
            ifCarOn(9, park9); ifCarOn(10, park10); ifCarOn(11, park11); ifCarOn(12, park12); ifCarOn(13, park13); ifCarOn(14, park14); ifCarOn(15, park15); ifCarOn(16, park16);
            ifCarOn(17, park17); ifCarOn(18, park18); ifCarOn(19, park19); ifCarOn(20, park20); ifCarOn(21, park21); ifCarOn(22, park22); ifCarOn(23, park23); ifCarOn(24, park24);
            ifCarOn(25, park25); ifCarOn(26, park26); ifCarOn(27, park27); ifCarOn(28, park28); ifCarOn(29, park29); ifCarOn(30, park30);
        }
        public void ifCarOn(int num, Button park)
        {
            ParkingCar car = Data.selectQuery(num);
            if (car.CarNumber != "")
            {
                park.Image = Properties.Resources.car4;
            }
        }
        public void buttonOn(int num)
        {
            ParkingCar car = Data.selectQuery(num);
            f1.textBox1.Text = car.ParkNum.ToString();
            f1.textBox2.Text = car.CarNumber;
            f1.textBox3.Text = car.DriverName;
            f1.textBox4.Text = car.PhoneNumber;
            Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private Point mousePoint;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }
        private void park1_Click(object sender, EventArgs e)
        {
            buttonOn(1);
        }
        private void park2_Click(object sender, EventArgs e)
        {
            buttonOn(2);
        }
        private void park3_Click(object sender, EventArgs e)
        {
            buttonOn(3);
        }
        private void park4_Click(object sender, EventArgs e)
        {
            buttonOn(4);
        }
        private void park5_Click(object sender, EventArgs e)
        {
            buttonOn(5);
        }
        private void park6_Click(object sender, EventArgs e)
        {
            buttonOn(6);
        }
        private void park7_Click(object sender, EventArgs e)
        {
            buttonOn(7);
        }
        private void park8_Click(object sender, EventArgs e)
        {
            buttonOn(8);
        }
        private void park9_Click(object sender, EventArgs e)
        {
            buttonOn(9);
        }
        private void park10_Click(object sender, EventArgs e)
        {
            buttonOn(10);
        }
        private void park11_Click(object sender, EventArgs e)
        {
            buttonOn(11);
        }
        private void park12_Click(object sender, EventArgs e)
        {
            buttonOn(12);
        }
        private void park13_Click(object sender, EventArgs e)
        {
            buttonOn(13);
        }
        private void park14_Click(object sender, EventArgs e)
        {
            buttonOn(14);
        }
        private void park15_Click(object sender, EventArgs e)
        {
            buttonOn(15);
        }
        private void park16_Click(object sender, EventArgs e)
        {
            buttonOn(16);
        }
        private void park17_Click(object sender, EventArgs e)
        {
            buttonOn(17);
        }
        private void park18_Click(object sender, EventArgs e)
        {
            buttonOn(18);
        }
        private void park19_Click(object sender, EventArgs e)
        {
            buttonOn(19);
        }
        private void park20_Click(object sender, EventArgs e)
        {
            buttonOn(20);
        }
        private void park21_Click(object sender, EventArgs e)
        {
            buttonOn(21);
        }
        private void park22_Click(object sender, EventArgs e)
        {
            buttonOn(22);
        }
        private void park23_Click(object sender, EventArgs e)
        {
            buttonOn(23);
        }
        private void park24_Click(object sender, EventArgs e)
        {
            buttonOn(24);
        }
        private void park25_Click(object sender, EventArgs e)
        {
            buttonOn(25);
        }
        private void park26_Click(object sender, EventArgs e)
        {
            buttonOn(26);
        }
        private void park27_Click(object sender, EventArgs e)
        {
            buttonOn(27);
        }
        private void park28_Click(object sender, EventArgs e)
        {
            buttonOn(28);
        }
        private void park29_Click(object sender, EventArgs e)
        {
            buttonOn(29);
        }
        private void park30_Click(object sender, EventArgs e)
        {
            buttonOn(30);
        }
    }
}
