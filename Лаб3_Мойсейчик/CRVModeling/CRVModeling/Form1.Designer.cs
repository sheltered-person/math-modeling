namespace CRVModeling
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
            this.distributionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sampleVarianceLabel = new System.Windows.Forms.Label();
            this.sampleMeanLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.radio48Button = new System.Windows.Forms.RadioButton();
            this.radio192Button = new System.Windows.Forms.RadioButton();
            this.correlationLabel = new System.Windows.Forms.Label();
            this.sampleCorrelationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // distributionLabel
            // 
            this.distributionLabel.AutoSize = true;
            this.distributionLabel.Location = new System.Drawing.Point(43, 31);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Size = new System.Drawing.Size(179, 17);
            this.distributionLabel.TabIndex = 0;
            this.distributionLabel.Text = "Название распределения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мат ожидание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дисперсия:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(214, 67);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(28, 17);
            this.meanLabel.TabIndex = 3;
            this.meanLabel.Text = "0.0";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Location = new System.Drawing.Point(214, 100);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(28, 17);
            this.varianceLabel.TabIndex = 4;
            this.varianceLabel.Text = "1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выборочные значения";
            // 
            // sampleVarianceLabel
            // 
            this.sampleVarianceLabel.AutoSize = true;
            this.sampleVarianceLabel.Location = new System.Drawing.Point(214, 215);
            this.sampleVarianceLabel.Name = "sampleVarianceLabel";
            this.sampleVarianceLabel.Size = new System.Drawing.Size(28, 17);
            this.sampleVarianceLabel.TabIndex = 9;
            this.sampleVarianceLabel.Text = "1.0";
            // 
            // sampleMeanLabel
            // 
            this.sampleMeanLabel.AutoSize = true;
            this.sampleMeanLabel.Location = new System.Drawing.Point(214, 182);
            this.sampleMeanLabel.Name = "sampleMeanLabel";
            this.sampleMeanLabel.Size = new System.Drawing.Size(28, 17);
            this.sampleMeanLabel.TabIndex = 8;
            this.sampleMeanLabel.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дисперсия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Мат ожидание:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(478, 94);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(178, 28);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Следующее >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // radio48Button
            // 
            this.radio48Button.AutoSize = true;
            this.radio48Button.Location = new System.Drawing.Point(501, 136);
            this.radio48Button.Name = "radio48Button";
            this.radio48Button.Size = new System.Drawing.Size(45, 21);
            this.radio48Button.TabIndex = 11;
            this.radio48Button.TabStop = true;
            this.radio48Button.Text = "48";
            this.radio48Button.UseVisualStyleBackColor = true;
            this.radio48Button.CheckedChanged += new System.EventHandler(this.radio48Button_CheckedChanged);
            // 
            // radio192Button
            // 
            this.radio192Button.AutoSize = true;
            this.radio192Button.Location = new System.Drawing.Point(501, 163);
            this.radio192Button.Name = "radio192Button";
            this.radio192Button.Size = new System.Drawing.Size(53, 21);
            this.radio192Button.TabIndex = 12;
            this.radio192Button.TabStop = true;
            this.radio192Button.Text = "192";
            this.radio192Button.UseVisualStyleBackColor = true;
            this.radio192Button.CheckedChanged += new System.EventHandler(this.radio192Button_CheckedChanged);
            // 
            // correlationLabel
            // 
            this.correlationLabel.AutoSize = true;
            this.correlationLabel.Location = new System.Drawing.Point(80, 257);
            this.correlationLabel.Name = "correlationLabel";
            this.correlationLabel.Size = new System.Drawing.Size(357, 17);
            this.correlationLabel.TabIndex = 13;
            this.correlationLabel.Text = "Корреляция чётных и нечётных элементов выборки:";
            // 
            // sampleCorrelationLabel
            // 
            this.sampleCorrelationLabel.AutoSize = true;
            this.sampleCorrelationLabel.Location = new System.Drawing.Point(464, 256);
            this.sampleCorrelationLabel.Name = "sampleCorrelationLabel";
            this.sampleCorrelationLabel.Size = new System.Drawing.Size(28, 17);
            this.sampleCorrelationLabel.TabIndex = 14;
            this.sampleCorrelationLabel.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.sampleCorrelationLabel);
            this.Controls.Add(this.correlationLabel);
            this.Controls.Add(this.radio192Button);
            this.Controls.Add(this.radio48Button);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.sampleVarianceLabel);
            this.Controls.Add(this.sampleMeanLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distributionLabel);
            this.Name = "Form1";
            this.Text = "CRV Modeling App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sampleVarianceLabel;
        private System.Windows.Forms.Label sampleMeanLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RadioButton radio48Button;
        private System.Windows.Forms.RadioButton radio192Button;
        private System.Windows.Forms.Label correlationLabel;
        private System.Windows.Forms.Label sampleCorrelationLabel;
    }
}

