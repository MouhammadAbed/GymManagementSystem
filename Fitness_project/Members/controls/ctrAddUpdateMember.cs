using CustomMessageBox;
using Fitness_project.GlobalClasses;
using Fitness_project.users.controls;
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
    public partial class ctrAddUpdateMember : UserControl
    {
        clsMembers  _Member=new clsMembers();
        UserControl _PreviousControl = null;
        int _PersonId = -1;
        public ctrAddUpdateMember(UserControl previousControl=null)
        {
            InitializeComponent();
            _PreviousControl = previousControl;
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            _Member.person_id = ctrFindPerson2.exposePersonId;
            _Member.status = true;
            _Member.addByUser = clsGlobalUser.CurrentUser.PersonID;
            if(RJMessageBox.Show("Do you want to save the member information?", "Confirm Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_Member.Save())
                {
                    if(_PreviousControl != null)
                    {
                        _ReturnToMembersList();
                    }
                    RJMessageBox.Show("Member information has been saved successfully.", "Save Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }
        private void _ReturnToMembersList()
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
        private void ctrFindPerson2_onPersonSelected(int obj)
        {
            _PersonId = obj;
            clsMembers findMember = clsMembers.FindMemberByPersonId(obj);
            if (findMember != null)
            {
                RJMessageBox.Show($"A member already exists for the selected person (ID: {obj}) ", "Duplicate member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnAddMember.Enabled = (_PersonId>0);
        }
    }
}
