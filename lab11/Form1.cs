using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.DarkCyan, 2.5f);
        int circlesCount = 20;

        int startLocation = 8;
        int deltaLocation = 12;
        int aLocation = 7;

        int startSize = 14;
        int deltaSize = 14;

        bool flag = false;

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

            DrawCircle(g, startLocation, startSize, deltaLocation, circlesCount);
        }

        private void DrawCircle(Graphics g, int loc, int size, int deltaLoc, int N)
        {
            if (N == 0)
                return;

            flag = false;

            g.DrawEllipse(pen, loc, loc, size, size);

            loc += deltaLoc;
            deltaLoc += aLocation;

            size += deltaSize;
            N--;
            
            timer1.Enabled = true;
            flag = true;
            while (flag)
                Application.DoEvents();
            timer1.Enabled = false;

            DrawCircle(g, loc, size, deltaLoc, N);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            flag = false;
        }
    }
}
