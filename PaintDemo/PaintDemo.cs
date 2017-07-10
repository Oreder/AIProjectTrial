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
    public enum ButtonColor
    {
        LEFT, 
        RIGHT
    };

    public partial class PaintDemo : Form
    {
        private Point _p1;
        private Point _p2;
        private bool _isDown;

        private Graphics g;
        private Bitmap bmp;

        private ButtonColor _currentButtonColor;
        private Color _currentColor;

        public PaintDemo()
        {
            InitializeComponent();

            this.MouseDown += PaintDemo_MouseDown;
            this.MouseMove += PaintDemo_MouseMove;
            this.MouseUp += PaintDemo_MouseUp;

            this.Paint += PaintDemo_Paint;

            bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);
            _currentButtonColor = ButtonColor.LEFT;
            _currentColor = pnLeft.BackColor;

            // optimise form vibration
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void PaintDemo_Paint(object sender, PaintEventArgs e)
        {
            if (_isDown)
            {
                e.Graphics.DrawLine(new Pen(_currentColor, 1.5f), _p1, _p2);
            }
        }

        void PaintDemo_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;
            g.DrawLine(new Pen(_currentColor, 1.5f), _p1, _p2);
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

        private void chooseColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog _cd = new ColorDialog();
            _currentColor = _cd.Color;

            if (_cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (_currentButtonColor == ButtonColor.LEFT)
                {
                    pnLeft.BackColor = _cd.Color;
                }
                else
                {
                    pnRight.BackColor = _cd.Color;
                }
            }
        }

        private void pnLeft_Click(object sender, EventArgs e)
        {
            _currentButtonColor = ButtonColor.LEFT;
            _currentColor = pnLeft.BackColor;
        }

        private void pnRight_Click(object sender, EventArgs e)
        {
            _currentButtonColor = ButtonColor.RIGHT;
            _currentColor = pnRight.BackColor;
        }
    }
}
