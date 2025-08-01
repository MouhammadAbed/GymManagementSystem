using CustomMessageBox;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Members.controls;
using Fitness_project.trainers;
using Fitness_project.users.controls;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses
{
    public class clsCustomTabControl : MaterialTabControl
    {
        private Color selectedTabColor = Color.FromArgb(33, 150, 243);
        private Color unselectedTabColor = Color.FromArgb(240, 240, 240);
        private Color selectedTextColor = Color.White;
        private Color unselectedTextColor = Color.FromArgb(100, 100, 100);
        private Color hoverTabColor = Color.DarkSlateGray;
        private Color underlineColor = Color.Red;
        private int underlineHeight = 3;
        private int hoveredTabIndex = -1;

        
        private ctrFindUser _usersControl;
        private ctrFindMember _membersControl;
        private ctrFindTrainer _trainersControl;
        
        public clsCustomTabControl()
        {
            this.BackColor = Color.Black;
            this.Dock = DockStyle.Fill;
            this.Height = 80;
            this.ItemSize = new Size(150, 36);
            this.SizeMode = TabSizeMode.Fixed;
            this.Appearance = TabAppearance.Normal;
            this.Multiline = true;
            InitializeTabs();

            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void InitializeTabs()
        {
            var tabUsers = new TabPage("Users") { Padding = new Padding(3) };
            var tabMembers = new TabPage("Members") { Padding = new Padding(3) };
            var tabTrainers = new TabPage("Trainers") { Padding = new Padding(3) };


            _usersControl = new ctrFindUser();
            _membersControl = new ctrFindMember();
            _trainersControl = new ctrFindTrainer();


            _usersControl.Dock = DockStyle.Fill;
            _membersControl.Dock = DockStyle.Fill;
            _trainersControl.Dock = DockStyle.Fill;


            tabUsers.Controls.Add(_usersControl);
            tabMembers.Controls.Add(_membersControl);
            tabTrainers.Controls.Add(_trainersControl);
            

            this.TabPages.Add(tabUsers);
            this.TabPages.Add(tabMembers);
            this.TabPages.Add(tabTrainers);


            foreach (TabPage tab in this.TabPages)
                tab.BackColor = Color.FromArgb(30, 30, 30);
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle tabBounds = GetTabRect(e.Index);
            bool isSelected = (e.Index == this.SelectedIndex);

            Color backColor = isSelected ? selectedTabColor :
                              (e.Index == hoveredTabIndex ? hoverTabColor : unselectedTabColor);
            Color textColor = isSelected ? selectedTextColor : unselectedTextColor;

            using (Brush bgBrush = new SolidBrush(backColor))
                g.FillRectangle(bgBrush, tabBounds);

            string tabText = this.TabPages[e.Index].Text;
            using (Brush textBrush = new SolidBrush(textColor))
            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                g.DrawString(tabText, new Font("Segoe UI", 12, FontStyle.Bold), textBrush, tabBounds, sf);

            if (isSelected)
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

            switch (this.SelectedIndex)
            {
                case 0: // Users
                    _usersControl.EnableFilter = clsPermissions.CheckAccessRights(
                        clsGlobalUser.CurrentUser.Permissions,
                        clsPermissions.enPermissions.enUserTabs
                    );
                    break;

                case 1: // Members
                    _membersControl.EnableFilter = clsPermissions.CheckAccessRights(
                        clsGlobalUser.CurrentUser.Permissions,
                        clsPermissions.enPermissions.enMembersTabs
                    );
                    break;

                case 2: // Trainers
                    _trainersControl.EnableFilter = clsPermissions.CheckAccessRights(
                        clsGlobalUser.CurrentUser.Permissions,
                        clsPermissions.enPermissions.enTrainersTab
                    );
                    break;
            }

            this.SelectedTab?.Refresh();
            this.Invalidate();
        } 
    }
}