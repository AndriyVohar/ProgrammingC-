using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна__22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewA.ColumnCount = 1;
            dataGridViewA.RowCount = 1;
            dataGridViewB.ColumnCount = 1;
            dataGridViewB.RowCount = 1;
            dataGridViewC.ColumnCount = 1;
            dataGridViewC.RowCount = 1;
        }

        private void завдання1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
        private void завдання3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewA.ColumnCount = (int)numericUpDown1.Value;
            dataGridViewA.RowCount = (int)numericUpDown1.Value;
            dataGridViewB.ColumnCount = (int)numericUpDown1.Value;
            dataGridViewB.RowCount = (int)numericUpDown1.Value;
            dataGridViewC.ColumnCount = (int)numericUpDown1.Value;
            dataGridViewC.RowCount = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix matrixA = new Matrix(dataGridViewA);
            Matrix matrixB = new Matrix(dataGridViewB);
            Matrix matrixC = new Matrix(dataGridViewC);
            Matrix matrixResult = matrixA + matrixB + matrixC;
            MessageBox.Show(matrixResult.ToString());
            //double[,] data = { { 1, 2, 3,4 }, { 1, 2, 3,4 }, { 1, 2, 3,4 },{1,2,3,4} };
            //MessageBox.Show((data.GetUpperBound(data.Rank - 1) + 1).ToString());
        }

        private void матрицюАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matrix matr = new Matrix(dataGridViewA.ColumnCount);
            matr.writeDataToGrid(dataGridViewA);
        }

        private void матрицяBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matrix matr = new Matrix(dataGridViewB.ColumnCount);
            matr.writeDataToGrid(dataGridViewB);
        }

        private void матрицяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matrix matr = new Matrix(dataGridViewC.ColumnCount);
            matr.writeDataToGrid(dataGridViewC);
        }
    }
}
