using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditor
{
    enum DrawMode
    {
        LINE,
        RECTANGLE,
        CIRCLE,
        CURVED_LINE
    }
    public partial class Frmmain : Form
    {
        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, prevP; 
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            StsCurrent.Text = "";

            g = CreateGraphics();
            pen = new Pen(Color.Black, 2);
            StsCurrent.Text = "Line Mode";
            mode = DrawMode.LINE;
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);
        }

        

        private void Frmmain_MouseUp(object sender, MouseEventArgs e)
        {
            this.endP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.eraser, this.startP, this.prevP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.pen,
                         new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void Frmmain_MouseDown(object sender, MouseEventArgs e)
        {
            this.startP = new Point(e.X, e.Y);
            this.currP = this.prevP = this.startP;

        }
        /// <summary>
        /// 마우스 옮길때마다 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frmmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            this.prevP = this.currP;
            this.currP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.eraser, this.startP, this.prevP);
                    g.DrawLine(this.pen, this.startP, this.currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.eraser,
                        new Rectangle(startP, new Size(prevP.X - startP.X, endP.Y - startP.Y)));
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.eraser,
                      new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }
        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LINE;
        }

        private void TlmRectangle_Click(object sender, EventArgs e)
        {

            this.mode = DrawMode.RECTANGLE;
        }

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE;
        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE;
        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
