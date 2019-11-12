using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OOPDraw
{    public partial class OOPDrawForm : Form
    {
        protected List<Shape> shapes;
        protected Random rnd = new Random();
        protected Pen pen;
        protected Color color;

        public OOPDrawForm()
        {
            InitializeComponent();
        }
        private void DrawBox_Click(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (shapes == null)
            {
                shapes = new List<Shape>();
            }
            Graphics draw = DrawBox.CreateGraphics();
            int randomShape;
            if (checkBoxColorOfShapes.Checked)
            {
                color = colorDialog.Color;
            }
            else
                color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            for (int i = 0; i < trackBarDrawings.Value; i++)
            {
                switch (randomShape = rnd.Next(0, 5))
                {
                    case 0:
                        shapes.Add(new Point(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 1:
                        shapes.Add(new Line(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 2:
                        shapes.Add(new Rectangle(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 4:
                        shapes.Add(new Ellipse(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                }
            }
            DrawBox.Refresh();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics draw = DrawBox.CreateGraphics();
            Brush clear = new SolidBrush(DrawBox.BackColor);
            RectangleF Clear = new RectangleF(0, 0, DrawBox.Width, DrawBox.Height);
            draw.FillRectangle(clear, Clear);
            shapes = null;
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            if (shapes != null)
            {
                for(int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].Draw(e.Graphics);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBoxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen;
            if (shapes == null)
            {
                shapes = new List<Shape>();
            }
            if (checkBoxColorOfShapes.Checked)
            {
                color = colorDialog.Color;
            }
            else
                color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            for (int i = 0; i < trackBarDrawings.Value; i++)
            {
                switch (comboBoxAdd.SelectedIndex)
                {
                    case 0:
                        shapes.Add(new Point(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 1:
                        shapes.Add(new Line(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 2:
                        shapes.Add(new Rectangle(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                    case 4:
                        shapes.Add(new Ellipse(rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            rnd.Next(0, DrawBox.Width), rnd.Next(0, DrawBox.Height),
                            pen = new Pen(color, 2)));
                        break;
                }
            }
            DrawBox.Refresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDownNumOfShape.Value;
            if (shapes == null)
            {
                shapes = new List<Shape>();
            }
            if (number < shapes.Count)
            {
                shapes.RemoveAt(number);
                DrawBox.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            DrawBox.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void buttonChooseFontColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                DrawBox.BackColor = colorDialog.Color;
            }
        }

        private void checkBoxColorOfShapes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColorOfShapes.Checked)
            {
                buttonChangeColorOfDrawings.Visible = true;
            }
            else
                buttonChangeColorOfDrawings.Visible = false;
        }

        private void buttonChangeColorOfDrawings_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxChangeX.Text == null)
            {
                textBoxChangeX.Text = "0";
            }
            if (textBoxChangeY.Text == null)
            {
                textBoxChangeY.Text = "0";
            }
            if (shapes != null && textBoxChangeX.Text != "0" && textBoxChangeY.Text != "0")
            {
                shapes[(int)numericUpDownNumOfShape.Value].CoordsChange(int.Parse(textBoxChangeX.Text), int.Parse(textBoxChangeY.Text));
                DrawBox.Refresh();
            }
        }

        private void buttonMoveAll_Click(object sender, EventArgs e)
        {
            if (textBoxChangeX.Text == null)
            {
                textBoxChangeX.Text = "0";
            }
            if (textBoxChangeY.Text == null)
            {
                textBoxChangeY.Text = "0";
            }
            if (shapes != null && textBoxChangeX.Text != "0" && textBoxChangeY.Text != "0")
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].CoordsChange(int.Parse(textBoxChangeX.Text), int.Parse(textBoxChangeY.Text));
                }
                DrawBox.Refresh();
            }
        }
    }
    public abstract class Shape
    {
        protected int X1, Y1;
        protected Random coord = new Random();
        protected Pen Pen;
        abstract public void Draw(Graphics draw);
        abstract public void CoordsChange(int dX, int dY);
    }
    public class Point : Shape
    {
        public Point(Pen pen)
        {
            X1 = coord.Next(301);
            Y1 = coord.Next(301);
            Pen = pen;
        }
        public Point(int x1, int y1, Pen pen)
        {
            X1 = x1;
            Y1 = y1;
            Pen = pen;
        }
        public Point(Point obj, Pen pen)
        {
            X1 = obj.X1;
            Y1 = obj.Y1;
            Pen = pen;
        }
        public virtual void Set(int x1, int y1)
        {
            X1 = x1;
            Y1 = y1;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1, Y1, 1, 1);
        }
        public override void CoordsChange(int dX, int dY)
        {
            X1 -= dX;
            Y1 -= dY;
        }
    }
    public class Line : Point
    {
        protected int X2, Y2;
        public Line(Pen pen) : base(pen)
        {
            X2 = coord.Next(301);
            Y2 = coord.Next(301);
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
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
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
            Width = Math.Abs(X1 - X2);
            Height = Math.Abs(Y1 - Y2);
        }
        public Rectangle(Rectangle obj, Pen pen) : base(obj, pen)
        {
            Width = Math.Abs(X1 - obj.X2) - 1;
            Height = Math.Abs(Y1 - obj.Y2) - 1;
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
            draw.DrawRectangle(Pen, X1 - Width / 2, Y1 - Height / 2, Width, Height);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
    public class Circle : Point
    {
        protected int X2, Y2;
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
            draw.DrawEllipse(Pen, X1 - Radius / 2, Y1 - Radius / 2, Radius, Radius);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
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
            draw.DrawEllipse(Pen, X1 - Radius / 2, Y1 - Radius2 / 2, Radius, Radius2);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
}
