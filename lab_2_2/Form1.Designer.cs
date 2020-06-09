namespace lab_2_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.input1_textBox = new System.Windows.Forms.TextBox();
            this.input2_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.sqrt_radioButton = new System.Windows.Forms.RadioButton();
            this.cos_radioButton = new System.Windows.Forms.RadioButton();
            this.sin_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.makeOperation_button = new System.Windows.Forms.Button();
            this.div_radioButton = new System.Windows.Forms.RadioButton();
            this.mult_radioButton = new System.Windows.Forms.RadioButton();
            this.minus_radioButton = new System.Windows.Forms.RadioButton();
            this.sum_radioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные";
            // 
            // input1_textBox
            // 
            this.input1_textBox.Location = new System.Drawing.Point(12, 27);
            this.input1_textBox.Name = "input1_textBox";
            this.input1_textBox.Size = new System.Drawing.Size(80, 20);
            this.input1_textBox.TabIndex = 1;
            // 
            // input2_textBox
            // 
            this.input2_textBox.Location = new System.Drawing.Point(110, 27);
            this.input2_textBox.Name = "input2_textBox";
            this.input2_textBox.Size = new System.Drawing.Size(80, 20);
            this.input2_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(28, 100);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(150, 20);
            this.result_textBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.sqrt_radioButton);
            this.groupBox1.Controls.Add(this.cos_radioButton);
            this.groupBox1.Controls.Add(this.sin_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для результата";
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(26, 92);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(120, 23);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Вычислить";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // sqrt_radioButton
            // 
            this.sqrt_radioButton.AutoSize = true;
            this.sqrt_radioButton.Location = new System.Drawing.Point(7, 68);
            this.sqrt_radioButton.Name = "sqrt_radioButton";
            this.sqrt_radioButton.Size = new System.Drawing.Size(126, 17);
            this.sqrt_radioButton.TabIndex = 2;
            this.sqrt_radioButton.TabStop = true;
            this.sqrt_radioButton.Text = "Квадратный корень";
            this.sqrt_radioButton.UseVisualStyleBackColor = true;
            // 
            // cos_radioButton
            // 
            this.cos_radioButton.AutoSize = true;
            this.cos_radioButton.Location = new System.Drawing.Point(7, 44);
            this.cos_radioButton.Name = "cos_radioButton";
            this.cos_radioButton.Size = new System.Drawing.Size(42, 17);
            this.cos_radioButton.TabIndex = 1;
            this.cos_radioButton.TabStop = true;
            this.cos_radioButton.Text = "cos";
            this.cos_radioButton.UseVisualStyleBackColor = true;
            // 
            // sin_radioButton
            // 
            this.sin_radioButton.AutoSize = true;
            this.sin_radioButton.Location = new System.Drawing.Point(7, 20);
            this.sin_radioButton.Name = "sin_radioButton";
            this.sin_radioButton.Size = new System.Drawing.Size(38, 17);
            this.sin_radioButton.TabIndex = 0;
            this.sin_radioButton.TabStop = true;
            this.sin_radioButton.Text = "sin";
            this.sin_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.makeOperation_button);
            this.groupBox2.Controls.Add(this.div_radioButton);
            this.groupBox2.Controls.Add(this.mult_radioButton);
            this.groupBox2.Controls.Add(this.minus_radioButton);
            this.groupBox2.Controls.Add(this.sum_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 235);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Для исходных данных";
            // 
            // makeOperation_button
            // 
            this.makeOperation_button.Location = new System.Drawing.Point(15, 206);
            this.makeOperation_button.Name = "makeOperation_button";
            this.makeOperation_button.Size = new System.Drawing.Size(130, 23);
            this.makeOperation_button.TabIndex = 4;
            this.makeOperation_button.Text = "Выполнить операцию";
            this.makeOperation_button.UseVisualStyleBackColor = true;
            this.makeOperation_button.Click += new System.EventHandler(this.makeOperation_button_Click);
            // 
            // div_radioButton
            // 
            this.div_radioButton.AutoSize = true;
            this.div_radioButton.Location = new System.Drawing.Point(6, 134);
            this.div_radioButton.Name = "div_radioButton";
            this.div_radioButton.Size = new System.Drawing.Size(79, 17);
            this.div_radioButton.TabIndex = 3;
            this.div_radioButton.TabStop = true;
            this.div_radioButton.Text = "Разделить";
            this.div_radioButton.UseVisualStyleBackColor = true;
            // 
            // mult_radioButton
            // 
            this.mult_radioButton.AutoSize = true;
            this.mult_radioButton.Location = new System.Drawing.Point(6, 101);
            this.mult_radioButton.Name = "mult_radioButton";
            this.mult_radioButton.Size = new System.Drawing.Size(78, 17);
            this.mult_radioButton.TabIndex = 2;
            this.mult_radioButton.TabStop = true;
            this.mult_radioButton.Text = "Умножить";
            this.mult_radioButton.UseVisualStyleBackColor = true;
            // 
            // minus_radioButton
            // 
            this.minus_radioButton.AutoSize = true;
            this.minus_radioButton.Location = new System.Drawing.Point(6, 69);
            this.minus_radioButton.Name = "minus_radioButton";
            this.minus_radioButton.Size = new System.Drawing.Size(68, 17);
            this.minus_radioButton.TabIndex = 1;
            this.minus_radioButton.TabStop = true;
            this.minus_radioButton.Text = "Вычесть";
            this.minus_radioButton.UseVisualStyleBackColor = true;
            // 
            // sum_radioButton
            // 
            this.sum_radioButton.AutoSize = true;
            this.sum_radioButton.Location = new System.Drawing.Point(6, 34);
            this.sum_radioButton.Name = "sum_radioButton";
            this.sum_radioButton.Size = new System.Drawing.Size(69, 17);
            this.sum_radioButton.TabIndex = 0;
            this.sum_radioButton.TabStop = true;
            this.sum_radioButton.Text = "Сложить";
            this.sum_radioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(38, 253);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Очистить всё";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(227, 253);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 288);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input2_textBox);
            this.Controls.Add(this.input1_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Микрокалькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1_textBox;
        private System.Windows.Forms.TextBox input2_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.RadioButton sqrt_radioButton;
        private System.Windows.Forms.RadioButton cos_radioButton;
        private System.Windows.Forms.RadioButton sin_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button makeOperation_button;
        private System.Windows.Forms.RadioButton div_radioButton;
        private System.Windows.Forms.RadioButton mult_radioButton;
        private System.Windows.Forms.RadioButton minus_radioButton;
        private System.Windows.Forms.RadioButton sum_radioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

