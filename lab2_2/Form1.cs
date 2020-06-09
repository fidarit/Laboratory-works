using System;
using System.Windows.Forms;

namespace lab_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            input1_textBox.Clear();
            input2_textBox.Clear();
            result_textBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void makeOperation_button_Click(object sender, EventArgs e)
        {
            double a, b;
            if(double.TryParse(input1_textBox.Text, out a)
                && double.TryParse(input2_textBox.Text, out b))
            {
                if (sum_radioButton.Checked)
                    result_textBox.Text = (a + b).ToString();
                else if(minus_radioButton.Checked)
                    result_textBox.Text = (a - b).ToString();
                else if(mult_radioButton.Checked)
                    result_textBox.Text = (a * b).ToString();
                else if (div_radioButton.Checked)
                    result_textBox.Text = (a / b).ToString();
                else
                    result_textBox.Text = "Не выбрана операция";
            }
            else
            {
                result_textBox.Text = "Неправильные входные данные";
            }
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(result_textBox.Text, out a))
            {
                if (sin_radioButton.Checked)
                    result_textBox.Text = Math.Sin(a).ToString();
                else if (cos_radioButton.Checked)
                    result_textBox.Text = Math.Cos(a).ToString();
                else if (sqrt_radioButton.Checked)
                    result_textBox.Text = Math.Sqrt(a).ToString();
                else
                    result_textBox.Text = "Не выбрана операция";
            }
            else
            {
                result_textBox.Text = "Поле результата не имеет числовых данных";
            }

        }
    }
}
