using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    label2.Text = "Оба флажка выбраны";
                else
                    label2.Text = "Выбран первый флажок";
            }
            else if (checkBox2.Checked)
                label2.Text = "Выбран второй флажок";
            else
                label2.Text = "Ни один из флажков не выбран";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Выбран";
            radioButton2.Text = "Не выбран";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Text = "Выбран";
            radioButton1.Text = "Не выбран";
        }
    }
}
