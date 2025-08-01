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
    public partial class DynamicTabControl : MaterialTabControl
    {
        private Color selectedTabColor = Color.FromArgb(33, 150, 243);
        private Color unselectedTabColor = Color.FromArgb(240, 240, 240);
        private Color selectedTextColor = Color.White;
        private Color unselectedTextColor = Color.FromArgb(100, 100, 100);
        private Color hoverTabColor = Color.DarkSlateGray;
        private Color underlineColor = Color.Red;
        private int underlineHeight = 3;
        private int hoveredTabIndex = -1;

        public DynamicTabControl()
        {
            this.Dock = DockStyle.Fill;
            this.ItemSize = new Size(150, 36);
            this.SizeMode = TabSizeMode.Fixed;
            this.Appearance = TabAppearance.Normal;
            this.Multiline = false;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Selecting += DynamicTabControl_Selecting;
        }

        // Prevent selecting disabled tab
        private void DynamicTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
                e.Cancel = true;
        }
        public void AddDynamicTab(string tabTitle, Control content)
        {
            var newTab = new TabPage(tabTitle) { Padding = new Padding(3) };
            content.Dock = DockStyle.Fill;
            newTab.Controls.Add(content);
            newTab.BackColor = Color.FromArgb(30, 30, 30);
            newTab.ForeColor = Color.White;
            this.TabPages.Add(newTab);
            this.Invalidate();
        }
        public void EnableTab(int index, bool enable)
        {
            if (index >= 0 && index < this.TabPages.Count)
            {
                this.TabPages[index].Enabled = enable;
                this.Invalidate();
            }
        }
        public void EnableTab(string tabText, bool enable)
        {
            foreach (TabPage tab in this.TabPages)
            {
                if (tab.Text == tabText)
                {
                    tab.Enabled = enable;
                    this.Invalidate();
                    break;
                }
            }
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle tabBounds = GetTabRect(e.Index);
            bool isSelected = (e.Index == this.SelectedIndex);
            bool isEnabled = this.TabPages[e.Index].Enabled;

            Color backColor = isSelected ? selectedTabColor :
                              (e.Index == hoveredTabIndex ? hoverTabColor : unselectedTabColor);
            Color textColor = isSelected ? selectedTextColor : unselectedTextColor;

            if (!isEnabled)
            {
                backColor = Color.Gray;
                textColor = Color.DarkGray;
            }

            using (Brush bgBrush = new SolidBrush(backColor))
                g.FillRectangle(bgBrush, tabBounds);

            string tabText = this.TabPages[e.Index].Text;
            using (Brush textBrush = new SolidBrush(textColor))
            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                g.DrawString(tabText, new Font("Segoe UI", 10, FontStyle.Bold), textBrush, tabBounds, sf);

            if (isSelected && isEnabled)
            {
                Rectangle underlineRect = new Rectangle(tabBounds.X, tabBounds.Bottom - underlineHeight, tabBounds.Width, underlineHeight);
                using (Brush underlineBrush = new SolidBrush(underlineColor))
                    g.FillRectangle(underlineBrush, underlineRect);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            for (int i = 0; i < this.TabCount; i++)
            {
                if (GetTabRect(i).Contains(e.Location))
                {
                    if (hoveredTabIndex != i)
                    {
                        hoveredTabIndex = i;
                        Invalidate();
                    }
                    return;
                }
            }

            if (hoveredTabIndex != -1)
            {
                hoveredTabIndex = -1;
                Invalidate();
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoveredTabIndex = -1;
            Invalidate();
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.SelectedTab?.Refresh();
            this.Invalidate();
        }
    }
}
