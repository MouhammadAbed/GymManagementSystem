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

namespace Fitness_project.Audit
{
    public partial class ctrAuditScreen : UserControl
    {
        string _selectedCategoryName = "";
        int _selectedYear = DateTime.Now.Year;
        int _selectedMonth = DateTime.Now.Month;
        bool _isLoading = true;

        private void ApplyLocalization()
        {
            lblAuditTitle.Text=Strings.lblAuditTitle;
            lblfees.Text = Strings.lblFees;
            lblAppCount.Text = Strings.lblAppCount;
            lbltotalSub.Text = Strings.lbltotalSub;
            lblMonth.Text = Strings.lblMonth;
            lblYear.Text = Strings.lblYear;
            LblCategory.Text = Strings.LblCategory;
        }
        public ctrAuditScreen()
        {
            InitializeComponent();
            ApplyLocalization();
            _loadCategoriesItms();
            _loadYearComboBox();
            _isLoading = false;
        }
        private void _loadCategoriesItms()
        {
            cmbCategories.Items.Clear();
            cmbCategories.Items.Add("All");
            DataTable dtCategoires = clsCategories.getAllCategories();
            foreach (DataRow row in dtCategoires.Rows)
            {
                cmbCategories.Items.Add(row["Category Name"].ToString());
            }
            cmbCategories.SelectedIndex = 0;
        }
        private void _loadYearComboBox()
        {
            cmbYear.Items.Clear();
            cmbYear.Items.Add("LIFETIME");
            DataTable dtYears = clsAudit.getYears();
            foreach (DataRow row in dtYears.Rows)
            {
                cmbYear.Items.Add(row["SubscriptionYear"].ToString());
            }

            if (cmbYear.Items.Count > 0)
                cmbYear.Text = DateTime.Now.Year.ToString();

            cmbMonth.Text = DateTime.Now.Month.ToString();

            lblTotalSubsc.Text = clsAudit.TotalSubscrbers(0, _selectedMonth, _selectedYear).ToString();
            lblTotalApplicants.Text = clsAudit.TotalApplicants(0, _selectedMonth, _selectedYear).ToString();
            lblTotalFees.Text = clsAudit.TotalFees(0, _selectedMonth, _selectedYear).ToString() + " $";
        }
        private void _onComboBoxesSelectedIndexChange()
        {
            _selectedCategoryName = cmbCategories.SelectedIndex == 0 ? "" : cmbCategories.Text;
            _selectedYear = cmbYear.SelectedIndex == 0 ? 0 : Convert.ToInt32(cmbYear.Text);
            _selectedMonth = cmbMonth.SelectedIndex == 0 ? 0 : Convert.ToInt32(cmbMonth.Text);
            int categoryId = _selectedCategoryName == "" ? 0 : clsCategories.FindCategory(_selectedCategoryName).id;
            lblTotalSubsc.Text=clsAudit.TotalSubscrbers(categoryId,_selectedMonth,_selectedYear).ToString();
            lblTotalApplicants.Text = clsAudit.TotalApplicants(categoryId, _selectedMonth, _selectedYear).ToString();
            lblTotalFees.Text=clsAudit.TotalFees(categoryId,_selectedMonth, _selectedYear).ToString();
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_isLoading) return;
            _onComboBoxesSelectedIndexChange();
        }
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; 
            _onComboBoxesSelectedIndexChange();
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; 
            _onComboBoxesSelectedIndexChange();
        }
    }
}
