namespace lab13
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
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grayButton = new System.Windows.Forms.Button();
            this.sobelButton = new System.Windows.Forms.Button();
            this.thresholdInput = new System.Windows.Forms.NumericUpDown();
            this.reloadImgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdInput)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(575, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(656, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 284);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // grayButton
            // 
            this.grayButton.Location = new System.Drawing.Point(272, 12);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(103, 23);
            this.grayButton.TabIndex = 3;
            this.grayButton.Text = "Градация серого";
            this.grayButton.UseVisualStyleBackColor = true;
            this.grayButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // sobelButton
            // 
            this.sobelButton.Location = new System.Drawing.Point(12, 12);
            this.sobelButton.Name = "sobelButton";
            this.sobelButton.Size = new System.Drawing.Size(112, 23);
            this.sobelButton.TabIndex = 4;
            this.sobelButton.Text = "Выделить границы";
            this.sobelButton.UseVisualStyleBackColor = true;
            this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
            // 
            // thresholdInput
            // 
            this.thresholdInput.Location = new System.Drawing.Point(130, 15);
            this.thresholdInput.Name = "thresholdInput";
            this.thresholdInput.Size = new System.Drawing.Size(120, 20);
            this.thresholdInput.TabIndex = 6;
            this.thresholdInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reloadImgButton
            // 
            this.reloadImgButton.Location = new System.Drawing.Point(381, 12);
            this.reloadImgButton.Name = "reloadImgButton";
            this.reloadImgButton.Size = new System.Drawing.Size(188, 23);
            this.reloadImgButton.TabIndex = 7;
            this.reloadImgButton.Text = "Вернуть исходное изображение";
            this.reloadImgButton.UseVisualStyleBackColor = true;
            this.reloadImgButton.Click += new System.EventHandler(this.reloadImgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 337);
            this.Controls.Add(this.reloadImgButton);
            this.Controls.Add(this.thresholdInput);
            this.Controls.Add(this.sobelButton);
            this.Controls.Add(this.grayButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Лаб №13";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button sobelButton;
        private System.Windows.Forms.NumericUpDown thresholdInput;
        private System.Windows.Forms.Button reloadImgButton;
    }
}

