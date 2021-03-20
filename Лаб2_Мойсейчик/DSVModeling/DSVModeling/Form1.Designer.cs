namespace DSVModeling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.sampleMeanLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.sampleVarianceLabel = new System.Windows.Forms.Label();
            this.skewnessLabel = new System.Windows.Forms.Label();
            this.sampleSkewnessLabel = new System.Windows.Forms.Label();
            this.kurtosisLabel = new System.Windows.Forms.Label();
            this.sampleKurtosisLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.funcChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcChart)).BeginInit();
            this.SuspendLayout();
            // 
            // distributionLabel
            // 
            this.distributionLabel.AutoSize = true;
            this.distributionLabel.Location = new System.Drawing.Point(24, 28);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Size = new System.Drawing.Size(46, 17);
            this.distributionLabel.TabIndex = 0;
            this.distributionLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Среднее:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выборочное среднее:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дисперсия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выборочная дисперсия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Асимметрия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Выборочная асимметрия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Эксцесс:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Выборочный эксцесс:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(220, 66);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(46, 17);
            this.meanLabel.TabIndex = 9;
            this.meanLabel.Text = "label9";
            // 
            // sampleMeanLabel
            // 
            this.sampleMeanLabel.AutoSize = true;
            this.sampleMeanLabel.Location = new System.Drawing.Point(220, 93);
            this.sampleMeanLabel.Name = "sampleMeanLabel";
            this.sampleMeanLabel.Size = new System.Drawing.Size(54, 17);
            this.sampleMeanLabel.TabIndex = 10;
            this.sampleMeanLabel.Text = "label10";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Location = new System.Drawing.Point(220, 141);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(54, 17);
            this.varianceLabel.TabIndex = 11;
            this.varianceLabel.Text = "label11";
            // 
            // sampleVarianceLabel
            // 
            this.sampleVarianceLabel.AutoSize = true;
            this.sampleVarianceLabel.Location = new System.Drawing.Point(220, 171);
            this.sampleVarianceLabel.Name = "sampleVarianceLabel";
            this.sampleVarianceLabel.Size = new System.Drawing.Size(54, 17);
            this.sampleVarianceLabel.TabIndex = 12;
            this.sampleVarianceLabel.Text = "label12";
            // 
            // skewnessLabel
            // 
            this.skewnessLabel.AutoSize = true;
            this.skewnessLabel.Location = new System.Drawing.Point(220, 216);
            this.skewnessLabel.Name = "skewnessLabel";
            this.skewnessLabel.Size = new System.Drawing.Size(54, 17);
            this.skewnessLabel.TabIndex = 13;
            this.skewnessLabel.Text = "label13";
            // 
            // sampleSkewnessLabel
            // 
            this.sampleSkewnessLabel.AutoSize = true;
            this.sampleSkewnessLabel.Location = new System.Drawing.Point(220, 244);
            this.sampleSkewnessLabel.Name = "sampleSkewnessLabel";
            this.sampleSkewnessLabel.Size = new System.Drawing.Size(54, 17);
            this.sampleSkewnessLabel.TabIndex = 14;
            this.sampleSkewnessLabel.Text = "label14";
            // 
            // kurtosisLabel
            // 
            this.kurtosisLabel.AutoSize = true;
            this.kurtosisLabel.Location = new System.Drawing.Point(220, 283);
            this.kurtosisLabel.Name = "kurtosisLabel";
            this.kurtosisLabel.Size = new System.Drawing.Size(54, 17);
            this.kurtosisLabel.TabIndex = 15;
            this.kurtosisLabel.Text = "label15";
            // 
            // sampleKurtosisLabel
            // 
            this.sampleKurtosisLabel.AutoSize = true;
            this.sampleKurtosisLabel.Location = new System.Drawing.Point(220, 314);
            this.sampleKurtosisLabel.Name = "sampleKurtosisLabel";
            this.sampleKurtosisLabel.Size = new System.Drawing.Size(54, 17);
            this.sampleKurtosisLabel.TabIndex = 16;
            this.sampleKurtosisLabel.Text = "label16";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(844, 23);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(161, 26);
            this.runButton.TabIndex = 17;
            this.runButton.Text = "Тестировать >>";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Location = new System.Drawing.Point(400, 66);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(274, 265);
            this.chart.TabIndex = 18;
            this.chart.Text = "chart1";
            // 
            // funcChart
            // 
            chartArea4.Name = "ChartArea1";
            this.funcChart.ChartAreas.Add(chartArea4);
            this.funcChart.Location = new System.Drawing.Point(717, 66);
            this.funcChart.Name = "funcChart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.funcChart.Series.Add(series4);
            this.funcChart.Size = new System.Drawing.Size(288, 265);
            this.funcChart.TabIndex = 19;
            this.funcChart.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(400, 338);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 34);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Гистограмма выборки и теоретическое распределение вероятностей";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(717, 338);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 34);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Эмпирическая (жёлтый) и теоретическая (синий) функция распределения";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Критерий Хи-квадрата:";
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Location = new System.Drawing.Point(220, 354);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(54, 17);
            this.chiLabel.TabIndex = 23;
            this.chiLabel.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 399);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.funcChart);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.sampleKurtosisLabel);
            this.Controls.Add(this.kurtosisLabel);
            this.Controls.Add(this.sampleSkewnessLabel);
            this.Controls.Add(this.skewnessLabel);
            this.Controls.Add(this.sampleVarianceLabel);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.sampleMeanLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distributionLabel);
            this.Name = "Form1";
            this.Text = "Моделирование ДСВ";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label sampleMeanLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label sampleVarianceLabel;
        private System.Windows.Forms.Label skewnessLabel;
        private System.Windows.Forms.Label sampleSkewnessLabel;
        private System.Windows.Forms.Label kurtosisLabel;
        private System.Windows.Forms.Label sampleKurtosisLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart funcChart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label chiLabel;
    }
}

