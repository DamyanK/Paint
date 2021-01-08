using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int X = -1, Y = -1;
        private Boolean drawing = false;
        private Pen pen;
        private Rectangle shape;

        public Form1()
        {
            InitializeComponent();
            graphics = Canvas.CreateGraphics();
            graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap =
                System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButtonBrush.Checked)
            {
                drawing = true;
                X = e.X;
                Y = e.Y;
                Canvas.Cursor = Cursors.Cross;
            }
            else
            {
                X = e.X;
                Y = e.Y;
                Canvas.Cursor = Cursors.Cross;
            }
        }

        private int w, h;
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButtonBrush.Checked)
            {
                drawing = false;
                X = -1;
                Y = -1;
                Canvas.Cursor = Cursors.Default;
            }
            else
            {
                w = e.X - X;
                h = e.Y - Y;
                shape = new Rectangle(X, Y, w, h);
                if (radioButtonRect.Checked)
                {
                    graphics.DrawRectangle(pen, shape);
                    X = -1;
                    Y = -1;
                }
                if (radioButtonElipse.Checked)
                {
                    graphics.DrawEllipse(pen, shape);
                    X = -1;
                    Y = -1;
                }
            }
        }

        private void pictureBoxRed_Click_1(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private Boolean erasing = false;
        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            erasing = true;
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            pen = new Pen(pen.Color, (int)fontSize.Value);
            pen.StartCap = pen.EndCap =
                System.Drawing.Drawing2D.LineCap.Round;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Canvas.Refresh();
            pen.Color = Color.Black;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing && X != -1 && Y != -1)
            {
                graphics.DrawLine(pen, new Point(X, Y), e.Location);
                X = e.X;
                Y = e.Y;
            }
        }
    }
}
