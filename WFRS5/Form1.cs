using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRS5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string answ1 = "X1=";
            string answ2 = "X2=";

            float a = float.Parse(textBoxA.Text);
            float b = float.Parse(textBoxB.Text);
            float c = float.Parse(textBoxC.Text);

            float d = (b * b) - 4f * a * c;

            if (d < 0)
            {
                label3.Text = answ1 + "Ответов нет!";
                label6.Text = answ2 + "Ответов нет!";
            }

            else if (d == 0)
            {
                float x1 = -b / (2*a);
                label3.Text = answ1 + x1.ToString();
                label6.Text = answ2 + "Ответ только один!";
            }
            
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                label3.Text = answ1 + x1.ToString();
                label6.Text = answ2 + x2.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
