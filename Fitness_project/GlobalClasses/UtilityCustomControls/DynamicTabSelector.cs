using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses.UtilityCustomControls
{
    public partial class DynamicTabSelector : Control
    {
        public MaterialTabControl TargetTabControl { get; set; }

        public Color SelectedColor { get; set; } = Color.FromArgb(33, 150, 243);
        public Color UnselectedColor { get; set; } = Color.FromArgb(240, 240, 240);
        public Color SelectedTextColor { get; set; } = Color.White;
        public Color UnselectedTextColor { get; set; } = Color.FromArgb(100, 100, 100);

        public DynamicTabSelector()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.Height = 36;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (TargetTabControl == null || TargetTabControl.TabCount == 0) return;

            Graphics g = e.Graphics;
            g.Clear(this.BackColor);

            int tabCount = TargetTabControl.TabCount;
            int tabWidth = this.Width / tabCount;

            for (int i = 0; i < tabCount; i++)
            {
                var tabBounds = new Rectangle(i * tabWidth, 0, tabWidth, this.Height);
                bool isSelected = TargetTabControl.SelectedIndex == i;

                using (Brush backBrush = new SolidBrush(isSelected ? SelectedColor : UnselectedColor))
                    g.FillRectangle(backBrush, tabBounds);

                string text = TargetTabControl.TabPages[i].Text;
                using (Brush textBrush = new SolidBrush(isSelected ? SelectedTextColor : UnselectedTextColor))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    g.DrawString(text, Font, textBrush, tabBounds, sf);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (TargetTabControl == null || TargetTabControl.TabCount == 0) return;

            int tabWidth = this.Width / TargetTabControl.TabCount;
            int index = e.X / tabWidth;

            if (index >= 0 && index < TargetTabControl.TabCount)
            {
                TargetTabControl.SelectedIndex = index;
                this.Invalidate();
            }
        }
    }
}
