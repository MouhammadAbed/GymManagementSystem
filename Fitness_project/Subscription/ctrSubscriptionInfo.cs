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

namespace Fitness_project.Subscription
{
    public partial class ctrSubscriptionInfo : UserControl
    {
        clsNamePart nameParts;
        int _personId = 0;
        int _subscriptionId = -1;
        clsSubscription _subscriptionInfo;
        public int exposeSubscriptionId
        {
            get { return _subscriptionId; }
        }

        private void ApplyLocalization()
        {
            lblMemberName.Text = Strings.lblMemberName;
            LblCategory.Text=Strings.LblCategory;
            lblTrainerName.Text = Strings.lblTrainerName;
            lblStartDate.Text = Strings.lblStartDate;
            lblEndDate.Text= Strings.lblEndDate;
            lblMonthDuration.Text = Strings.lblMonthDuration;
            lblDiscount.Text= Strings.lblDiscount;
            lblfinalFees.Text = Strings.lblfees1;
        }
        public clsSubscription exposeSubscriptionInfo
        {
            get { return _subscriptionInfo; }
        }            
        public ctrSubscriptionInfo()
        {
            InitializeComponent();
            ApplyLocalization();
        }        
        private void _FillSubscriptionInfo()
        {
            txtMemberName.Text = _subscriptionInfo.applicationInfo.memberInfo.fullName;
            txtCategory.Text = _subscriptionInfo.applicationInfo.trainerCategoryInfo.categoryInfo.name;
            txtTrainerName.Text = _subscriptionInfo.applicationInfo.trainerCategoryInfo.trainerInfo.fullName;
            txtStartDate.Text=_subscriptionInfo.subscriptionStartDate.ToString("dd/MMMM/yyyy");
            txtEndDate.Text = _subscriptionInfo.subscriptionEndDate.ToString("dd/MMMM/yyyy");
            txtMonthDuration.Text=_subscriptionInfo.monthDuration.ToString();
            txtDiscount.Text=_subscriptionInfo.discount.ToString();
            txtFinalFess.Text = _subscriptionInfo.finalFees.ToString() ;
        }
        public void ResetDefaultSettings()
        {
            _subscriptionId = -1;
            txtMemberName.Text = "????";
            txtCategory.Text = "????";
            txtTrainerName.Text = "????" ;
            txtStartDate.Text = "????";
            txtEndDate.Text = "????";
            txtMonthDuration.Text = "????";
            txtDiscount.Text = "????";
            txtFinalFess.Text = "????"; 
            return;
        }
        private void _LoadInfo()
        {
            if (_subscriptionId > 0)
            {
                _subscriptionInfo = clsSubscription.FindSubscriptionBySubsId(_subscriptionId);
                if (_subscriptionInfo != null)
                {
                    _FillSubscriptionInfo();
                    _subscriptionId=_subscriptionInfo.subscriptionId;
                }
                else
                    ResetDefaultSettings();
            }
            else if (_personId > 0)
            {
                _subscriptionInfo = clsSubscription.FindSubscriptionByPersonId(_personId);
                if (_subscriptionInfo != null)
                {
                    _FillSubscriptionInfo();
                    _subscriptionId = _subscriptionInfo.subscriptionId;
                }
                else
                    ResetDefaultSettings();
            }
            else
            {
                _subscriptionInfo = clsSubscription.FindSubscriptionByName(nameParts.firstName ,nameParts.secondName,nameParts.lastName);
                if (_subscriptionInfo != null)
                {
                    _FillSubscriptionInfo();
                    _subscriptionId=_subscriptionInfo.subscriptionId;
                }
                else
                    ResetDefaultSettings();
            }
            
        }
        public void LoadSubscriptionInfoByPersonId(int personId)
        {
            _personId=personId;
            _LoadInfo();
        }
        public void LoadSubscriptionInfoBySubscriptionId(int SubscriptionId)
        {
            _subscriptionId=SubscriptionId;
            _LoadInfo();
        }
        public void LoadSubscriptionInfoByMemberName(string fullName)
        {
            nameParts=clsNamePart.ParseFullName(fullName);
            if (nameParts == null)
            {
                RJMessageBox.Show(Strings.InvalidInputMessage, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadInfo();
        }
    }
}
