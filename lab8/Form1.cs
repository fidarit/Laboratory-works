using System;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Кнопка "Расчёт"
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double Xmin, Xmax, step;
            if (double.TryParse(XminInput.Text, out Xmin)
                && double.TryParse(XmaxInput.Text, out Xmax)
                && double.TryParse(stepInput.Text, out step))
            {
                if (Xmax < Xmin)
                    return;

                //+2 потому что есть обязательные точки в начале и в конце
                int pointsCount = (int)(2 + (Xmax - Xmin) / step);

                double[] Xs = new double[pointsCount];
                double[] Ys = new double[pointsCount];

                //Вычисляем значения для всех X, кроме последнего
                for(int i = 0; i < pointsCount - 1; i++)
                {
                    Xs[i] = Xmin + step * i;
                    Ys[i] = GetValue(Xs[i]);
                }

                //Вычисляем последнюю пару
                Xs[pointsCount - 1] = Xmax;
                Ys[pointsCount - 1] = GetValue(Xmax);

                //Передаем данные в график
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                chart1.Series[0].Points.DataBindXY(Xs, Ys);
            }
        }

        //функцию из задания вывел отдельно
        const double y = -0.875;
        const double z = -0.000475;
        double GetValue(double x)
        {
            double result = Math.Abs(Math.Cos(x) - Math.Cos(y));

            double temp = Math.Pow(Math.Sin(y), 2);
            result = Math.Pow(result, 1 + 2 * temp);

            temp = 1;
            for (int i = 1; i <= 4; i++)
            {
                temp += Math.Pow(z, i) / i;
            }
            result *= temp;

            return result;
        }
    }
}
