namespace exec
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExtractK = new System.Windows.Forms.Button();
            this.textEps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPlusK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDay = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textN0 = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDay,
            this.columnError});
            this.dataGrid.Location = new System.Drawing.Point(0, -1);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(243, 177);
            this.dataGrid.TabIndex = 0;
            // 
            // columnDay
            // 
            this.columnDay.Frozen = true;
            this.columnDay.HeaderText = "День";
            this.columnDay.Name = "columnDay";
            // 
            // columnError
            // 
            this.columnError.Frozen = true;
            this.columnError.HeaderText = "Ошибок";
            this.columnError.Name = "columnError";
            // 
            // buttonExtractK
            // 
            this.buttonExtractK.Location = new System.Drawing.Point(304, 70);
            this.buttonExtractK.Name = "buttonExtractK";
            this.buttonExtractK.Size = new System.Drawing.Size(99, 23);
            this.buttonExtractK.TabIndex = 1;
            this.buttonExtractK.Text = "Найти K и N0";
            this.buttonExtractK.UseVisualStyleBackColor = true;
            this.buttonExtractK.Click += new System.EventHandler(this.buttonExtractK_Click);
            // 
            // textEps
            // 
            this.textEps.Location = new System.Drawing.Point(333, 10);
            this.textEps.Name = "textEps";
            this.textEps.Size = new System.Drawing.Size(100, 20);
            this.textEps.TabIndex = 2;
            this.textEps.Text = "0,0001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Эпсилон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "K:";
            // 
            // textK
            // 
            this.textK.Location = new System.Drawing.Point(276, 111);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(100, 20);
            this.textK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Приращение K:";
            // 
            // textPlusK
            // 
            this.textPlusK.Location = new System.Drawing.Point(333, 35);
            this.textPlusK.Name = "textPlusK";
            this.textPlusK.Size = new System.Drawing.Size(100, 20);
            this.textPlusK.TabIndex = 7;
            this.textPlusK.Text = "0,00001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество дней:";
            // 
            // textDay
            // 
            this.textDay.Location = new System.Drawing.Point(115, 195);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(40, 20);
            this.textDay.TabIndex = 9;
            this.textDay.Text = "7";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(180, 193);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(92, 23);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "N0:";
            // 
            // textN0
            // 
            this.textN0.Location = new System.Drawing.Point(276, 136);
            this.textN0.Name = "textN0";
            this.textN0.Size = new System.Drawing.Size(100, 20);
            this.textN0.TabIndex = 12;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(16, 255);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "Ошибка";
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.Blue;
            series2.Name = "Модель Джелинского-Моранды";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.LawnGreen;
            series3.Legend = "Legend1";
            series3.Name = "Невязка Джелинского-Моранды";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Квадрат невязки Джелинского-Моранды";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(739, 421);
            this.chart.TabIndex = 13;
            this.chart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Сумма квадратов невязок Джелинского-Моранды:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(645, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(645, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сумма квадратов невязок МНК:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(625, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "МНК невязки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Дж-мр невязки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(499, 10);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "невязки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "квадраты оных";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(761, 255);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Ошибка";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "МНК";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.Name = "Невязка МНК";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Квадрат невязки МНК";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(592, 403);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(840, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "A:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(840, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "B:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(863, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(863, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 717);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textN0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPlusK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEps);
            this.Controls.Add(this.buttonExtractK);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnError;
        private System.Windows.Forms.Button buttonExtractK;
        private System.Windows.Forms.TextBox textEps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPlusK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textN0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

