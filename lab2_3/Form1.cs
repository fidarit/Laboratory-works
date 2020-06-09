using System;
using System.Windows.Forms;

namespace lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton3_Click(object sender, EventArgs e)
        {
            result_label3.Text = textBox1.Text == "класса" ? "Верно!" : "Ошибка!";
        }

        private void checkButton2_Click(object sender, EventArgs e)
        {
            if (property_radioButton.Checked || response_radioButton.Checked
                || !event_radioButton.Checked || method_radioButton.Checked)
                result_label2.Text = "Ошибка!";
            else
                result_label2.Text = "Верно!";
        }

        private void checkButton1_Click(object sender, EventArgs e)
        {
            if(!button_checkBox.Checked && !panel_checkBox.Checked
                && label_checkBox.Checked && edit_checkBox.Checked)
                result_label1.Text = "Верно!";
            else
                result_label1.Text = "Ошибка!";
        }
    }
}
