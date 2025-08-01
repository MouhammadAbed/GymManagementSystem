using CustomMessageBox;
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

namespace Fitness_project.Categories.controls
{
    public partial class ctrCategoriesList : UserControl
    {
        DataTable dtCategories;

        private void ApplyLocalization()
        {
            lblNoData.Text = Strings.lblNoData;
            lblSortBy.Text = Strings.lblSortBy; 
        }
        public ctrCategoriesList()
        {
            InitializeComponent();
        }
        private void ctrCategoriesList_Load(object sender, EventArgs e)
        {
            dtCategories = clsCategories.getAllCategories();
            cmbFilterOptions.SelectedIndex = 0;
            if (dtCategories.Rows.Count < 1 || dtCategories == null)
            {
                lblNoData.Visible = true;
            }
            else
            {
                lblNoData.Visible = false;
                cdgvCategoriesList.BindData(dtCategories);
                cdgvCategoriesList.InnerGrid.ReadOnly = true;
                cdgvCategoriesList.InnerGrid.Columns[0].Width = 229;
                cdgvCategoriesList.InnerGrid.Columns[1].Width = 229;
                cdgvCategoriesList.InnerGrid.Columns[2].Width = 229;
                cdgvCategoriesList.InnerGrid.Columns[3].Width = 229;
            }
        }
        private void cmbFilterOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbFilterOptions.SelectedIndex == 0)
                dtCategories.DefaultView.RowFilter = "";
            txtSearch.Visible = (cmbFilterOptions.SelectedIndex != 0);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string FilterValue = txtSearch.Text;
            switch (cmbFilterOptions.SelectedIndex)
            {
                case 1:
                    FilterColumn = "Category ID";
                    break;
                case 2:
                    FilterColumn = "Category Name";
                    break;                
            }
            if (cmbFilterOptions.SelectedIndex == 0 || string.IsNullOrEmpty(FilterValue))
            {
                dtCategories.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "Category Name")
            {
                dtCategories.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue.Replace("'", "''"));
            }
            else // Filtering by Category ID
            {
                if (int.TryParse(FilterValue, out int categoryId))//make sure user doen't past characters input
                {
                    dtCategories.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, categoryId);
                }
                else
                {
                    RJMessageBox.Show("Please enter a valid numeric Category ID.", "Invalid Input");
                    return;
                }
            }
            //if (FilterColumn == "Category Name")
            //    dtCategories.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            //else
            //    dtCategories.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }
        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddUpdateCategories addCategory = new ctrAddUpdateCategories(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                addCategory.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(addCategory);
            }
        }
        private void showCategoryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _categoryId = cdgvCategoriesList.GetSelectedRowFirstColumnValue();
            if(_categoryId == -1 )
            {
                RJMessageBox.Show("Please select a row", "Unselected row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrShowCategoryInfo showCategoryInfo = new ctrShowCategoryInfo(_categoryId,this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                showCategoryInfo.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(showCategoryInfo);
            }
        }
        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int categoryId = cdgvCategoriesList.GetSelectedRowFirstColumnValue();
            if(categoryId == -1)
            {
                RJMessageBox.Show("Please select a row","Unselected row",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ctrAddUpdateCategories updateCategory = new ctrAddUpdateCategories(categoryId,this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                updateCategory.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(updateCategory);
            }
        }
    }
}
