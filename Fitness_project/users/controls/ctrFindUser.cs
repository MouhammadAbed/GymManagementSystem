using CustomMessageBox;
using Fitness_project.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.users.controls
{
    public partial class ctrFindUser : UserControl
    {
        string _selectedText;
        string _value;

        public event Action<int> onUserSelected;
        protected virtual void User_Selected(int userId)
        {
            onUserSelected?.Invoke(userId);
        }
        bool enable = true;
        public bool EnableFilter
        {
            set
            {
                enable = value;
                gbFilter.Enabled = enable;
                cbFilter.SelectedIndex = 1;
            }
        }
        private void ApplyLocalization()
        {
            lblSearchBy.Text = Strings.lblSearchBy;
            btnSearch.Text = Strings.btnSearch;
        }
        public ctrFindUser()
        {
            InitializeComponent();
        }
        public void SetFocus()
        {
            txtValue.Focus();
        }
        private void _FindNow()
        {
            int value = 0;
            int foundUserId = -1;
            _value = txtValue.Text;
            switch (cbFilter.SelectedIndex)
            {                
                case 0:
                    int.TryParse(txtValue.Text.Trim(), out value);
                    ctrUserInfo1.LoadUserbyPersonId(value);
                    foundUserId = ctrUserInfo1.UserId;
                    break;
                default:
                    ctrUserInfo1.loadUserByName(txtValue.Text);
                    foundUserId = ctrUserInfo1.UserId;
                    break;
            }
            if (foundUserId <= 0)
            {
                RJMessageBox.Show(Strings.rjUserNotFound, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
            User_Selected(foundUserId);
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void ctrFindUser_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
            cbFilter.SelectedIndex = 1;
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedText = cbFilter.Text;
            SetFocus();
            txtValue.Text = "";
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                RJMessageBox.Show(Strings.rjRquiredTextBox,
                Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }

    }
}
