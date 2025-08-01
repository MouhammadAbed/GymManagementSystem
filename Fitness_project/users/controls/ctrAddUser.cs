using CustomMessageBox;
using Fitness_project.GlobalClasses;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Localization;
using FitnessBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.users.controls
{
    public partial class ctrAddUser : UserControl
    {

        enum enMode { enUpdate =1,enAdd=2};
        enMode _Mode = enMode.enUpdate;
        clsUser _User;
        int _PersonId=0;
        int PermissionsCount = 0;
        UserControl _currentuser = null;

        private void ApplyLocalization()
        {
            lblAddNewUser.Text = Strings.lblAddNewUser;            
            btnSave.Text = Strings.btnSave;
            btnNext.Text = Strings.btnNext;
            lblUsername.Text = Strings.lblUsername;
            lblPassword.Text = Strings.lblPassword;
            lblValidatePassword.Text = Strings.lblValidatePassword;
            chbfullAccess.Text= Strings.chbfullAccess;
            chbUsersTab.Text = Strings.chbUsersTab;
            chbMembersTab.Text = Strings.chbMembersTab;
            chbTrainersTab.Text= Strings.chbTrainersTab;
            chbCategoriesTab.Text=Strings.chbCategoriesTab;
            chbSubscriptionsTab.Text = Strings.chbSubscriptionsTab;
            chbAuditTab.Text= Strings.chbAuditTab;
            gbPermission.Text=Strings.gbPermission;
            tbPersonInfo.Text= Strings.tbPersonInfo;
            tbUser.Text= Strings.tbUser;
            
        }
        public ctrAddUser(UserControl currentuser=null)
        {
            InitializeComponent();
            _Mode = enMode.enAdd;
            foreach (var control in gbPermission.Controls)
            {
                if (control is CheckBox cb)
                {
                    cb.CheckedChanged += CheckChanged;
                }
            }
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tbUser.Enabled = false;
            this._currentuser = currentuser;
        }
        public ctrAddUser(int id,UserControl currentuser=null)
        {
            InitializeComponent();
            _Mode = enMode.enUpdate;
            _PersonId = id;
            
            foreach (var control in gbPermission.Controls)
            {
                if (control is CheckBox cb)
                {
                    cb.CheckedChanged += CheckChanged;
                }
            }
            _currentuser= currentuser;
        }
        private void _FillUserInfo()
        {
            ctrFindPerson1.LoadPerson(_PersonId);
            ctrFindPerson1.Enabled = false;
            lblAddNewUser.Text = "UPDATE USER INFO";
            txtUsername.Texts = _User.userName;

            if (_User.Permissions ==(int) clsPermissions.enPermissions.enAll)
            {
                foreach(var control in gbPermission.Controls)
                {
                    if(control is CheckBox ch)
                    {
                        ch.Checked = true;
                    }
                }
                return;
            }
            else
            {
                chbUsersTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enUserTabs)) == Convert.ToInt32(chbUsersTab.Tag)) ? true : false;
                chbMembersTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enMembersTabs)) == Convert.ToInt32(chbMembersTab.Tag)) ? true : false;
                chbTrainersTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enTrainersTab)) == Convert.ToInt32(chbTrainersTab.Tag)) ? true : false;
                chbCategoriesTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enCategoriesTab)) == Convert.ToInt32(chbCategoriesTab.Tag)) ? true : false;
                chbSubscriptionsTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enSubscriptionTab)) == Convert.ToInt32(chbSubscriptionsTab.Tag)) ? true : false;
                chbAuditTab.Checked = ((_User.Permissions & Convert.ToInt32(clsPermissions.enPermissions.enAuditTab)) == Convert.ToInt32(chbAuditTab.Tag)) ? true : false;
            }
        }
        private void _LoadInfo()
        {
            if (_Mode==enMode.enAdd)
            {
                _User= new clsUser();
                lblAddNewUser.Text = "ADD NEW USER";
                return;
            }
            _User = clsUser.FindUserByPersonID(_PersonId);
            if(_User==null)
            {
                RJMessageBox.Show("The user has been deleted. Please enter a different value.", Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           _FillUserInfo();
            ctrFindPerson1_onPersonSelected(_PersonId);
        }
        private void ctrAddUser_Load(object sender, EventArgs e)
        {
            ApplyLocalization();    
            _LoadInfo();            
        }
        private void _CheckAllBoxes(bool ToChecked)
        {
            foreach (var control in gbPermission.Controls)
            {
                if (control is CheckBox ch)
                {
                    ch.Checked =ToChecked;
                }
            }
        }
        private void _CalculatePermissions()
        {
            PermissionsCount = gbPermission.Controls
           .OfType<CheckBox>()
           .Where(cb => cb.Checked)
           .Sum(cb => Convert.ToInt32(cb.Tag));
            if (PermissionsCount == 126)
            {
                PermissionsCount = (int)clsPermissions.enPermissions.enAll;
                _CheckAllBoxes(true);
            }
        }
        private void CheckChanged(object sender, EventArgs e)
        {
            int PreviousPermissions=PermissionsCount;
            CheckBox clicked = sender as CheckBox;

             if (clicked == chbfullAccess && clicked.Checked)
            {
                _CheckAllBoxes(true);
            }
            else if(clicked!=chbfullAccess && clicked.Checked) 
            {
                if (PermissionsCount == 126)
                {
                    chbfullAccess.Checked = true;
                }
            }
            else
            {
                if (PreviousPermissions == 1)
                {
                    chbfullAccess.Checked = false;
                }
            }
            _CalculatePermissions();
        }
        private void ctrFindPerson1_onPersonSelected(int obj)
        {
            if (_Mode == enMode.enAdd)
            {
                if (obj > 0)
                {
                    clsUser findUser = clsUser.FindUserByPersonID(obj);
                    if (findUser != null)
                    {
                        RJMessageBox.Show(Strings.rjUserExist, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnNext.Enabled = true;
                    btnSave.Enabled = true;
                    tbUser.Enabled = true;
                }
                else
                {
                    btnNext.Enabled = false;
                    btnSave.Enabled = false;
                    tbUser.Enabled = false;
                }
            }
            else
            {
                btnNext.Enabled = true;
                btnSave.Enabled = true;
                tbUser.Enabled = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tbaddUser.SelectedIndex = 1;
        }
        private void txtValidating(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == null)
                return;
            if (string.IsNullOrEmpty(t.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(t, Strings.RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(t, null);
            }
        }
        private void _saveUserInfo()
        {
            _User.PersonID = ctrFindPerson1.exposePersonId;
            _User.userName=txtUsername.Texts;
            _User.Password = clsUtil.ComputedHash(txtPassword.Texts);
            _User.Permissions = PermissionsCount;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            if (PermissionsCount == 0)
            {
                RJMessageBox.Show(Strings.rjAssingOneAtLeast, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RJMessageBox.Show(Strings.rjAskToSaveUser,Strings.InvalidInputTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _saveUserInfo();
                if (_User.Save())
                {
                    RJMessageBox.Show(Strings.rjSaveUser, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_currentuser == null)
                    {
                        lblAddNewUser.Text = "UPDATE USER INFO";
                        _Mode = enMode.enUpdate;
                    }
                    else
                    {
                        _ReturnToUsersList();
                    }
                }
            }
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if ((String.IsNullOrEmpty(txtUsername.Texts))|| (clsUser.isUserNameExist(txtUsername.Texts)&&txtUsername.Texts!=_User.userName))
            {
                e.Cancel= true;
                errorProvider1.SetError(txtUsername, Strings.RequiredField);
            }
            else
            {
                e.Cancel = false;
               errorProvider1.SetError(txtUsername,null);
            }
        }
        private void txtValidatePassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtValidatePassword.Texts)||txtValidatePassword.Texts!=txtPassword.Texts)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtValidatePassword,Strings.rjConvfimPasswordNotMatch);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtValidatePassword,null);
            }
        }
        private void _ReturnToUsersList()
        {
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                ctrUsersList usersList = new ctrUsersList();
                usersList.Dock = DockStyle.Fill;
                parent.Controls.Add(usersList);
            }
        }

    }
}
