using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoMover
{
    public class ThemedTabControl : TabControl
    {
        private AppTheme? _theme;

        public ThemedTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void SetTheme(AppTheme theme)
        {
            _theme = theme;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_theme == null)
            {
                base.OnPaint(e);
                return;
            }

            Graphics g = e.Graphics;
            
            // Fill entire background with form background color
            using (SolidBrush backBrush = new SolidBrush(_theme.FormBackground))
            {
                g.FillRectangle(backBrush, ClientRectangle);
            }

            // Draw the tabs
            for (int i = 0; i < TabCount; i++)
            {
                DrawTab(g, i);
            }

            // Draw border around entire control
            using (Pen borderPen = new Pen(_theme.BorderColor, 1))
            {
                Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                g.DrawRectangle(borderPen, borderRect);
            }

            // Draw the selected tab page content area background
            if (SelectedTab != null)
            {
                Rectangle contentRect = DisplayRectangle;
                using (SolidBrush contentBrush = new SolidBrush(_theme.ControlBackground))
                {
                    g.FillRectangle(contentBrush, contentRect);
                }
            }
        }

        private void DrawTab(Graphics g, int index)
        {
            if (_theme == null) return;

            Rectangle tabRect = GetTabRect(index);
            bool isSelected = (SelectedIndex == index);

            // Fill tab background
            using (SolidBrush tabBrush = new SolidBrush(isSelected ? _theme.ControlBackground : _theme.FormBackground))
            {
                g.FillRectangle(tabBrush, tabRect);
            }

            // Draw borders
            if (isSelected)
            {
                // Top highlight for selected tab
                using (Pen highlightPen = new Pen(_theme.ButtonPrimary, 3))
                {
                    g.DrawLine(highlightPen, tabRect.Left, tabRect.Top + 1, tabRect.Right, tabRect.Top + 1);
                }

                // Side borders
                using (Pen sidePen = new Pen(_theme.BorderColor, 1))
                {
                    g.DrawLine(sidePen, tabRect.Left, tabRect.Top, tabRect.Left, tabRect.Bottom);
                    g.DrawLine(sidePen, tabRect.Right - 1, tabRect.Top, tabRect.Right - 1, tabRect.Bottom);
                }
            }
            else
            {
                // Bottom border for unselected tabs
                using (Pen bottomPen = new Pen(_theme.BorderColor, 1))
                {
                    g.DrawLine(bottomPen, tabRect.Left, tabRect.Bottom - 1, tabRect.Right, tabRect.Bottom - 1);
                }
            }

            // Draw text
            string tabText = TabPages[index].Text;
            using (SolidBrush textBrush = new SolidBrush(isSelected ? _theme.ControlText : _theme.HelpText))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(tabText, Font, textBrush, tabRect, sf);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Don't paint background, we handle it in OnPaint
        }
    }
}
