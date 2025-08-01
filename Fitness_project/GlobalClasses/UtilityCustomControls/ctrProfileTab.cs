using CustomMessageBox;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.users.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses
{
    public partial class ctrProfileTab : UserControl
    {
        private clsCustomTabControl customTabControl;
        private CustomTabSelector customTabSelector;
        public ctrProfileTab()
        {
            InitializeComponent();
            InitializeCustomTabs();
            
        }
        private void InitializeCustomTabs()
        {
            customTabControl = new clsCustomTabControl
            {
                Dock = DockStyle.Fill
            };

            customTabSelector = new CustomTabSelector
            {
                BaseTabControl = customTabControl,
                Dock = DockStyle.Top,
                Height = 36,
                BackColor = System.Drawing.Color.FromArgb(23, 21, 32)
            };

            customTabControl.SelectedIndexChanged += (s, e) =>
            {
                customTabControl.SelectedTab?.Refresh();
                customTabControl.Invalidate();
            };

            this.Controls.Add(customTabControl);
            this.Controls.Add(customTabSelector);
        }
        public void SwitchToProfileTab(int index)
        {
           
            if (index >= 0 && index < customTabControl.TabCount)
            {
                customTabControl.SelectedIndex = index;
            }
        }            
    }
}
