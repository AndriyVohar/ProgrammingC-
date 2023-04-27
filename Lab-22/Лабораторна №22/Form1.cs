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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount=1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }
        private void найбільшеСередВідємнихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayFromGrid maxFromNegative = new ArrayFromGrid(dataGridView1);
            maxFromNegative.maxFromNegativeNumbers();
        }

        private void найменшеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayFromGrid minFromPositive = new ArrayFromGrid(dataGridView1);
            minFromPositive.minFromPositiveNumbers();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void завдання2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
        private void завдання3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
        private void згенеруватиВипадковоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayFromGrid arr = new ArrayFromGrid(dataGridView1.ColumnCount);
            arr.writeDataToGrid(dataGridView1);
        }
    }
}
