using CustomMessageBox;
using Fitness_project.Localization;
using Fitness_project.People;
using Fitness_project.Properties;
using Fitness_project.Subscription;
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

namespace Fitness_project.Categories.ShowCategoriesInfo
{
    public partial class ctrAddUpdatePerson : UserControl
    {
        public delegate void PersonDataBackEventHandler(object sender, clsPeople person);
        public PersonDataBackEventHandler PersonDataBack;
        private bool _allowValidation = false;
        enum enMode { enUpdate = 1, enAdd = 2 }
        enMode _Mode = enMode.enUpdate;
        clsPeople person;
        int _PersonId;
        private UserControl _previousControl;
        private void ApplyLocalization()
        {
            lblPersonId.Text = Strings.lblPersonId;
            lblFirstName.Text = Strings.lblFirstName;
            lblSecondName.Text = Strings.lblSecondName;
            lblLastName.Text = Strings.lblLastName;
            lblPhoneNumber.Text = Strings.lblPhoneNumber;
            lblGender.Text = Strings.lblGender;
            btnSave.Text = Strings.btnSave;
            btnClose.Text = Strings.btnClose;
            rbFemale.Text = Strings.rbFemale;
            rbMale.Text = Strings.rbMale;
        }
        public ctrAddUpdatePerson(UserControl previousControl)
        {
            InitializeComponent();
            _previousControl = previousControl;
            _Mode = enMode.enAdd;
        }
        public ctrAddUpdatePerson(int personId , UserControl previousControl)
        {
            InitializeComponent();
            _previousControl =previousControl;
            _PersonId = personId;
            _Mode = enMode.enUpdate;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            ShowPreviousControl();
        }      
        private void _LoadPersonInfo()
        {
            if(_Mode == enMode.enAdd)
            {
                person = new clsPeople();
                lblTitle.Text = "ADD NEW PERSON";
                return;
            }
            person=clsPeople.FindPerson(_PersonId);
            if (person != null)
            {
                lblTitle.Text = "EDIT PERSON INFO";
                txtPersonId.Text = _PersonId.ToString();
                txtFirstName.Text = person.FirstName;
                txtSecondName.Text = person.SecondName;
                txtLastName.Text=person.LastName;
                txtPhone.Text = person.Phone;
                rbMale.Checked = person.gender == true? true :false;
                rbFemale.Checked=person.gender == true? false :true;
            }
        }
        private void _FillPersonInfo()
        {
            person.FirstName = txtFirstName.Text.Trim().Replace(" ", "-");
            person.SecondName = txtSecondName.Text.Trim().Replace(" ", "-");
            person.LastName = txtLastName.Text.Trim().Replace(" ", "-");
            person.Phone= txtPhone.Text;
            person.gender=rbMale.Checked?true:false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _allowValidation = true;
            if (!this.ValidateChildren())
            {
                RJMessageBox.Show(Strings.RequiredField, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allowValidation = false;
                return;
            }
            string fullName = string.Join(" ",
            new[] { txtFirstName.Text.Trim().Replace(" ", "-"), txtSecondName.Text.Trim().Replace(" ", "-"), txtLastName.Text.Trim().Replace(" ", "-") }
            .Where(part => !string.IsNullOrEmpty(part)));
            int PersonId = clsPeople.GetPersonIDByName(fullName);
            if (PersonId != 0)
            {
                RJMessageBox.Show(Strings.NameExist, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RJMessageBox.Show(Strings.SavePerson, Strings.InvalidInputTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _FillPersonInfo();
                if (person.baseSave())
                {
                    _Mode = enMode.enUpdate;
                    RJMessageBox.Show(Strings.PersonAddSuc, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTitle.Text = Strings.rjEditPersonlalbel;
                    txtPersonId.Text = person.PersonID.ToString();
                }
            }
            PersonDataBack?.Invoke(this, person);
            ShowPreviousControl();
        }
        private void ChangePicture()
        {
            pbPicture.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            ChangePicture();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangePicture();
        }
        private void ctrAddUpdatePerson_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
            _LoadPersonInfo();
        }
        private void txtValidating(object sender, CancelEventArgs e)
        {
            if (!_allowValidation)
                return;
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
        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ShowPreviousControl()
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(this);

                if (_previousControl != null && !parent.Controls.Contains(_previousControl))
                {
                    parent.Controls.Add(_previousControl);
                    _previousControl.Dock = DockStyle.Fill;
                }

                _previousControl?.Show();
            }
        }
    }
}
