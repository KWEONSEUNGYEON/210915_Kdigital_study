using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.Text = r.Next(10).ToString(); //0~9값이 나옴
        }

        private void buttonbutton(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text+ "안녕하십니까!!!");
        }
    }
}
