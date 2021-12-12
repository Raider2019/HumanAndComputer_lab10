using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                label1.Text = "d < 0 . Коренів немає.";
            }
if (d == 0)
            {
                double x = (-b / (2 * a));
                label1.Text ="Дискримінант =" + d + " " + "Корень =  " + x + ".";
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                label1.Text = "Дискримінант: " + d +" " + "Корені: " + "X1:" + " " + x1+" " + "X2: " +" " + x2;
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            label1.Text = " ";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

