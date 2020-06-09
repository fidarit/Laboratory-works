using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        private Point previousPoint, point;

        private Bitmap bmp, reserveBmp;
        private Pen blackPen;
        private Graphics g; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4);

            //Пусть на пустом полотне тоже можно будет рисовать
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            reserveBmp = (Bitmap)bmp.Clone();
            pictureBox1.Image = bmp;

            g = Graphics.FromImage(pictureBox1.Image);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|"
                + "*.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf;";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);

                int width = image.Width;
                int height = image.Height;

                pictureBox1.Width = width;
                pictureBox1.Height = height;

                bmp = new Bitmap(image, width, height);

                //Сохраняем копию изображения для кнопки "Вернуть исходное изображение"
                reserveBmp = (Bitmap)bmp.Clone();

                pictureBox1.Image = bmp;

                g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Title = "Сохранить картинку как...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.ShowHelp = true;
            saveDialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIFF File(*.tif)|*.tiff|" +
                "PNG File(*.png)|*.png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                string fileExtension = fileName.Remove(0, fileName.Length - 3);

                switch (fileExtension)
                {
                    case "bmp":
                        bmp.Save(fileName, ImageFormat.Bmp);
                        break;
                    case "gif":
                        bmp.Save(fileName, ImageFormat.Gif);
                        break;
                    case "jpg":
                        bmp.Save(fileName, ImageFormat.Jpeg);
                        break;
                    case "tif":
                        bmp.Save(fileName, ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, ImageFormat.Png);
                        break;
                }
            }
        }
        private void reloadImgButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)reserveBmp.Clone();

            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();

            g = Graphics.FromImage(pictureBox1.Image);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint.X = e.X;
            previousPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;

                g.DrawLine(blackPen, previousPoint, point);

                previousPoint.X = point.X;
                previousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);

                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;
                    int gray = (red + green + blue) / 3;

                    pixel = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(x, y, pixel);
                }
            }
            pictureBox1.Invalidate();
        }

        private void sobelButton_Click(object sender, EventArgs e)
        {
            //Получаем монотонные пиксели
            int[,] grayPixels = new int[bmp.Height, bmp.Width];
            for (int y = 0; y < bmp.Height; ++y)
            {
                for (int x = 0; x < bmp.Width; ++x)
                {
                    Color rgb = bmp.GetPixel(x, y);
                    grayPixels[y, x] = (rgb.B + rgb.G + rgb.R) / 3;
                }
            }

            int nWidth = bmp.Width - 1;
            int nHeight = bmp.Height - 1;
            for (int y = 1; y < nHeight; y++)
            {
                for (int x = 1; x < nWidth; x++)
                {
                    Color rgb;
                    int d1, d2, avr;

                    //Вычисляем разницы между угловыми пикселями
                    d1 = Math.Abs(grayPixels[y - 1, x - 1] - grayPixels[y + 1, x + 1]);
                    d2 = Math.Abs(grayPixels[y + 1, x - 1] - grayPixels[y - 1, x + 1]);

                    avr = (d1 + d2) / 2;

                    //Если в этом месте пиксель меняет яркость больше чем threshold
                    if (avr > thresholdInput.Value)
                        rgb = Color.Black;
                    else
                        rgb = Color.White;

                    bmp.SetPixel(x, y, rgb);
                }
            }
            pictureBox1.Invalidate();
        }

    }
}
