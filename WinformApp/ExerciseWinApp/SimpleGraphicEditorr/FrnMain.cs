using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditorr
{
    public partial class FrnMain : Form
    {
        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, prevP;

        enum DrawMode
        {
            LINE,
            RECTANGLE,
            CIRCLE,
            CURVED_LINE
        }

        public FrnMain()
        {
            InitializeComponent();

        }

        private void FrnMain_Load(object sender, EventArgs e)
        {
            StsCurrent.Text = "";

            g = CreateGraphics();
            this.pen = new Pen(Color.Black, 2);
            StsCurrent.Text = "Line Mode";
            mode = DrawMode.LINE;
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.Black, 2);
        }

        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LINE;
            StsCurrent.Text = "Line Mode";
        }

        private void TlmRectangle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.RECTANGLE;
            StsCurrent.Text = "Rectangle Mode";
        }

        private void FrnMain_MouseUp(object sender, MouseEventArgs e)
        {
            endP = new Point(e.X, e.Y);
            switch (mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(pen, startP, endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(pen, new Rectangle(startP,
                        new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(startP,
                      new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void FrnMain_MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);
            currP = prevP = startP;
        }

        private void FrnMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            
            prevP = currP;
            currP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(eraser, startP, prevP);
                    g.DrawLine(pen, startP, currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(eraser, new Rectangle(startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    break;
                    g.DrawRectangle(pen, new Rectangle(startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                case DrawMode.CIRCLE:
                    g.DrawEllipse(eraser, new Rectangle(startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    break;
                    g.DrawEllipse(pen, new Rectangle(startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE;
            StsCurrent.Text = "Circle Mode";
        }

        private void TlmCurve_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE;
            StsCurrent.Text = "Curved Line Mode";
        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if ( dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
