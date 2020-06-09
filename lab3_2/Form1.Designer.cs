namespace lab3_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aOutput = new System.Windows.Forms.Label();
            this.aInput = new System.Windows.Forms.HScrollBar();
            this.bInput = new System.Windows.Forms.TrackBar();
            this.bOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hInput = new System.Windows.Forms.NumericUpDown();
            this.computeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица значений функции y = lg(x + 1) * sin x";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(233, 273);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // aOutput
            // 
            this.aOutput.AutoSize = true;
            this.aOutput.Location = new System.Drawing.Point(261, 79);
            this.aOutput.Name = "aOutput";
            this.aOutput.Size = new System.Drawing.Size(31, 13);
            this.aOutput.TabIndex = 4;
            this.aOutput.Text = "a = 5";
            // 
            // aInput
            // 
            this.aInput.LargeChange = 1;
            this.aInput.Location = new System.Drawing.Point(264, 53);
            this.aInput.Maximum = 15;
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(199, 17);
            this.aInput.TabIndex = 5;
            this.aInput.Value = 5;
            this.aInput.Scroll += new System.Windows.Forms.ScrollEventHandler(this.aInput_Scroll);
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(264, 136);
            this.bInput.Maximum = 30;
            this.bInput.Minimum = 15;
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(196, 45);
            this.bInput.TabIndex = 6;
            this.bInput.Value = 25;
            this.bInput.Scroll += new System.EventHandler(this.bInput_Scroll);
            // 
            // bOutput
            // 
            this.bOutput.AutoSize = true;
            this.bOutput.Location = new System.Drawing.Point(261, 184);
            this.bOutput.Name = "bOutput";
            this.bOutput.Size = new System.Drawing.Size(37, 13);
            this.bOutput.TabIndex = 7;
            this.bOutput.Text = "b = 25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "h = ";
            // 
            // hInput
            // 
            this.hInput.DecimalPlaces = 1;
            this.hInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hInput.Location = new System.Drawing.Point(295, 217);
            this.hInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hInput.Name = "hInput";
            this.hInput.Size = new System.Drawing.Size(120, 20);
            this.hInput.TabIndex = 9;
            this.hInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(267, 303);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(75, 23);
            this.computeButton.TabIndex = 10;
            this.computeButton.Text = "Построить";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(385, 303);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 338);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.hInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bOutput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.aOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Лаб №3_2";
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aOutput;
        private System.Windows.Forms.HScrollBar aInput;
        private System.Windows.Forms.TrackBar bInput;
        private System.Windows.Forms.Label bOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown hInput;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

