using System;
using System.IO;
using System.Windows.Forms;

namespace lab14_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                filenameTextBox.Text = filename;

                FileInfo fileInfo = new FileInfo(filename);

                resultTextBox.Clear();
                PrintResult("Полное имя файла: " + fileInfo.FullName);
                PrintResult("Путь до файла: " + fileInfo.DirectoryName);
                PrintResult("Имя файла: " + fileInfo.Name);
                PrintResult();
                PrintResult("Расширение: " + fileInfo.Extension);
                PrintResult("Размер: " + fileInfo.Length + " байт");
                PrintResult("Атрибуты: " + fileInfo.Attributes.ToString());
                PrintResult("Только для чтения: " + fileInfo.IsReadOnly);
                PrintResult();
                PrintResult("Создан: " + fileInfo.CreationTime);
                PrintResult("Изменён: " + fileInfo.LastWriteTime);
                PrintResult("Открыт: " + fileInfo.LastAccessTime);
            }
        }
        private void PrintResult(string result = "")
        {
            resultTextBox.Text += result + Environment.NewLine;
        }
    }
}
