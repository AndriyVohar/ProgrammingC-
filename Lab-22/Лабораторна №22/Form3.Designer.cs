namespace Лабораторна__22
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чиЄДанаФункціяСпадноюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнєЗначенняФункціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найбільшеВідємнеЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найменшеДодатнеЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завданняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завдання3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняToolStripMenuItem,
            this.операціїToolStripMenuItem,
            this.вихідToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чиЄДанаФункціяСпадноюToolStripMenuItem,
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem,
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem,
            this.середнєЗначенняФункціїToolStripMenuItem,
            this.найбільшеВідємнеЗначенняToolStripMenuItem,
            this.найменшеДодатнеЗначенняToolStripMenuItem,
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem,
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem,
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem,
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // чиЄДанаФункціяСпадноюToolStripMenuItem
            // 
            this.чиЄДанаФункціяСпадноюToolStripMenuItem.Name = "чиЄДанаФункціяСпадноюToolStripMenuItem";
            this.чиЄДанаФункціяСпадноюToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.чиЄДанаФункціяСпадноюToolStripMenuItem.Text = "чи є спадною та знайти найбільше та найменше значення";
            this.чиЄДанаФункціяСпадноюToolStripMenuItem.Click += new System.EventHandler(this.чиЄДанаФункціяСпадноюToolStripMenuItem_Click);
            // 
            // чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem
            // 
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Name = "чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem";
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Text = "чи перетинає графік функції вісь ОХ";
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Click += new System.EventHandler(this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem_Click);
            // 
            // вЯкомуКвадрантіБільшеТочокToolStripMenuItem
            // 
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Name = "вЯкомуКвадрантіБільшеТочокToolStripMenuItem";
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Text = "в якому квадранті більше точок";
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Click += new System.EventHandler(this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem_Click);
            // 
            // середнєЗначенняФункціїToolStripMenuItem
            // 
            this.середнєЗначенняФункціїToolStripMenuItem.Name = "середнєЗначенняФункціїToolStripMenuItem";
            this.середнєЗначенняФункціїToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.середнєЗначенняФункціїToolStripMenuItem.Text = "«середнє значення» функції";
            this.середнєЗначенняФункціїToolStripMenuItem.Click += new System.EventHandler(this.середнєЗначенняФункціїToolStripMenuItem_Click);
            // 
            // найбільшеВідємнеЗначенняToolStripMenuItem
            // 
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Name = "найбільшеВідємнеЗначенняToolStripMenuItem";
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Text = "найбільше від’ємне значення";
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Click += new System.EventHandler(this.найбільшеВідємнеЗначенняToolStripMenuItem_Click);
            // 
            // найменшеДодатнеЗначенняToolStripMenuItem
            // 
            this.найменшеДодатнеЗначенняToolStripMenuItem.Name = "найменшеДодатнеЗначенняToolStripMenuItem";
            this.найменшеДодатнеЗначенняToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.найменшеДодатнеЗначенняToolStripMenuItem.Text = "найменше додатне значення";
            this.найменшеДодатнеЗначенняToolStripMenuItem.Click += new System.EventHandler(this.найменшеДодатнеЗначенняToolStripMenuItem_Click);
            // 
            // чиЄДанаФункціяЗростаючоюToolStripMenuItem
            // 
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem.Name = "чиЄДанаФункціяЗростаючоюToolStripMenuItem";
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem.Text = "чи є зростаючою та знайти найбільше та найменше значення";
            this.чиЄДанаФункціяЗростаючоюToolStripMenuItem.Click += new System.EventHandler(this.чиЄДанаФункціяЗростаючоюToolStripMenuItem_Click);
            // 
            // наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem
            // 
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Name = "наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem";
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Text = "наближено знайти точку перетину графіка функції і віссю ОХ";
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Click += new System.EventHandler(this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem_Click);
            // 
            // відобразитиСиметричноВідносноОсіОХToolStripMenuItem
            // 
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Name = "відобразитиСиметричноВідносноОсіОХToolStripMenuItem";
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Text = "відобразити симетрично відносно осі ОХ";
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Click += new System.EventHandler(this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem_Click);
            // 
            // відобразитиСиметричноВідносноОсіОУToolStripMenuItem
            // 
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Name = "відобразитиСиметричноВідносноОсіОУToolStripMenuItem";
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Size = new System.Drawing.Size(526, 26);
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Text = "відобразити симетрично відносно осі ОУ";
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Click += new System.EventHandler(this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem_Click);
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
            this.завдання2ToolStripMenuItem.Click += new System.EventHandler(this.завдання2ToolStripMenuItem_Click);
            // 
            // завдання3ToolStripMenuItem
            // 
            this.завдання3ToolStripMenuItem.Name = "завдання3ToolStripMenuItem";
            this.завдання3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.завдання3ToolStripMenuItem.Text = "Завдання 3";
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(283, 77);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(585, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(95, 77);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownA.TabIndex = 6;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(57, 79);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(15, 16);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(57, 107);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(15, 16);
            this.labelB.TabIndex = 9;
            this.labelB.Text = "b";
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(95, 105);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownB.TabIndex = 8;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(39, 135);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(50, 16);
            this.labelInterval.TabIndex = 11;
            this.labelInterval.Text = "Interval";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.DecimalPlaces = 1;
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInterval.Location = new System.Drawing.Point(95, 133);
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownInterval.TabIndex = 10;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 527);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Завдання 3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завданняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завдання3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чиЄДанаФункціяСпадноюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЯкомуКвадрантіБільшеТочокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнєЗначенняФункціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найбільшеВідємнеЗначенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найменшеДодатнеЗначенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чиЄДанаФункціяЗростаючоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відобразитиСиметричноВідносноОсіОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відобразитиСиметричноВідносноОсіОУToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
    }
}