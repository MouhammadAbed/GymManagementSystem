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
    public partial class ctrShowCategoryInfo : UserControl
    {
        int _CategoryId;
        private UserControl _previousControl;
        public clsCategories exposeCategoryInfo
        {
            get { return ctrCategoryInfo1.CategoryInfo; }
        }
        
        private void ApplyLocalization()
        {
            lblShowCatTitle.Text = Strings.lblShowCatTitle;
            btnClose.Text = Strings.btnClose;
        }
        public ctrShowCategoryInfo(int categoryId, UserControl previousControl)
        {
            InitializeComponent();
            ApplyLocalization();
            _CategoryId = categoryId;
            _previousControl = previousControl;
        }
        private void ctrShowCategoryInfo_Load(object sender, EventArgs e)
        {
            ctrCategoryInfo1.LoadCategoryInfo(_CategoryId);
        }   
        private void btnClose_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent is Panel mainPanel)
            {
                mainPanel.Controls.Clear();
                _previousControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(_previousControl);
            }
            else if (this.Parent is Control p && p.Parent is Panel panel)
            {
                panel.Controls.Clear();
                _previousControl.Dock = DockStyle.Fill;
                panel.Controls.Add(_previousControl);
            }
        }
    }
}
