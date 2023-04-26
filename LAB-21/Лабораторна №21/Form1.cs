using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна__21
{
    public partial class Form1 : Form
    {
        static double F(double x)
        {
            double result = 0;
            if (x > 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    result += Math.Pow(x, i);
                }
            }
            else
            {
                result = 1;
                for (int i = 1; i < 6; i++)
                {
                    result *= Math.Pow(x, i);
                }
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double u = F(a) + F(2) + F(b);
            textBoxResult1.Text = u.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            double x = Convert.ToDouble(textBoxX.Text);
            double result = 0;
            for(int i = 1; i <= n; i += 2)
            {
                result += Math.Sin(Math.Pow(x,i));
            }
            for(int i = 2; i<=n; i += 2)
            {
                result -= Math.Cos(Math.Pow(x, i));
            }
            textBoxResult2.Text = result.ToString();
        }
    }
}
