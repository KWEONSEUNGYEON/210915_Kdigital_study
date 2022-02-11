using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharp_chap07
{
    public partial class Form2 : Form
    {
        List<Dog> dogs = new List<Dog>();
        List<Cat> cat = new List<Cat>();
        List<Animal> animals = new List<Animal>();  
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d
            dogs.Add(new Dog());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cats.Add(new Cat());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animals.Add(new Dog());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            animals.Add(new Cat());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
