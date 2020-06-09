using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab14_3
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

                using (FileStream fstream = new FileStream(filename, FileMode.Open))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);

                    textBox1.Text = Encoding.Default.GetString(array);
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

                using (FileStream fstream = new FileStream(filename, FileMode.Create))
                {
                    byte[] array = Encoding.Default.GetBytes(textBox1.Text);
                    fstream.Write(array, 0, array.Length);
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

                using (FileStream fstream = new FileStream(filename, FileMode.Append))
                {
                    byte[] array = Encoding.Default.GetBytes(textBox1.Text);
                    fstream.Write(array, 0, array.Length);
                }
            }
        }
    }
}
