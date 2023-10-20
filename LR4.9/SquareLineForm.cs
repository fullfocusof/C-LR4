using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._9
{
    public partial class SquareLineForm : Form
    {
        Graphics g;
        Pen MyPen;
        Random rand;
        Font MyFont;
        Point[] triangle;
        Point p;

        public SquareLineForm()
        {
            InitializeComponent();
            g = CreateGraphics();
            MyPen = new Pen(Color.Black, 3);
            rand = new Random();
            MyFont = new Font("Arial", 16);
        }

        private void ExecButtonDraw_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            Point[] points = new Point[]
                {
                    new Point(rand.Next(0, ClientSize.Width - 20), rand.Next(50, ExecButtonStart.Location.Y - 20)),
                    new Point(rand.Next(0, ClientSize.Width - 20), rand.Next(50, ExecButtonStart.Location.Y - 20)),
                    new Point(rand.Next(0, ClientSize.Width - 20), rand.Next(50, ExecButtonStart.Location.Y - 20))
                };
            triangle = points;
            g.DrawPolygon(MyPen, points);

            g.DrawString("A", MyFont, Brushes.Black, points[0].X, points[0].Y + 10);
            g.DrawString("B", MyFont, Brushes.Black, points[1].X, points[1].Y + 10);
            g.DrawString("C", MyFont, Brushes.Black, points[2].X, points[2].Y + 10);
        }

        private void SquareLineForm_MouseClick(object sender, MouseEventArgs e)
        {
            //if ()
            //{ 
                p.X = e.X;
                p.Y = e.Y;
                g.FillEllipse(Brushes.Black, p.X, p.Y, 7, 7);
            //}
        }

        private void ExecButtonStart_Click(object sender, EventArgs e)
        {
            int steps = int.Parse(textBoxSteps.Text);

            for (int i = 0; i < steps; i++)
            {
                int randPoint = rand.Next(0, 3);

                double fullLength = Math.Sqrt(Math.Pow(triangle[randPoint].X - p.X, 2) + Math.Pow(triangle[randPoint].Y - p.Y, 2));
                double halfLength = fullLength / 2;

                g.DrawLine(MyPen, p.X, p.Y, (float)(p.X + halfLength * (triangle[randPoint].X - p.X) / fullLength), (float)(p.Y + halfLength * (triangle[randPoint].Y - p.Y) / fullLength));
            }
        }
    }
}
