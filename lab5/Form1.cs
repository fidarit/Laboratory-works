using System;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] nums =  { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex > -1)
            {
                string line = (string)listBox1.Items[selectedIndex];
                label1.Text = "";

                for (int k = 0; k < line.Length; k++)
                {
                    if (nums.Contains(line[k]))
                    {
                        label1.Text += line[k];
                    }
                }
            }
            else
            {
                label1.Text = "Выберите строку";
            }
        }
    }
}
