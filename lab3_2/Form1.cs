﻿using System;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int a, b;
            a = aInput.Value;
            b = bInput.Value;

            double x, y, h;
            bool finished = false;
            h = (double)hInput.Value;
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

        private void aInput_Scroll(object sender, ScrollEventArgs e)
        {
            aOutput.Text = "a = " + aInput.Value.ToString();
        }

        private void bInput_Scroll(object sender, EventArgs e)
        {
            bOutput.Text = "b = " + bInput.Value.ToString();
        }
    }
}
