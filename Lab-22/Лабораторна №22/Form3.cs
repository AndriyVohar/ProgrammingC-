using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Лабораторна__22
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = (int)numericUpDownA.Value;
            chart1.ChartAreas[0].AxisX.Maximum = (int)numericUpDownB.Value;
            chart1.ChartAreas[0].AxisX.Interval = (double)numericUpDownInterval.Value;
            for (double x = chart1.ChartAreas[0].AxisX.Minimum; x <= chart1.ChartAreas[0].AxisX.Maximum; x += chart1.ChartAreas[0].AxisX.Interval)
            {
                chart1.Series[0].Points.AddXY(x, Math.Sqrt(x) * Math.Tan(x));
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void завдання1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void завдання2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }


        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            Form3_Load(sender,e);
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void чиЄДанаФункціяСпадноюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message;
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            if (func.descendingOrGrowingFunction() == true)
                message = "Ні\n";
            else
                message = "Так, графік функції спадний \n";
            double[] minAndMax = func.maxAndMinOfFunction();
            message += $"Максимум графіка функції у точці Х = {minAndMax[0]} \n" +
                $"Мінімум графіка функції у точці Х = {minAndMax[1]}";
            MessageBox.Show(message);
        }
        private void чиЄДанаФункціяЗростаючоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message;
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            if (func.descendingOrGrowingFunction() == true)
                message = "Так, графік функції зростаючий \n";
            else
                message = "Ні\n";
            double[] minAndMax = func.maxAndMinOfFunction();
            message += $"Максимум графіка функції у точці Х = {minAndMax[0]} \n" +
                $"Мінімум графіка функції у точці Х = {minAndMax[1]}";
            MessageBox.Show(message);
        }

        private void чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            if (func.FunctionInOx() == true)
                MessageBox.Show("Так, графік функції перетинає вісь Ox");
            else
                MessageBox.Show("Ні, графік функції не перетинає вісь Ох");
        }

        private void вЯкомуКвадрантіБільшеТочокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            MessageBox.Show(func.morePointsInQuadrant());
        }

        private void середнєЗначенняФункціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            MessageBox.Show($"Середнє значення на даному проміжку функції F(x) = {func.AverageFunction()}");
        }

        private void найменшеДодатнеЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            MessageBox.Show(func.minFromPositive());
        }

        private void найбільшеВідємнеЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            MessageBox.Show(func.maxFromNegative());
        }

        private void наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionOperations func = new FunctionOperations((int)numericUpDownA.Value, (int)numericUpDownB.Value, (double)numericUpDownInterval.Value);
            if (func.PointWhereFunctionInOx() == 1000)
                MessageBox.Show("Точки перетину з віссю Ох нема");    
            else
                MessageBox.Show($"Точка (X) де функція перетинає вісь Ох на даному проміжку = {func.PointWhereFunctionInOx()}");
        }

        private void відобразитиСиметричноВідносноОсіОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (double x = 0; x<= chart1.ChartAreas[0].AxisX.Maximum; x += chart1.ChartAreas[0].AxisX.Interval)
            {
                chart1.Series[0].Points.AddXY(x, Math.Sqrt(x) * Math.Tan(x));
            }
            for (double x = 0; x <= chart1.ChartAreas[0].AxisX.Maximum; x += chart1.ChartAreas[0].AxisX.Interval)
            {
                chart1.Series[1].Points.AddXY(x, (-1) * Math.Sqrt(x) * Math.Tan(x));
            }
        }
        private void відобразитиСиметричноВідносноОсіОУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (double x = 0; x <= chart1.ChartAreas[0].AxisX.Maximum; x += chart1.ChartAreas[0].AxisX.Interval)
            {
                chart1.Series[0].Points.AddXY(x, Math.Sqrt(x) * Math.Tan(x));
            }
            for (double x = 0; x >= chart1.ChartAreas[0].AxisX.Minimum; x -= chart1.ChartAreas[0].AxisX.Interval)
            {
                chart1.Series[1].Points.AddXY(x, Math.Sqrt(Math.Abs(x)) * Math.Tan(Math.Abs(x)));
            }
        }
    }
}
