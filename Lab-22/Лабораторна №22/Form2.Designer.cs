namespace Лабораторна__22
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.завданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.згенеруватиМатриціВипадковоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицюАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицяBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(340, 49);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть розмірність квадратної матриці";
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AllowUserToDeleteRows = false;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.ColumnHeadersVisible = false;
            this.dataGridViewA.Location = new System.Drawing.Point(24, 103);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersVisible = false;
            this.dataGridViewA.RowHeadersWidth = 51;
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(208, 189);
            this.dataGridViewA.TabIndex = 6;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.ColumnHeadersVisible = false;
            this.dataGridViewB.Location = new System.Drawing.Point(306, 103);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersVisible = false;
            this.dataGridViewB.RowHeadersWidth = 20;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(208, 189);
            this.dataGridViewB.TabIndex = 7;
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.AllowUserToAddRows = false;
            this.dataGridViewC.AllowUserToDeleteRows = false;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.ColumnHeadersVisible = false;
            this.dataGridViewC.Location = new System.Drawing.Point(580, 103);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.RowHeadersVisible = false;
            this.dataGridViewC.RowHeadersWidth = 51;
            this.dataGridViewC.RowTemplate.Height = 24;
            this.dataGridViewC.Size = new System.Drawing.Size(208, 189);
            this.dataGridViewC.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "В";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "С";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обчислити результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // завданняToolStripMenuItem
            // 
            this.завданняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завдання1ToolStripMenuItem,
            this.завдання2ToolStripMenuItem,
            this.завдання3ToolStripMenuItem});
            this.завданняToolStripMenuItem.Name = "завданняToolStripMenuItem";
            this.завданняToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.завданняToolStripMenuItem.Text = "Завдання";
            // 
            // завдання1ToolStripMenuItem
            // 
            this.завдання1ToolStripMenuItem.Name = "завдання1ToolStripMenuItem";
            this.завдання1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завдання1ToolStripMenuItem.Text = "Завдання 1";
            this.завдання1ToolStripMenuItem.Click += new System.EventHandler(this.завдання1ToolStripMenuItem_Click);
            // 
            // завдання2ToolStripMenuItem
            // 
            this.завдання2ToolStripMenuItem.Name = "завдання2ToolStripMenuItem";
            this.завдання2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завдання2ToolStripMenuItem.Text = "Завдання 2";
            // 
            // завдання3ToolStripMenuItem
            // 
            this.завдання3ToolStripMenuItem.Name = "завдання3ToolStripMenuItem";
            this.завдання3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завдання3ToolStripMenuItem.Text = "Завдання 3";
            this.завдання3ToolStripMenuItem.Click += new System.EventHandler(this.завдання3ToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняToolStripMenuItem,
            this.згенеруватиМатриціВипадковоToolStripMenuItem,
            this.вихідToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // згенеруватиМатриціВипадковоToolStripMenuItem
            // 
            this.згенеруватиМатриціВипадковоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицюАToolStripMenuItem,
            this.матрицяBToolStripMenuItem,
            this.матрицяToolStripMenuItem});
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Name = "згенеруватиМатриціВипадковоToolStripMenuItem";
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Text = "Згенерувати випадково";
            // 
            // матрицюАToolStripMenuItem
            // 
            this.матрицюАToolStripMenuItem.Name = "матрицюАToolStripMenuItem";
            this.матрицюАToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матрицюАToolStripMenuItem.Text = "Матрицю А";
            this.матрицюАToolStripMenuItem.Click += new System.EventHandler(this.матрицюАToolStripMenuItem_Click);
            // 
            // матрицяBToolStripMenuItem
            // 
            this.матрицяBToolStripMenuItem.Name = "матрицяBToolStripMenuItem";
            this.матрицяBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матрицяBToolStripMenuItem.Text = "Матриця B";
            this.матрицяBToolStripMenuItem.Click += new System.EventHandler(this.матрицяBToolStripMenuItem_Click);
            // 
            // матрицяToolStripMenuItem
            // 
            this.матрицяToolStripMenuItem.Name = "матрицяToolStripMenuItem";
            this.матрицяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матрицяToolStripMenuItem.Text = "Матриця С";
            this.матрицяToolStripMenuItem.Click += new System.EventHandler(this.матрицяToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Завдання 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem завданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиМатриціВипадковоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицюАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицяBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицяToolStripMenuItem;
    }
}