using System;
using System.Drawing;
using System.Windows.Forms;

namespace imslicer
{


    public partial class Form1 : Form
    {
        private Point rectStartPoint;
        private Point rectEndPoint;
        private Rectangle rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        private Point origin = new Point(0, 0);
        private Size noSize = new Size(0, 0);
        private int shortDistance = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMain.Load(openFileDialog1.FileName);
            }
        }

        private void buttonClearImage_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = null;
        }
        
        // Define start of selection when left mouse pressed
        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            rectStartPoint = e.Location;
            Invalidate();
        }

        // Define rectangular selection region on mouse move
        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            rectEndPoint = e.Location;
            rect.Location = new Point(
                Math.Min(rectStartPoint.X, rectEndPoint.X),
                Math.Min(rectStartPoint.Y, rectEndPoint.Y));
            rect.Size = new Size(
                Math.Abs(rectStartPoint.X - rectEndPoint.X),
                Math.Abs(rectStartPoint.Y - rectEndPoint.Y));
            pictureBoxMain.Invalidate();
        }

        // Draw selection rectangle
        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                if (rect != null && rect.Width > 0 && rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, rect);
                }
            }
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (isClose(rectEndPoint, e.Location) || rect.Contains(e.Location))
                return;

            rect.Location = origin;
            rect.Size = noSize;
            pictureBoxMain.Invalidate();
        }

        private bool isClose(Point p1, Point p2)
        {
            double dist = (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
            if (dist < shortDistance)
                return true;
            else
                return false;
                
        }

        private void pictureBoxMain_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

        }
    }
}
