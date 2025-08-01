using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.Members.controls
{
    public partial class ctrShowMemberInfo : UserControl
    {
        UserControl _previousControl = null;
        int _PersonId;
        public ctrShowMemberInfo(int personId, UserControl prevUserControl)
        {
            InitializeComponent();
            _previousControl = prevUserControl;
            _PersonId = personId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent is Panel mainPanel)
            {
                mainPanel.Controls.Clear();
                _previousControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(_previousControl);
            }
            else if (this.Parent is Control p && p.Parent is Panel panel)
            {
                panel.Controls.Clear();
                _previousControl.Dock = DockStyle.Fill;
                panel.Controls.Add(_previousControl);
            }
        }

        private void ctrShowMemberInfo_Load(object sender, EventArgs e)
        {
            ctrMemberInfo1.LoadMemberByPersonid(_PersonId);
        }
    }
}
