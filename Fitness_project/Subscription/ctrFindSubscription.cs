using CustomMessageBox;
using Fitness_project.Localization;
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
    public partial class ctrFindSubscription : UserControl
    {
        string _value = "";
        bool enable = true;
        int _SubscriptionId = -1;

        private void ApplyLocalization()
        {
            lblFindSubTitle.Text = Strings.lblFindSubTitle;
            lblFind.Text = Strings.lblSearchBy;
            gbFilter.Text=Strings.gbFilter;
            btnSerach.Text = Strings.btnSearch;
        }
        public ctrFindSubscription()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        private void setFocus()
        {
            txtValue.Focus();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrSubscriptionInfo1.ResetDefaultSettings();
            txtValue.Text = "";
            setFocus();
        }
        private void _FindNow()
        {
            int id = 0;
            switch (cbFilter.Text)
            {
                case "Id":
                    if (int.TryParse(txtValue.Text.Trim(), out id))
                    {
                        ctrSubscriptionInfo1.LoadSubscriptionInfoByPersonId(Convert.ToInt32(txtValue.Text));
                        _SubscriptionId = ctrSubscriptionInfo1.exposeSubscriptionId;
                    }
                    else
                    {
                        RJMessageBox.Show(Strings.messageInvalidNumeric, Strings.InvalidInputTitle);
                        return;
                    }                    
                    break;
                default:
                    ctrSubscriptionInfo1.LoadSubscriptionInfoByMemberName(txtValue.Text);
                    _SubscriptionId = ctrSubscriptionInfo1.exposeSubscriptionId;
                    break;
            }
            if (_SubscriptionId <= 0)
            {
                RJMessageBox.Show(Strings.rjSubNotFound,Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                RJMessageBox.Show(Strings.RequiredFields,
                Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }
        private void ctrFindSubscription_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            setFocus();
        }
    }
}
