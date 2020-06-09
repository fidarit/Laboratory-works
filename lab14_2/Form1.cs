using System;
using System.IO;
using System.Windows.Forms;

namespace lab14_2
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

                textBox1.Text = File.ReadAllText(filename);
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

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                File.WriteAllText(filename, textBox1.Text);
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

                File.AppendAllText(filename, textBox1.Text);
            }
        }
    }
}
