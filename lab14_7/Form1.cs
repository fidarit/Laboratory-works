using System;
using System.IO;
using System.Windows.Forms;

namespace lab14_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string student = "Иванов             Иван            Иваныч";
            student += "                  1992                  Москва";

            listBox.Items.Add(student);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index >= 0)
            {
                listBox.Items.RemoveAt(index);

                if(index < listBox.Items.Count)
                    listBox.SetSelected(index, true);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Открыть файл",
                Filter = "Txt файл (*.txt)|*.txt|"
                      + "Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Clear();

                string filename = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(filename);
                listBox.Items.AddRange(lines);
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Сохранить в файл",
                Filter = "Txt файл (*.txt)|*.txt|"
                      + "Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach(object lineObj in listBox.Items)
                    {
                        writer.WriteLine((string)lineObj);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index >= 0)
            {
                infoTextBox.Text = (string)listBox.SelectedItem;
            }
        }

        private void infoTextBox_TextChanged(object sender, EventArgs e)
        {

            int index = listBox.SelectedIndex;

            if (index >= 0)
            {
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index, infoTextBox.Text);
                listBox.SetSelected(index, true);
            }
        }
    }
}
