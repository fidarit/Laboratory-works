using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        float circleRadius = 25f;
        PointF circleCenter = new PointF();

        float xSpeed = 75f;
        float xRatio = 0.025f;
        float yRatio = 75f;

        Pen pen = new Pen(Color.DarkGreen, 3);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Включаем сглаживание (убирает эффект лестницы)
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.LightSkyBlue);
            

            float x = circleCenter.X - circleRadius;
            float y = circleCenter.Y - circleRadius;
            float size = 2 * circleRadius;
            RectangleF rect = new RectangleF(x, y, size, size);
            g.DrawEllipse(pen, rect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Исправляет ошибку с мерцанием при обновлении кадра
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CalculateCircleXY();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculateCircleXY();
            Invalidate();
        }
        
        private void CalculateCircleXY()
        {
            int endX = ClientSize.Width;
            int startY = ClientSize.Height / 2;

            float deltaX = xSpeed * timer1.Interval / 1000;
            float x = circleCenter.X + deltaX;      
            
            if(x > endX)
            {
                x -= endX;
            }

            float y = startY + ((float)Math.Sin(x * xRatio) * yRatio);

            circleCenter.X = x;
            circleCenter.Y = y;
        }
    }
}
