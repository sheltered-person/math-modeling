namespace BSVModeling
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.methodLabel = new System.Windows.Forms.Label();
            this.a100Label = new System.Windows.Forms.Label();
            this.a900Label = new System.Windows.Forms.Label();
            this.a1000Label = new System.Windows.Forms.Label();
            this.element100Label = new System.Windows.Forms.Label();
            this.element900Label = new System.Windows.Forms.Label();
            this.element1000Label = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dispersionPatternBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gmmTestLabel = new System.Windows.Forms.Label();
            this.covariationLabel = new System.Windows.Forms.Label();
            this.uniOfTwoTestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispersionPatternBox)).BeginInit();
            this.SuspendLayout();
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(36, 31);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(282, 17);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Мультипликативный конгруэнтный метод";
            // 
            // a100Label
            // 
            this.a100Label.AutoSize = true;
            this.a100Label.Location = new System.Drawing.Point(75, 69);
            this.a100Label.Name = "a100Label";
            this.a100Label.Size = new System.Drawing.Size(97, 17);
            this.a100Label.TabIndex = 1;
            this.a100Label.Text = "Элемент 100:";
            // 
            // a900Label
            // 
            this.a900Label.AutoSize = true;
            this.a900Label.Location = new System.Drawing.Point(75, 101);
            this.a900Label.Name = "a900Label";
            this.a900Label.Size = new System.Drawing.Size(97, 17);
            this.a900Label.TabIndex = 2;
            this.a900Label.Text = "Элемент 900:";
            // 
            // a1000Label
            // 
            this.a1000Label.AutoSize = true;
            this.a1000Label.Location = new System.Drawing.Point(75, 133);
            this.a1000Label.Name = "a1000Label";
            this.a1000Label.Size = new System.Drawing.Size(105, 17);
            this.a1000Label.TabIndex = 3;
            this.a1000Label.Text = "Элемент 1000:";
            // 
            // element100Label
            // 
            this.element100Label.AutoSize = true;
            this.element100Label.Location = new System.Drawing.Point(196, 69);
            this.element100Label.Name = "element100Label";
            this.element100Label.Size = new System.Drawing.Size(0, 17);
            this.element100Label.TabIndex = 4;
            // 
            // element900Label
            // 
            this.element900Label.AutoSize = true;
            this.element900Label.Location = new System.Drawing.Point(196, 101);
            this.element900Label.Name = "element900Label";
            this.element900Label.Size = new System.Drawing.Size(0, 17);
            this.element900Label.TabIndex = 5;
            // 
            // element1000Label
            // 
            this.element1000Label.AutoSize = true;
            this.element1000Label.Location = new System.Drawing.Point(196, 133);
            this.element1000Label.Name = "element1000Label";
            this.element1000Label.Size = new System.Drawing.Size(0, 17);
            this.element1000Label.TabIndex = 6;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(377, 24);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(131, 31);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Тестировать >>";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Location = new System.Drawing.Point(39, 191);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(211, 210);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // dispersionPatternBox
            // 
            this.dispersionPatternBox.Location = new System.Drawing.Point(291, 191);
            this.dispersionPatternBox.Name = "dispersionPatternBox";
            this.dispersionPatternBox.Size = new System.Drawing.Size(217, 210);
            this.dispersionPatternBox.TabIndex = 9;
            this.dispersionPatternBox.TabStop = false;
            this.dispersionPatternBox.Visible = false;
            this.dispersionPatternBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dispersionPatternBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тест совпадения моментов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тест ковариация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тест равномерное двумерное распеделение:";
            // 
            // gmmTestLabel
            // 
            this.gmmTestLabel.AutoSize = true;
            this.gmmTestLabel.Location = new System.Drawing.Point(422, 427);
            this.gmmTestLabel.Name = "gmmTestLabel";
            this.gmmTestLabel.Size = new System.Drawing.Size(0, 17);
            this.gmmTestLabel.TabIndex = 13;
            // 
            // covariationLabel
            // 
            this.covariationLabel.AutoSize = true;
            this.covariationLabel.Location = new System.Drawing.Point(422, 447);
            this.covariationLabel.Name = "covariationLabel";
            this.covariationLabel.Size = new System.Drawing.Size(0, 17);
            this.covariationLabel.TabIndex = 14;
            // 
            // uniOfTwoTestLabel
            // 
            this.uniOfTwoTestLabel.AutoSize = true;
            this.uniOfTwoTestLabel.Location = new System.Drawing.Point(422, 468);
            this.uniOfTwoTestLabel.Name = "uniOfTwoTestLabel";
            this.uniOfTwoTestLabel.Size = new System.Drawing.Size(0, 17);
            this.uniOfTwoTestLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 505);
            this.Controls.Add(this.uniOfTwoTestLabel);
            this.Controls.Add(this.covariationLabel);
            this.Controls.Add(this.gmmTestLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dispersionPatternBox);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.element1000Label);
            this.Controls.Add(this.element900Label);
            this.Controls.Add(this.element100Label);
            this.Controls.Add(this.a1000Label);
            this.Controls.Add(this.a900Label);
            this.Controls.Add(this.a100Label);
            this.Controls.Add(this.methodLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Моделирование БСВ";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispersionPatternBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label a100Label;
        private System.Windows.Forms.Label a900Label;
        private System.Windows.Forms.Label a1000Label;
        private System.Windows.Forms.Label element100Label;
        private System.Windows.Forms.Label element900Label;
        private System.Windows.Forms.Label element1000Label;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox dispersionPatternBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gmmTestLabel;
        private System.Windows.Forms.Label covariationLabel;
        private System.Windows.Forms.Label uniOfTwoTestLabel;
    }
}

