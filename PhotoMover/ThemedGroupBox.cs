using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoMover
{
    public class ThemedGroupBox : GroupBox
    {
        private AppTheme? _theme;

        public ThemedGroupBox()
        {
            SetStyle(ControlStyles.UserPaint | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor | 
                     ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void SetTheme(AppTheme theme)
        {
            _theme = theme;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_theme == null)
            {
                base.OnPaint(e);
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Measure text
            SizeF textSize = g.MeasureString(this.Text, this.Font);
            int textPadding = 8;
            int borderPadding = 8;

            // Clear background
            using (SolidBrush backBrush = new SolidBrush(this.Parent?.BackColor ?? _theme.FormBackground))
            {
                g.FillRectangle(backBrush, this.ClientRectangle);
            }

            // Draw border rectangle (starting below the text)
            Rectangle borderRect = new Rectangle(
                1,
                (int)(textSize.Height / 2),
                this.Width - 2,
                this.Height - (int)(textSize.Height / 2) - 1
            );

            using (Pen borderPen = new Pen(_theme.BorderColor, 1))
            {
                g.DrawRectangle(borderPen, borderRect);
            }

            // Draw text background to "cut" the border
            Rectangle textRect = new Rectangle(
                borderPadding,
                0,
                (int)textSize.Width + textPadding * 2,
                (int)textSize.Height
            );

            using (SolidBrush textBackBrush = new SolidBrush(this.Parent?.BackColor ?? _theme.FormBackground))
            {
                g.FillRectangle(textBackBrush, textRect);
            }

            // Draw text
            using (SolidBrush textBrush = new SolidBrush(_theme.GroupBoxText))
            {
                g.DrawString(this.Text, this.Font, textBrush, borderPadding + textPadding, 0);
            }
        }
    }
}
