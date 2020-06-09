using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int countX = 5, countY = 5;
            const int buttonWidth = 80, buttonHeight = 30;
            int num = 1;

            double xDist = (panel1.Size.Width - buttonWidth * countX) / (countX + 1);
            double yDist = (panel1.Size.Height - buttonHeight * countY) / (countY + 1);

            for (int y = 0; y < countY; y++)
            {
                for (int x = 0; x < countX; x++)
                {
                    Button b = new Button();
                    b.Parent = panel1;
                    b.Text = "Button_" + num.ToString();
                    num++;

                    Point loc = new Point();
                    loc.X = (int)Math.Round((xDist + buttonWidth) * x + xDist);
                    loc.Y = (int)Math.Round((yDist + buttonHeight) * y + yDist);

                    b.Location = loc;
                    b.Size = new Size(buttonWidth, buttonHeight);
                }
            }
        }
    }
}
