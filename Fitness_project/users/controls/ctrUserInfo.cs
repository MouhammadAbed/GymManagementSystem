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

namespace Fitness_project.Categories.ShowCategoriesInfo
{
    public partial class ctrUserInfo : UserControl
    {
        clsUser _user = new clsUser();
        int _UserId = -1;

        public int UserId
        {
            get { return _UserId; }
        }
        private void ApplyLocalization()
        {
            lblPersonId.Text = Strings.lblPersonId;
            lblUsername.Text = Strings.lblUsername;
           
        }
        public ctrUserInfo()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        private void _ResetDefaultSettings()
        {
            ctrPersonInfo21.ResetDefaultSettinghs();
            txtUserId.Text = "?????";
            txtUserName.Text = "?????";
            _UserId = -1;
        }
        private void _FillUserInfo()
        {            
            ctrPersonInfo21.LoadPersonInfo(_user.PersonID,_user.FirstName,_user.LastName,_user.Phone,_user.GenderText);
            txtUserId.Texts = _user.UserID.ToString();
            txtUserName.Texts = _user.userName;
            _UserId = _user.UserID;
        }
        public void LoadUserbyUserID(int UserID)
        {
            _UserId= UserID;
            _user = clsUser.FindUser(UserID);
            if (_user != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();

        }
        public void LoadUserbyPersonId(int PersonId)
        {
            _user = clsUser.FindUserByPersonID(PersonId);
            if (_user != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();
        }
        public void loadUserByName(string userName)
        {          
            _user =clsUser.FindUser(userName); 
            if (_user != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();    
        }
    }
}
