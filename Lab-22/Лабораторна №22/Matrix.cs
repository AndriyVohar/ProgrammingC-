using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Лабораторна__22
{
    internal class Matrix
    {
        //Та функція про яку я казав:
        //https://learn.microsoft.com/ru-ru/dotnet/api/system.array.length?view=net-7.0
        //static int Dimension(double[,] matrix)
        //{
        //    return matrix.GetUpperBound(matrix.Rank - 1) + 1;
        //}
        private double[,] matrix;
        int n;
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
            n = matrix.GetLength(0);
        }
        public Matrix(DataGridView gridView)
        {
            matrix = readDataFromGrid(gridView);
            n = matrix.GetLength(0);
        }
        public Matrix(int length)
        {
            matrix = getRandomMatrix(length);
            n = matrix.GetLength(0);
        }

        //Method
        public static Matrix operator +(Matrix a, Matrix b)
        {
            double[,] data = new double[a.n, a.n];
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    data[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return new Matrix(data);
        }
        //Random matrix
        double[,] getRandomMatrix(int length)
        {
            double[,] data = new double[length, length];
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i<length; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    data[i,j] = rand.Next(1,20);
                }
            }
            return data;
        }

        //Matrix from/to DataGridView
        public double[,] readDataFromGrid(DataGridView grid)
        {
            double[,] arr = new double[grid.ColumnCount,grid.ColumnCount];
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                for (int j = 0;j< grid.ColumnCount; j++)
                {
                    //arr[i, j] = Convert.ToDouble(grid[i,j].Value);
                    arr[i,j] = Convert.ToDouble(grid[j,i].Value);
                }
            }
            return arr;
        }
        public void writeDataToGrid(DataGridView grid)
        {
            grid.ColumnCount = n;
            grid.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[j, i].Value = matrix[i,j];
                }
            }
        }


        //To String
        public override string ToString()
        {
            string message="";
            for(int i = 0; i< matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    message += matrix[i,j].ToString()+", ";
                }
                message+= "\n";
            }
            return message.ToString();
        }
    }
}
