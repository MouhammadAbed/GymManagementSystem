using CustomMessageBox;
using Fitness_project.GlobalClasses.Utility;
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

namespace Fitness_project.Members.controls
{
   
    public partial class ctrMemberInfo : UserControl
    {
        clsMembers _member=new clsMembers();
        int _memberId = -1;

        public int MemberId
        {
            get { return _memberId; }
        }
        public ctrMemberInfo()
        {
            InitializeComponent();
            lblStatus.Text = Strings.lblStatus;
        }
        private void _ResetDefaultSettings()
        {
            ctrPersonInfo21.ResetDefaultSettinghs();
            txtStatus.Text = "?????";
            _memberId = -1;
        }
        private void _FillUserInfo()
        {
            ctrPersonInfo21.LoadPersonInfo(_member.person_id, _member.FirstName, _member.LastName, _member.Phone, _member.GenderText);
            txtStatus.Text = _member.StatusString;
            _memberId = _member.id;
        }
        public void LoadMemberbyMemberId(int memberID)
        {
            _member = clsMembers.FindMember(memberID);
            if (_member != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();

        }
        public void LoadMemberByPersonid(int PersonId)
        {
            _member=clsMembers.FindMemberByPersonId(PersonId);
            if(_member != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();
        }
        public void LoadMemberByName(string fullName)
        {
            clsNamePart namePart = clsNamePart.ParseFullName(fullName);
            if (namePart == null)
            {
                RJMessageBox.Show("Something went wrong. Please insert a valid input.", "Invalid imput", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _member = clsMembers.FindMember(namePart.firstName,namePart.secondName,namePart.lastName);
            if (_member != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();
        }
    }
}
