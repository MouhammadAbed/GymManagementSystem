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

namespace Fitness_project.Categories.controls
{
    public partial class ctrFindCategory : UserControl
    {
        private void ApplyLocalization()
        {
            lblSearchBy.Text = Strings.lblSearchBy;
            btnSearch.Text= Strings.btnSearch;
        }
        public ctrFindCategory()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Texts = string.Empty;
        }
        private void ctrFindCategory_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            txtSearch.Focus();
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "CATEGORY ID":
                    if (comboBox1.Text == "CATEGORY ID" && int.TryParse(txtSearch.Texts, out int categoryId))
                        ctrCategoryInfo1.LoadCategoryInfo(Convert.ToInt32(categoryId));
                    else
                    {
                        RJMessageBox.Show("Please enter a valid numeric Category ID.", "Invalid Input");
                        return;
                    }
                    break;

                default:
                    ctrCategoryInfo1.LoadCategoryInfo(txtSearch.Texts);
                    break;
            }
        }
    }
}