using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp04_01_dataGridView
{
    public partial class Form2 : Form
    {
        List<Student> students = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Stuname = textBox_Stuname.Text;
            s.age = int.Parse(textBox_age.Text);
            s.grade = int.Parse(textBox_grade.Text);
            s.score = int.Parse(textBox_score.Text);
            students.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
    }
}
