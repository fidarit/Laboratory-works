using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        //Количество элементов
        const short N = 25;
        //Глобальный массив элементов
        float[] array = new float[N];
        public Form1()
        {
            InitializeComponent();
        }

        //Заполнение массива
        private void generateButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for(int i = 0; i < N; i++)
            {
                array[i] = 0.1f * rand.Next(-50, 50);
                listBox1.Items.Add("Array[" + i + "] = " + array[i]);
            }
        }

        //Замена
        private void replaceButton_Click(object sender, EventArgs e)
        {
            int min = 0;
            listBox2.Items.Clear();

            for(int i = 1; i < N; i++)
                if (array[i] < array[min]) min = i;

            float temp = array[0];
            array[0] = array[min];
            array[min] = temp;
            
            for (int i = 0; i < N; i++)
            {
                listBox2.Items.Add("Array[" + i + "] = " + array[i]);
            }
        }
    }
}
