namespace Лабораторна__22
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.діяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найбільшеСередВідємнихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найменшеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.згенеруватиМатриціВипадковоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(66, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 63);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість чисел";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняToolStripMenuItem,
            this.діяToolStripMenuItem,
            this.згенеруватиМатриціВипадковоToolStripMenuItem,
            this.вихідToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // діяToolStripMenuItem
            // 
            this.діяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найбільшеСередВідємнихToolStripMenuItem,
            this.найменшеToolStripMenuItem});
            this.діяToolStripMenuItem.Name = "діяToolStripMenuItem";
            this.діяToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.діяToolStripMenuItem.Text = "Операції";
            // 
            // найбільшеСередВідємнихToolStripMenuItem
            // 
            this.найбільшеСередВідємнихToolStripMenuItem.Name = "найбільшеСередВідємнихToolStripMenuItem";
            this.найбільшеСередВідємнихToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.найбільшеСередВідємнихToolStripMenuItem.Text = "найбільше серед від’ємних";
            this.найбільшеСередВідємнихToolStripMenuItem.Click += new System.EventHandler(this.найбільшеСередВідємнихToolStripMenuItem_Click);
            // 
            // найменшеToolStripMenuItem
            // 
            this.найменшеToolStripMenuItem.Name = "найменшеToolStripMenuItem";
            this.найменшеToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.найменшеToolStripMenuItem.Text = "найменше серед додатних";
            this.найменшеToolStripMenuItem.Click += new System.EventHandler(this.найменшеToolStripMenuItem_Click);
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
            // 
            // завдання2ToolStripMenuItem
            // 
            this.завдання2ToolStripMenuItem.Name = "завдання2ToolStripMenuItem";
            this.завдання2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завдання2ToolStripMenuItem.Text = "Завдання 2";
            this.завдання2ToolStripMenuItem.Click += new System.EventHandler(this.завдання2ToolStripMenuItem_Click);
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
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(279, 44);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // згенеруватиМатриціВипадковоToolStripMenuItem
            // 
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Name = "згенеруватиМатриціВипадковоToolStripMenuItem";
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Text = "Згенерувати випадково";
            this.згенеруватиМатриціВипадковоToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиВипадковоToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem діяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найбільшеСередВідємнихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найменшеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem завдання1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиМатриціВипадковоToolStripMenuItem;
    }
}

