using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCarManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text =
                $"현재시간 : {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
    }
}
