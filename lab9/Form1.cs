using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Включаем сглаживание (убирает эффект лестницы у краев фигур)
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.LightSkyBlue);

            g.FillPie(new SolidBrush(Color.MediumSpringGreen), -250, 300, 1200, 500, 0, -180);

            DrawFilTree(g, 630, 475);
            DrawFilTree(g, 230, 400);
            DrawFilTree(g, 50, 410);
            DrawFilTree(g, 145, 460);

            DrawSun(g, 120, 90);
            DrawHome(g, 400, 470);

        }

        //Нарисовать елку, на вход - координаты средней нижней точки
        void DrawFilTree(Graphics g, int x, int y)
        {
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);

            int rectWidth = 40;
            int rectHeight = 50;
            int rectX = x - rectWidth / 2;
            int rectY = y - rectHeight;

            int triangleHeight = 150;
            int triangleWidth = 110;
            Point[] trianglePoints = new Point[3];

            trianglePoints[0].X = x;
            trianglePoints[0].Y = y - triangleHeight - rectHeight;

            trianglePoints[1].X = x - triangleWidth / 2;
            trianglePoints[1].Y = y - rectHeight;

            trianglePoints[2].X = x + triangleWidth / 2;
            trianglePoints[2].Y = y - rectHeight;

            g.FillRectangle(brownBrush, rectX, rectY, rectWidth, rectHeight);
            g.FillPolygon(greenBrush, trianglePoints);
        }

        //Нарисовать солнце, на вход - координаты середины
        void DrawSun(Graphics g, int x, int y)
        {
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Pen yellowPen = new Pen(Color.Yellow, 4);
            Pen orangePen = new Pen(Color.Orange, 4);

            //Рекомендуется брать четные числа 8+
            int raysCount = 18; //Количество солнечных лучей
            int sunRadius = 40;
            int raysStartDist = 50;
            int yellowRaysLength = 50;
            int orangeRaysLength = 20;
            
            int sunX = x - sunRadius;
            int sunY = y - sunRadius;
            //Рисуем само солнце
            g.FillEllipse(yellowBrush, sunX, sunY, sunRadius * 2, sunRadius * 2);

            //Тут уже рисуем лучи в цикле
            for(int i = 0; i < raysCount; i++)
            {
                double angle = Math.PI * 2 * i / raysCount;
                double sin = Math.Sin(angle);
                double cos = Math.Cos(angle);

                int startX = x + (int)(raysStartDist * sin);
                int startY = y + (int)(raysStartDist * cos);

                //Каждый второй лучик будет оранжевого цвета
                if (i % 2 == 0)
                {
                    int fullDistance = raysStartDist + yellowRaysLength;
                    int endX = x + (int)((fullDistance) * sin);
                    int endY = y + (int)((fullDistance) * cos);

                    g.DrawLine(yellowPen, startX, startY, endX, endY);
                }
                else
                {
                    int fullDistance = raysStartDist + orangeRaysLength;
                    int endX = x + (int)((fullDistance) * sin);
                    int endY = y + (int)((fullDistance) * cos);

                    g.DrawLine(orangePen, startX, startY, endX, endY);
                }                
            }
        }

        //Нарисовать домик, на вход - координаты средней нижней точки
        void DrawHome(Graphics g, int x, int y)
        {
            int wallWidth = 240;
            int wallHeigth = 160;
            int wallX = x - wallWidth / 2;
            int wallY = y - wallHeigth;
            SolidBrush wallBrush = new SolidBrush(Color.RosyBrown);

            int roofWidth = 290;
            int roofHeigth = 120;
            SolidBrush roofBrush = new SolidBrush(Color.GreenYellow);
            Point[] roofPoints = new Point[3];

            roofPoints[0].X = x;
            roofPoints[0].Y = wallY - roofHeigth;

            roofPoints[1].X = x - roofWidth / 2;
            roofPoints[1].Y = wallY;

            roofPoints[2].X = x + roofWidth / 2;
            roofPoints[2].Y = wallY;

            int doorWidth = 60;
            int doorHeigth = 95;
            int doorX = x - doorWidth / 2;
            int doorY = y - doorHeigth;
            SolidBrush doorBrush = new SolidBrush(Color.Yellow);

            int doorHandleX = doorX + 5;
            int doorHandleY = y - doorHeigth / 2;
            int doorHandleDia = 8;
            SolidBrush doorHandleBrush = new SolidBrush(Color.Brown);

            int pipeX = x - roofWidth / 4;
            int pipeY = wallY - roofHeigth + 10;
            int pipeWidth = 30;
            int pipeHeigth = roofHeigth / 2;
            SolidBrush pipeBrush = new SolidBrush(Color.Brown);

            g.FillRectangle(pipeBrush, pipeX, pipeY, pipeWidth, pipeHeigth);
            g.FillRectangle(wallBrush, wallX, wallY, wallWidth, wallHeigth);

            g.FillPolygon(roofBrush, roofPoints);
            g.FillRectangle(doorBrush, doorX, doorY, doorWidth, doorHeigth);

            g.FillEllipse(doorHandleBrush, doorHandleX, doorHandleY, doorHandleDia, doorHandleDia);
        }
    }
}
