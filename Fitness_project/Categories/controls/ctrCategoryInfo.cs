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
    public partial class ctrCategoryInfo : UserControl
    {
        int _categoryId;
        clsCategories _category;
        public int exposeCategoryId
        {
            get { return _categoryId; }
        }

        private void ApplyLocalization()
        {
            lblFees.Text = Strings.lblFees;
            lblCategoryId.Text = Strings.lblCategoryId;
            lblCategoryName.Text = Strings.lblCategoryName;
            lblDescription.Text = Strings.lblDescription;
        }
        public clsCategories CategoryInfo
        {
            get { return _category; }
        }       
        public ctrCategoryInfo()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        private void _fillCategoryInfo()
        {
            txtCategoryId.Texts=_category.id.ToString();
            txtCategoryName.Texts = _category.name;
            txtDescription.Texts = _category.Description;
            txtFees.Texts=_category.fees.ToString();
        }
        private void _ResetDefaultSettings()
        {
            txtCategoryId.Texts = "[????]";
            txtCategoryName.Texts = "[????]";
            txtDescription.Texts = "[????]";
            txtFees.Texts = "[????]";

        }
        public void LoadCategoryInfo(int categoryId)
        {
            _categoryId= categoryId;
            _category = clsCategories.FindCategory(categoryId);
            if(_category!=null )
            {
                _fillCategoryInfo();
            }
            else
            {
                RJMessageBox.Show($"Category with id {_categoryId} doesn't exist", "Category not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ResetDefaultSettings();

            }
        }
        public void LoadCategoryInfo(string name)
        {
            _category=clsCategories.FindCategory(name);
            if(_category!=null )
            {
                _fillCategoryInfo();
                _categoryId = _category.id;
            }
            else
            {
                RJMessageBox.Show($"Category '{name}' doesn't exist", "Category not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ResetDefaultSettings();
            }
        }
    }
}
