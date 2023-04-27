using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна__22
{
    internal class ArrayFromGrid
    {
        double[] data;
        public ArrayFromGrid(DataGridView gridView) {
            data = readDataFromGrid(gridView);
        }
        public ArrayFromGrid(int length)
        {
            data = getRandomArray(length);
        }
        //Methods
        public void maxFromNegativeNumbers() 
        {
            double[] negative = negativeNumbers();
            double max = negative.Max();
            MessageBox.Show("Максимум із від'ємних значень: "+max);
        }
        public void minFromPositiveNumbers()
        {
            double[] positive = positiveNumbers();
            double min = positive.Min();
            MessageBox.Show("Мінімум із додатних значень: " + min);
        }

        public double[] negativeNumbers()
        {
            int numberOfNegative = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0)
                {
                    numberOfNegative++;
                }
            }
            double[] negativeNumbers = new double[numberOfNegative];
            numberOfNegative = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0)
                {
                    negativeNumbers[numberOfNegative] = data[i];
                    numberOfNegative++;
                }
            }
            return negativeNumbers;
        }
        public double[] positiveNumbers()
        {
            int numberOfPositive = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > 0)
                {
                    numberOfPositive++;   
                }
            }
            double[] positiveNumbers = new double[numberOfPositive];
            numberOfPositive = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > 0)
                {
                    positiveNumbers[numberOfPositive] = data[i];
                    numberOfPositive++;
                }
            }
            return positiveNumbers;
        }
        private double[] getRandomArray(int length)
        {
            double[] data = new double[length];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < length; i++)
            {
                data[i] = rand.Next(-20, 21);
            }
            return data;
        }

        //Array from DataGridView
        public static double[] readDataFromGrid(DataGridView grid)
        {
            double[] arr = new double[grid.ColumnCount];
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                arr[i] = Convert.ToDouble(grid[i, 0].Value);
            }
            return arr;
        }
        public void writeDataToGrid(DataGridView grid)
        {
            grid.ColumnCount = data.Length;
            for (int i = 0; i < data.Length; i++)
            {
                grid[i,0].Value = data[i];
            }
        }
    }
}
