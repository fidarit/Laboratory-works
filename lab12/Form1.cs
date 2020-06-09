using System;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            double X, result;

            if (double.TryParse(inputTextBox.Text, out X))
            {
                result = 1;
                
                for(int i = 1; i <= 10; i++)
                {
                    result *= func(i, X);
                }

                resultTextBox.Text = result.ToString();
            }
            else
            {
                resultTextBox.Text = "Неправильный ввод";
            }
        }

        private double func(int n, double x)
        {
            return (double)n / Math.Pow(x, n);
        }
    }
}
