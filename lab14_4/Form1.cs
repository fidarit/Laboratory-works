using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab14_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Открыть файл",
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Текстовый файл (*.txt)|*.txt|"
                       + "Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;

                using (StreamReader stream = new StreamReader(filename, Encoding.Default))
                {
                    textBox1.Text = stream.ReadToEnd();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Сохранить в файл",
                Filter = "Текстовый файл (*.txt)|*.txt|"
                       + "Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                using (StreamWriter stream = new StreamWriter(filename, false, Encoding.Default))
                {
                    string[] lines = textBox1.Lines;

                    foreach(string line in lines)
                        stream.WriteLine(line);
                }
            }
        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Добавить в файл",
                OverwritePrompt = false,
                Filter = "Текстовый файл (*.txt)|*.txt|"
                       + "Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                using (StreamWriter stream = new StreamWriter(filename, true, Encoding.Default))
                {
                    string[] lines = textBox1.Lines;

                    foreach (string line in lines)
                        stream.WriteLine(line);
                }
            }
        }
    }
}
