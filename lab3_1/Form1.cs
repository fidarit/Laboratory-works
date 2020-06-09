using System;
using System.Windows.Forms;

namespace lab3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double AB, AD, S, L, R, BD;
            if (double.TryParse(abInput.Text, out AB)
                && double.TryParse(adInput.Text, out AD))
            {
                BD = Math.Sqrt(AB * AB + AD * AD);
                R = BD / 2;

                S = Math.PI * R * R;
                L = 2 * Math.PI * R;

                resultLabel.Text = "L = " + string.Format("{0:0.00000}", L);
                MessageBox.Show("S = " + string.Format("{0:0.00000}", S), "Ваш результат");
            }
            else
            {
                resultLabel.Text = "Неправильные входные данные";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abInput.Clear();
            adInput.Clear();
            resultLabel.Text = "...";
        }
    }
}
