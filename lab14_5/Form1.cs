using System;
using System.IO;
using System.Windows.Forms;

namespace lab14_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();

            int a, b;
            a = hScrollBar1.Value;
            b = trackBar1.Value;

            double x, h;
            h = (double)numericUpDown1.Value;

            for(x = a; x < b; x += h)
            {
                ComputeAndWrite(x);
            }

            ComputeAndWrite(b);
        }

        private void ComputeAndWrite(double x)
        {
            double y = Math.Log(x + 1, 10) * Math.Sin(x);
            resultTextBox.Text += string.Format("{0:0.000}\t\t{1:0.000}", x, y);
            resultTextBox.Text += Environment.NewLine;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            a_label.Text = "a = " + hScrollBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            b_label.Text = "b = " + trackBar1.Value.ToString();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Сохранить в файл",
                Filter = "Текстовый файл (*.txt)|*.txt|"
                       + "Все файлы (*.*)|*.*"
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                File.WriteAllText(filename, resultTextBox.Text);
            }
        }
    }
}
