using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses
{
    public class CustomTabSelector : MaterialTabSelector
    {
        public Color SelectedColor { get; set; } = Color.FromArgb(33, 150, 243);
        public Color UnselectedColor { get; set; } = Color.FromArgb(240, 240, 240);
        public Color SelectedTextColor { get; set; } = Color.White;
        public Color UnselectedTextColor { get; set; } = Color.FromArgb(100, 100, 100);

        public CustomTabSelector()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.BackColor = Color.FromArgb(240, 240, 240); // Light background
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (BaseTabControl == null || BaseTabControl.TabCount == 0) return;

            Graphics g = e.Graphics;
            g.Clear(this.BackColor);

            for (int i = 0; i < BaseTabControl.TabCount; i++)
            {
                var tabBounds = GetTabRect(i);
                bool isSelected = BaseTabControl.SelectedIndex == i;

                using (Brush backBrush = new SolidBrush(isSelected ? SelectedColor : UnselectedColor))
                    g.FillRectangle(backBrush, tabBounds);

                string text = BaseTabControl.TabPages[i].Text;
                using (Brush textBrush = new SolidBrush(isSelected ? SelectedTextColor : UnselectedTextColor))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    g.DrawString(text, Font, textBrush, tabBounds, sf);
            }
        }

        private Rectangle GetTabRect(int index)
        {
            int tabWidth = 150;
            return new Rectangle(index * tabWidth, 0, tabWidth, this.Height);
        }
    }
}
