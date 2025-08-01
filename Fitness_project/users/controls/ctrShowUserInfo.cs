using Fitness_project.Localization;
using FitnessBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.users.controls
{
    public partial class ctrShowUserInfo : UserControl
    {
        public event EventHandler OnCloseClicked;
        private UserControl _previousControl;
        int _personId;
        private void ApplyLocalization()
        {
            lblShowUserInfo.Text = Strings.lblShowUserInfo;      
            btnClose.Text = Strings.btnClose;
        }
        public ctrShowUserInfo(int personId,UserControl u)
        {
            InitializeComponent();
            _personId = personId;
            _previousControl = u;
        }     
        private void ctrShowUserInfo_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
            ctrUserInfo1.LoadUserbyPersonId(_personId);            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
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
    }
}
