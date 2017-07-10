using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDemo
{
    public partial class PaintDemo : Form
    {
        private Point _p1;
        private Point _p2;
        private bool _isDown;

        private Graphics g;
        private Bitmap bmp;

        public PaintDemo()
        {
            InitializeComponent();

            this.MouseDown += PaintDemo_MouseDown;
            this.MouseMove += PaintDemo_MouseMove;
            this.MouseUp += PaintDemo_MouseUp;

            this.Paint += PaintDemo_Paint;

            bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);

            // optimise form vibration
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        void PaintDemo_Paint(object sender, PaintEventArgs e)
        {
            if (_isDown)
            {
                e.Graphics.DrawLine(new Pen(Color.Red, 1.5f), _p1, _p2);
            }
        }

        void PaintDemo_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;
            g.DrawLine(new Pen(Color.Red, 1.5f), _p1, _p2);
            this.BackgroundImage = (Bitmap)bmp.Clone();
        }

        void PaintDemo_MouseMove(object sender, MouseEventArgs e)
        {
            labelCo.Text = "X: " + e.Location.X.ToString() + "; Y: " + e.Location.Y.ToString();
            if (_isDown)
            {
                _p2 = new Point(e.Location.X, e.Location.Y);
                this.Refresh();     // reset and receive new status of form
            }
        }

        void PaintDemo_MouseDown(object sender, MouseEventArgs e)
        {
            _isDown = true;
            _p1 = new Point(e.Location.X, e.Location.Y);
        }
    }
}
