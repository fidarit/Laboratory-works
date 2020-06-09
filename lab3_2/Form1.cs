using System;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int a, b;
            a = hScrollBar1.Value;
            b = trackBar1.Value;

            double x, y, h;
            bool finished = false;
            h = (double)numericUpDown1.Value;
            x = a;

            do
            {
                y = Math.Log(x + 1, 10) * Math.Sin(x);
                textBox1.Text += "  " + string.Format("{0:0.0000}", x) + "\t\t\t"
                    + string.Format("{0:0.0000}", y) + Environment.NewLine;
                x += h;

                if(x >= b && !finished)
                {
                    x = b;
                    finished = true;
                }
            }
            while (x <= b);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            a_label.Text = "a = " + hScrollBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            b_label.Text = "b = " + trackBar1.Value.ToString();
        }
    }
}
