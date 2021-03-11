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
            this.eraser = new Pen(Color.White, 2);
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
