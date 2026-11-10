using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HotelSystem
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 15;

        public Color BorderColor { get; set; } =
            Color.FromArgb(36, 74, 112);

        public int BorderSize { get; set; } = 1;

        public RoundedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            int radius = Math.Min(
                BorderRadius,
                Math.Min(rect.Width, rect.Height) / 2
            );

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius * 2,
                    radius * 2, 180, 90);

                path.AddArc(rect.Right - radius * 2,
                    rect.Y, radius * 2, radius * 2, 270, 90);

                path.AddArc(rect.Right - radius * 2,
                    rect.Bottom - radius * 2,
                    radius * 2, radius * 2, 0, 90);

                path.AddArc(rect.X,
                    rect.Bottom - radius * 2,
                    radius * 2, radius * 2, 90, 90);

                path.CloseFigure();

                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                Region = new Region(path);
            }
        }
    }
}