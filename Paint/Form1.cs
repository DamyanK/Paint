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
        private bool drawing = false;
        private Pen pen;

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

        // Works for all colors
        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            X = e.X;
            Y = e.Y;
            Canvas.Cursor = Cursors.Cross;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            X = -1;
            Y = -1;
            Canvas.Cursor = Cursors.Default;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Canvas.Refresh();
            pen = new Pen(Color.Black, 5);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing && X != -1 && Y != -1)
            {
                graphics.DrawLine(pen, new Point(X, Y), e.Location);
                X = e.X;
                Y = e.Y;
            }
        }
    }
}
