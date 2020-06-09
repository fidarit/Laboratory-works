using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        //матрица (3, 4)
        int[,] array = new int[3, 4]; 
        public Form1()
        {
            InitializeComponent();

            //Задаем размеры
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 3;

            dataGridView2.ColumnCount = 4;
            dataGridView2.RowCount = 3;
        }

        //Заполнить
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    array[i, j] = rand.Next(-20, 20);
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

        //Замена
        private void button2_Click(object sender, EventArgs e)
        {
            //Нахождение суммы
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += array[i, i];
            }
            array[2, 3] = sum;

            //Вывод
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }

        }
    }
}
