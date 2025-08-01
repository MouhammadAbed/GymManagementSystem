using CustomMessageBox;
using Fitness_project.GlobalClasses;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Localization;
using Fitness_project.personControls;
using Fitness_project.trainers;
using FitnessBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.Subscription
{
    public partial class ctrAddNewSubscription : UserControl
    {
        enum enMode {enUpdate = 1, enAdd = 2 }
        enMode _Mode = enMode.enUpdate;
        int _SubscriptionId;
        clsSubscription _subscription;

        public struct stSubscription 
        {
            public UserControl _PreviousUserControl;
            public DateTime startDate;
            public DateTime endDate;
            public int monthDuration;
            public decimal categoryFees;
            public decimal fees;
            public int discount;
            public decimal finalFees;
            public int PersonId;
            public int assignmentId;
        }
        stSubscription sub = new stSubscription()
        {
            _PreviousUserControl = null,
            startDate = DateTime.Now,
            monthDuration = 0,
            endDate = DateTime.Now,
            categoryFees=0,
            fees = 0,
            discount = 0,
            finalFees = 0,
            PersonId = 0,
            assignmentId = 0
        };        

        private void ApplyLocalization()
        {
            tbPersonInfo.Text = Strings.tbPersonInfo;
            tbSubsInfo.Text = Strings.tbSubInfo;
            lblTitle.Text = Strings.lblAddNewSub;
            lblMemberName.Text=Strings.lblMemberName;
            lblCategory.Text = Strings.LblCategory;
            lblTrainerName.Text= Strings.lblTrainerName;
            lblStartDate.Text= Strings.lblStartDate;
            lblEndDate.Text= Strings.lblEndDate;    
            lblMonthDuration.Text= Strings.lblMonthDuration;
            lblDiscount.Text= Strings.lblDiscount;
            lblFees.Text= Strings.lblFees;
            lblFinalFees.Text = Strings.lblfees1;
            btnNext.Text = Strings.btnNext;
            btnSave.Text= Strings.btnSave;

        }
        public ctrAddNewSubscription(UserControl userControl = null)
        {
            InitializeComponent();
            ApplyLocalization();
            _Mode = enMode.enAdd;
            sub._PreviousUserControl = userControl;
        }
        public ctrAddNewSubscription(int subscriptionId , UserControl userControl = null)
        {
            InitializeComponent();
            ApplyLocalization();
            sub._PreviousUserControl = userControl;
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tbSubsInfo.Enabled = false;
            _SubscriptionId = subscriptionId;
            _Mode = enMode.enUpdate;
            _LoadInfo();
        }
        private void _FillCategoriesToComboBox()
        {
            if(cmbCategories.Items.Count > 0)
              return;
            DataTable dtCategories = clsCategories.getAllCategories();
            if (dtCategories != null)
            {
                foreach (DataRow row in dtCategories.Rows)
                {
                    cmbCategories.Items.Add(row["Category Name"]);
                }
                cmbCategories.SelectedIndex = 0;
            }
        }
        private void _FillTrainersNameToComboBox()
        {
            cmbTrainers.Items.Clear();
            DataTable dt = clsTrainerCategoryAssignment.GetAllTrainers();
            foreach (DataRow row in dt.Rows)
            {
                if (row["CATEGORY"].ToString() == cmbCategories.Text)
                {
                    cmbTrainers.Items.Add(row["FULL NAME"]);
                }
            }
            if(cmbTrainers.Items.Count > 0)
            {
                cmbTrainers.SelectedIndex = 0;
            }
        }      
        private void _LoadInfo()
        {

            _FillCategoriesToComboBox();
            _FillTrainersNameToComboBox();
            tbSubsInfo.Enabled = true;
            btnNext.Enabled = true;
            btnSave.Enabled = true;
            if (_Mode == enMode.enUpdate)
            {
                lblTitle.Text = "Update Subscription Screen";
                _subscription = clsSubscription.FindSubscriptionBySubsId(_SubscriptionId);
                ctrFindPerson1.Enabled = false;
                ctrFindPerson1.LoadPerson(_subscription.applicationInfo.memberInfo.person_id);
                cmbDiscount.Text = _subscription.discount.ToString();
                cmbMonthDuration.Text = _subscription.monthDuration.ToString();
                dtpSubStartDate.Value = _subscription.subscriptionStartDate;
                dtpSubEndDate.Value = _subscription.subscriptionEndDate;
                cmbCategories.Text = _subscription.applicationInfo.trainerCategoryInfo.categoryInfo.name;
                txtFees.Texts = _subscription.fees.ToString();
                txtFinalFees.Texts = _subscription.finalFees.ToString();
                return;
            }
            lblTitle.Text = "Add Subscription Screen";
            cmbDiscount.SelectedIndex = 0;
            cmbMonthDuration.SelectedIndex = 0;
            sub.startDate = DateTime.Now;
            sub.monthDuration = 1;
            sub.endDate = sub.startDate.AddMonths(sub.monthDuration);
            sub.categoryFees = clsCategories.FindCategory(cmbCategories.Text).fees;
            sub.fees = sub.categoryFees * sub.monthDuration;
            sub.discount = Convert.ToInt32(cmbDiscount.Text);
            sub.finalFees = sub.fees - (sub.fees * sub.discount / 100);
            dtpSubStartDate.Value = sub.startDate;
            dtpSubEndDate.Value = sub.startDate.AddMonths(sub.monthDuration);
            sub.endDate = dtpSubEndDate.Value;
            txtFees.Texts = sub.fees.ToString();
            txtFinalFees.Texts = sub.finalFees.ToString();
            
        }
        private void ctrFindPerson1_onPersonSelected(int obj)
        {
            if (obj < 1)
            {
                return;
            }          
            sub.PersonId = obj;
            txtMemberName.Texts = ctrFindPerson1.PersonInfo.fullName;
            if (_Mode == enMode.enAdd) 
                _LoadInfo();
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillTrainersNameToComboBox();
            sub.categoryFees = clsCategories.FindCategory(cmbCategories.Text).fees;
            sub.fees = sub.categoryFees * sub.monthDuration;
            txtFees.Texts = sub.fees.ToString();
            sub.finalFees = (sub.fees) - (sub.fees * sub.discount / 100);
            txtFinalFees.Texts = sub.finalFees.ToString();
        }
        private void dtpSubStartDate_ValueChanged(object sender, EventArgs e)
        {
            sub.startDate = dtpSubStartDate.Value;
            sub.endDate = sub.startDate.AddMonths(sub.monthDuration);
            dtpSubEndDate.Value = sub.endDate;
        }
        private void cmbDiscount_TextUpdate(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(cmbDiscount.Text) || sub.discount < 1 || sub.discount > 100)
            {
                sub.discount = 0;
                txtFinalFees.Texts = txtFees.Texts;
            }
            else
            {
                sub.discount = Convert.ToInt32(cmbDiscount.Text);
                txtFinalFees.Texts = (sub.fees - (sub.fees * sub.discount / 100)).ToString();
            }
        }
        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDiscount.Text) || Convert.ToInt32(cmbDiscount.Text) < 1)
            {
                txtFinalFees.Texts = (sub.fees * sub.monthDuration).ToString();
            }
            else
            {
                sub.discount = Convert.ToInt32(cmbDiscount.Text);
                txtFinalFees.Texts = (sub.fees - (sub.fees * sub.discount / 100)).ToString();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Tabcontrol.SelectedIndex = 1;
        }
        private void cmbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                return;
            }
            if (string.IsNullOrEmpty(cmbDiscount.Text) || Convert.ToInt32(cmbDiscount.Text) < 1)
            {
                sub.finalFees = sub.fees;
                txtFinalFees.Texts = sub.finalFees.ToString();
            }
            else
            {               
                sub.discount = Convert.ToInt32(cmbDiscount.Text);
                txtFinalFees.Texts = (sub.fees - (sub.fees * sub.discount / 100)).ToString();
            }
        }
        private void _collectSubscriptionInfo()
        {
            if (_Mode == enMode.enAdd)
            {
                _subscription = new clsSubscription();
                _subscription.subscriptionStartDate = dtpSubStartDate.Value;
                _subscription.subscriptionEndDate = dtpSubEndDate.Value;
                _subscription.monthDuration = sub.monthDuration;
                _subscription.fees = sub.fees;
                _subscription.finalFees = sub.finalFees;
                _subscription.discount = sub.discount;
                _subscription.registerViaUser = clsGlobalUser.CurrentUser.UserID;
                sub.assignmentId = clsTrainerCategoryAssignment.GetAssignmentId(cmbTrainers.Text, cmbCategories.Text);
                return;
            }
            _subscription.subscriptionStartDate = dtpSubStartDate.Value;
            _subscription.subscriptionEndDate= dtpSubEndDate.Value;
            _subscription.registerViaUser=clsGlobalUser.CurrentUser.UserID;
            _subscription.monthDuration = Convert.ToInt32(cmbMonthDuration.Text);
            _subscription.discount= Convert.ToInt32(cmbDiscount.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.enAdd)
            {
                _subscription = clsSubscription.isPersonHadAnActiveSubscription(sub.PersonId, cmbCategories.Text);
                if (_subscription != null)
                {
                    RJMessageBox.Show(Strings.rjPersonSubToCat,
                        Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }           
            }

            if (RJMessageBox.Show(Strings.rjAskToSaveUser, Strings.InvalidInputTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)!= DialogResult.OK)
            {
                return;
            }
            _collectSubscriptionInfo();
            if (_Mode == enMode.enUpdate)
            {
                if (clsSubscription.UpdateSubscription(_subscription.subscriptionId, _subscription.subscriptionStartDate, _subscription.subscriptionEndDate,
                    _subscription.fees, _subscription.registerViaUser, _subscription.monthDuration, _subscription.discount))
                {
                    RJMessageBox.Show("Subscription update successfully.", Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReturnToSubscriptionList();
                }
            }
            else
            {

                if (_subscription.AddNewSubscription(sub.PersonId, sub.assignmentId) > 0)
                {
                    if (sub._PreviousUserControl == null)
                    {
                        RJMessageBox.Show(Strings.rjSubAdded, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Mode = enMode.enUpdate;
                        _SubscriptionId = _subscription.subscriptionId;
                        _LoadInfo();
                    }
                    else
                    {
                        _ReturnToSubscriptionList();
                    }
                }
            }
        }
        private void _ReturnToSubscriptionList()
        {
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                ctrGetAllSubscriptions subscriptionsList = new ctrGetAllSubscriptions();
                subscriptionsList.Dock = DockStyle.Fill;
                parent.Controls.Add(subscriptionsList);
            }
        }
        private void cmbMonthDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub.monthDuration = Convert.ToInt32(cmbMonthDuration.Text);
            sub.startDate = dtpSubStartDate.Value;
            sub.endDate= sub.startDate.AddMonths(sub.monthDuration);
            sub.fees = sub.categoryFees * sub.monthDuration;
            sub.finalFees = sub.fees - (sub.fees * sub.discount / 100);
            dtpSubEndDate.Value = sub.endDate;
            txtFees.Texts=sub.fees.ToString();
            txtFinalFees.Texts=sub.finalFees.ToString();
        }
     
    }
}
