using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                {

                    double a, b, h, hg;
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    h = Convert.ToDouble(textBox3.Text);
                    hg = Convert.ToDouble(textBox4.Text);

                    Console.WriteLine(a * b * h * 0.001);
                    textBox5.Text = Convert.ToString(a * b * h * 0.001);
                    Console.WriteLine(a * b * hg);
                    textBox6.Text = Convert.ToString(a * b * hg / 1000);
                    Console.WriteLine(hg * 1.6);
                    textBox7.Text = Convert.ToString(a * b * hg * 1.5 / 1000);





                }
            }

         
        }
    }
}
    

