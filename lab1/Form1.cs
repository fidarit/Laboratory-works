using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
