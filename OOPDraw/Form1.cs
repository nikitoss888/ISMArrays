using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPDraw
{    public partial class OOPDrawForm : Form
    {
        Bitmap Canvas;
        public OOPDrawForm()
        {
            InitializeComponent();
            Canvas = new Bitmap(DrawBox.Width, DrawBox.Height);
        }
        private void DrawBox_Click(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics draw = DrawBox.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), 2);
            Shape[] shapes = new Shape[20];
            int r_shape;
            for(int i = 0; i < shapes.Length; i++)
            {
                switch (r_shape = rnd.Next(1,6))
                {
                    case 1:
                        shapes[i] = new Point(pen);
                        break;
                    case 2:
                        shapes[i] = new Line(pen);
                        break;
                    case 3:
                        shapes[i] = new Rectangle(pen);
                        break;
                    case 4:
                        shapes[i] = new Circle(pen);
                        break;
                    case 5:
                        shapes[i] = new Ellipse(pen);
                        break;
                }
                shapes[i].Draw(draw);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics draw = DrawBox.CreateGraphics();
            Brush clear = new SolidBrush(Color.White);
            RectangleF Clear = new RectangleF(0, 0, DrawBox.Width, DrawBox.Height);
            draw.FillRectangle(clear, Clear);
        }
    }
    public abstract class Shape
    {
        protected int X1, Y1, X2, Y2;
        protected Random coord = new Random();
        protected Pen Pen;
        abstract public void Draw(Graphics draw);
    }
    public class Point : Shape
    {
        public Point(Pen pen)
        {
            X1 = coord.Next(200);
            Y1 = coord.Next(200);
            Pen = pen;
        }
        public Point(int x1, int y1, Pen pen)
        {
            X1 = x1;
            X2 = X1 + 1;
            Y1 = y1;
            Y2 = Y1;
            Pen = pen;
        }
        public Point(Point obj, Pen pen)
        {
            X1 = obj.X1;
            Y1 = obj.Y1;
            X2 = X2 + 1;
            Y2 = Y1;
            Pen = pen;
        }
        public virtual void Set(int x1, int y1)
        {
            X1 = x1;
            Y1 = y1;
            X2 = X2 + 1;
            Y2 = Y1;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1, Y1, 1, 1);
        }
    }
    public class Line : Point
    {
        protected int X2, Y2;
        public Line(Pen pen) : base(pen)
        {
            X2 = coord.Next(200);
            Y2 = coord.Next(200);
        }
        public Line(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {

            X2 = x2;
            Y2 = y2;
        }
        public Line(Line obj, Pen pen) : base(obj, pen)
        {
            X2 = obj.X2;
            Y2 = obj.Y2;
        }
        public virtual void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y2 = y2;
            X2 = x2;
            Y2 = y2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawLine(Pen, X1, Y1, X2, Y2);
        }
    }
    public class Rectangle : Line
    {
        protected int Width, Height;
        public Rectangle(Pen pen) : base(pen)
        {
            Width = Math.Abs(X1 - X2);
            Height = Math.Abs(Y1 - Y2);
        }
        public Rectangle(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, x2, y2, pen)
        {
        }
        public Rectangle(Rectangle obj, Pen pen) : base(obj, pen)
        {
        }
        public override void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y2 = y2;
            X2 = x2;
            Y2 = y2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawRectangle(Pen, X1, Y1, Width, Height);
        }

    }
    public class Circle : Point
    {
        protected int Radius;
        public Circle(Pen pen) : base(pen)
        {
            X2 = coord.Next(401);
            Y2 = coord.Next(401);
            Radius = Math.Abs(X2 - X1);
        }
        public Circle(int x1, int y1, int x2, int y2, Pen pen): base(x1, y1, pen)
        {
            X2 = coord.Next(401);
            Y2 = coord.Next(401);
            Radius = Math.Abs(X2 - X1);
        }
        public Circle(Circle obj, Pen pen) : base(obj, pen)
        {
            X2 = coord.Next(401);
            Y2 = coord.Next(401);
            Radius = Math.Abs(X2 - X1);
        }
        public virtual void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Radius = Math.Abs(X2 - X1);
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1, Y1, Radius, Radius);
        }
    }
    public class Ellipse : Circle
    {
        protected int Radius2;
        public Ellipse(Pen pen) : base(pen)
        {
            Radius2 = Math.Abs(Y2 - Y1);
        }
        public Ellipse(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, x2, y2, pen)
        {
            Radius2 = Math.Abs(Y2 - Y1);
        }
        public Ellipse(Ellipse obj, Pen pen) : base(obj, pen)
        {
            Radius2 = Math.Abs(Y2 - Y1);
        }
        public override void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Radius = Math.Abs(X2 - X1);
            Radius2 = Math.Abs(Y2 - Y1);
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1, Y1, Radius, Radius2);
        }
    }
}
