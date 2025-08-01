using CustomMessageBox;
using Fitness_project.GlobalClasses;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.GlobalClasses.Utility.focus;
using Fitness_project.Localization;
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

namespace Fitness_project.Categories.controls
{
    public partial class ctrAddUpdateCategories : UserControl
    {
        DataTable dtCategories;
        enum enMode { enUpdate = 1 ,enAdd = 2}
        enMode _Mode = enMode.enUpdate;
        int _categoryId = 0;
        clsCategories _category;
        UserControl _currentUserControl = null;

        private void ApplyLocalization()
        {
            lblCategoryId.Text = Strings.lblCategoryId;
            lblCategoryName.Text = Strings.lblCategoryName;
            lblDescription.Text= Strings.lblDescription;
            lblfees.Text = Strings.lblFees;
            btnSave.Text = Strings.btnAdd;
            lblAddCatTitle.Text= Strings.lblAddCatTitle;
        }
        public ctrAddUpdateCategories(UserControl currentUserControl=null)
        {
            InitializeComponent();
            ApplyLocalization();
            _currentUserControl = currentUserControl;
        }
        public ctrAddUpdateCategories(int categoryId,UserControl currentUserControl)
        {
            InitializeComponent();
            ApplyLocalization();
            _categoryId = categoryId;
            _currentUserControl = currentUserControl;
        }
        private void modernTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=char.IsControl(e.KeyChar)&&char.IsDigit(e.KeyChar);
        }
        private void _fillCategoryInfo()
        {
            lblAddCatTitle.Text = Strings.lblUpdateCatTitle;
            txtCategoryId.Enabled = false;
            txtCategoryName.Enabled = false;
            _category= clsCategories.FindCategory(_categoryId);
            txtCategoryId.Texts = _category.id.ToString();
            txtCategoryName.Texts= _category.name;
            txtDescription.Texts =_category.Description ==string.Empty?"":_category.Description;
            txtFees.Texts= _category.fees.ToString();
        }
        private void _LoadCategoriesList()
        {
            dtCategories = clsCategories.getAllCategories();
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
        private void ctrAddUpdateCategories_Load(object sender, EventArgs e)
        {
            clsRoundedPanleCorner.RoundPanelCorners(addCategoryPanel, 20);
            _LoadCategoriesList();
            if (_categoryId == 0)
            {
                _Mode = enMode.enAdd;
                lblAddCatTitle.Text = Strings.lblAddCatTitle;
                _category = new clsCategories();
                return; 
            }
            _Mode = enMode.enUpdate;
            _fillCategoryInfo();
            txtCategoryName.Focus();
        }
        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCategoryName.Texts))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategoryName, Strings.RequiredField);
            }
            else if(clsCategories.isCategoryExist(txtCategoryName.Texts)&&_Mode == enMode.enAdd)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategoryName, Strings.messageCatExist);
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtCategoryName,null); 
            }

        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Texts))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, Strings.RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }
        }
        private void _CollectCategoryInfo()
        {
            _category.name= txtCategoryName.Texts;
            _category.Description = txtDescription.Texts;
            _category.fees = Convert.ToDecimal(txtFees.Texts);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            if(RJMessageBox.Show(Strings.rjAskToSaveUser,Strings.InvalidInputTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                _CollectCategoryInfo();
                if (_category.Save())
                {
                    if (_currentUserControl == null)
                    {
                        RJMessageBox.Show(Strings.rjSaveUser, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Mode = enMode.enUpdate;
                        _categoryId = _category.id;
                        _fillCategoryInfo();
                        _LoadCategoriesList();
                    }
                    else
                    {
                        _ReturnToCategoriesList();
                    }
                }
            }
        }
        private void _ReturnToCategoriesList()
        {
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                ctrCategoriesList categoriesList = new ctrCategoriesList();
                categoriesList.Dock = DockStyle.Fill;
                parent.Controls.Add(categoriesList);
            }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            clsSetTextBoxFocus.ChangeBorderBackColorOnFocusEnter(sender,e);
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            clsSetTextBoxFocus.ChangeBorderBackColorOnFocusLeave(sender, e);
        }
    }
}
