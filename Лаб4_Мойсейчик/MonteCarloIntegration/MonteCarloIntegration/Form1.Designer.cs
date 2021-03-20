namespace MonteCarloIntegration
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.integralPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.trueResultLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radio100Button = new System.Windows.Forms.RadioButton();
            this.radio500Button = new System.Windows.Forms.RadioButton();
            this.radio1000Button = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(399, 76);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(391, 330);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Распределение выборки из 10000 вычислений";
            this.chart.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Численное интегрирование методом Монте-Карло";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Полученное значение:";
            // 
            // integralPictureBox
            // 
            this.integralPictureBox.Location = new System.Drawing.Point(71, 76);
            this.integralPictureBox.Name = "integralPictureBox";
            this.integralPictureBox.Size = new System.Drawing.Size(246, 80);
            this.integralPictureBox.TabIndex = 3;
            this.integralPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ожидаемый результат:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(252, 184);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(28, 17);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0.0";
            // 
            // trueResultLabel
            // 
            this.trueResultLabel.AutoSize = true;
            this.trueResultLabel.Location = new System.Drawing.Point(252, 218);
            this.trueResultLabel.Name = "trueResultLabel";
            this.trueResultLabel.Size = new System.Drawing.Size(28, 17);
            this.trueResultLabel.TabIndex = 6;
            this.trueResultLabel.Text = "0.0";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(399, 32);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(391, 27);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Следующий интеграл >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Число точек в области:";
            // 
            // radio100Button
            // 
            this.radio100Button.AutoSize = true;
            this.radio100Button.Checked = true;
            this.radio100Button.Location = new System.Drawing.Point(151, 281);
            this.radio100Button.Name = "radio100Button";
            this.radio100Button.Size = new System.Drawing.Size(53, 21);
            this.radio100Button.TabIndex = 9;
            this.radio100Button.TabStop = true;
            this.radio100Button.Text = "100";
            this.radio100Button.UseVisualStyleBackColor = true;
            this.radio100Button.CheckedChanged += new System.EventHandler(this.radio100Button_CheckedChanged);
            // 
            // radio500Button
            // 
            this.radio500Button.AutoSize = true;
            this.radio500Button.Location = new System.Drawing.Point(151, 308);
            this.radio500Button.Name = "radio500Button";
            this.radio500Button.Size = new System.Drawing.Size(53, 21);
            this.radio500Button.TabIndex = 10;
            this.radio500Button.Text = "500";
            this.radio500Button.UseVisualStyleBackColor = true;
            this.radio500Button.CheckedChanged += new System.EventHandler(this.radio500Button_CheckedChanged);
            // 
            // radio1000Button
            // 
            this.radio1000Button.AutoSize = true;
            this.radio1000Button.Location = new System.Drawing.Point(151, 335);
            this.radio1000Button.Name = "radio1000Button";
            this.radio1000Button.Size = new System.Drawing.Size(61, 21);
            this.radio1000Button.TabIndex = 11;
            this.radio1000Button.Text = "1000";
            this.radio1000Button.UseVisualStyleBackColor = true;
            this.radio1000Button.CheckedChanged += new System.EventHandler(this.radio1000Button_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 428);
            this.Controls.Add(this.radio1000Button);
            this.Controls.Add(this.radio500Button);
            this.Controls.Add(this.radio100Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.trueResultLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.integralPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox integralPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label trueResultLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio100Button;
        private System.Windows.Forms.RadioButton radio500Button;
        private System.Windows.Forms.RadioButton radio1000Button;
    }
}

