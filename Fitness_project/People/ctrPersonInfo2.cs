using CustomMessageBox;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Localization;
using Fitness_project.Properties;
using fitnessDataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.personControls
{
    public partial class ctrPersonInfo2 : UserControl
    {
        bool _isReadOnly=false;

        public bool isReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; }
        }
        int _personId = -1;
        clsPeople _findPerson;
        public int exposePersonId
        {
            get { return _personId; }
        }
        public clsPeople exposePersonInfo
        {
            get { return _findPerson; }
        }
        public ctrPersonInfo2()
        {
            InitializeComponent();
            ApplyLocalization();
            isTextBoxReadOnly();
        }
        private void ApplyLocalization()
        {
            lblFirstName.Text = Strings.lblFirstName;
            lblSecondName.Text = Strings.lblSecondName;
            lblLastName.Text = Strings.lblLastName;
            lblPhoneNumber.Text = Strings.lblPhoneNumber;
            lblGender.Text = Strings.lblGender;           
        }
        public void ResetDefaultSettinghs()
        {
            _personId = -1;
            txtFirstName.Text = "[?????]";
            txtSecondName.Text = "[?????]";
            txtLastName.Text = "[?????]";
            txtPhone.Text = "[?????]";
            txtGender.Text = "[?????]";
            pbPicture.Image = Resources.man1;
        }     
        private void _FillPersonInfo(clsPeople person)
        {
            if (person == null)
            { 
                ResetDefaultSettinghs();
                return;
            }
            _personId = person.PersonID;
            txtFirstName.Text = person.FirstName;
            txtSecondName.Text = person.SecondName;
            txtLastName.Text = person.LastName;
            txtPhone.Text = person.Phone;
            txtGender.Text = person.GenderText;
            pbPicture.Image = txtGender.Text == "Male" ? Resources.man1 : Resources.woman;
        }
        private void isTextBoxReadOnly()
        {
            txtFirstName.ReadOnly = _isReadOnly;
            txtSecondName.ReadOnly=_isReadOnly;
            txtLastName.ReadOnly=_isReadOnly;
            txtPhone.ReadOnly=_isReadOnly;
            txtGender.ReadOnly=_isReadOnly;
        }
        public void LoadPersonInfo(int personId,string firstName,string lastName,string phone,string gender)
        {
            _personId = personId;
            if (personId >0 )
            {
                _findPerson = clsPeople.FindPerson(personId);
                _FillPersonInfo(_findPerson);
            }
            else
            {
                ResetDefaultSettinghs();
            }
        }
        public void LoadPersonInfo(int PersonId)
        {
            if (PersonId > 0)
            {
                _findPerson=clsPeople.FindPerson(PersonId);
                _FillPersonInfo( _findPerson);
            }
            else
            {
                ResetDefaultSettinghs();
            }
        }
        public void LoadPersonInfo(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                clsNamePart nameParts = clsNamePart.ParseFullName(name);
                if(nameParts == null)
                {
                    RJMessageBox.Show(Strings.InvalidInputMessage,Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _findPerson = clsPeople.FindPerson(nameParts.firstName,nameParts.secondName,nameParts.lastName);
                _FillPersonInfo(_findPerson);
            }
            else
            {
                ResetDefaultSettinghs();
            }
        }
    }
}
