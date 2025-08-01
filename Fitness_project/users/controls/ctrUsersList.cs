using CustomMessageBox;
using Fitness_project.Categories.ShowCategoriesInfo;
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

namespace Fitness_project.users.controls
{
    public partial class ctrUsersList : UserControl
    {
        DataTable dtUsers;
        private void ApplyLocalization()
        {
            lblNoData.Text = Strings.lblNoData;
            lblSortBy.Text = Strings.lblSortBy;
        }
        public ctrUsersList()
        {
            InitializeComponent();
        }
        private void ctrUsersList_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
            dtUsers = clsUser.getAllUser();
            cmbFilterOptions.SelectedIndex = 0;
            if(dtUsers.Rows.Count<1|| dtUsers==null)
            {
                lblNoData.Visible=true;
            }
            else
            {
                lblNoData.Visible=false;
                cdgvUsersList.BindData(dtUsers);
                cdgvUsersList.InnerGrid.ReadOnly = true;
                cdgvUsersList.InnerGrid.Columns[0].Width = 229;
                cdgvUsersList.InnerGrid.Columns[1].Width = 229;
                cdgvUsersList.InnerGrid.Columns[2].Width = 229;
                cdgvUsersList.InnerGrid.Columns[3].Width = 229;
            }            
        }
        private void cmbFilterOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbFilterOptions.SelectedIndex == 0)
                dtUsers.DefaultView.RowFilter = "";
            txtSearch.Visible = (cmbFilterOptions.SelectedIndex != 0);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string FilterValue = txtSearch.Text;
            switch (cmbFilterOptions.SelectedIndex)
            {
                case 1:
                    FilterColumn = "personid";
                    break;
                case 2:
                    FilterColumn = "USER_NAME";
                    break;
                case 3:
                    FilterColumn = "FULL_NAME";
                    break;
            }
            if (cmbFilterOptions.SelectedIndex == 0 || string.IsNullOrEmpty(FilterValue))
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn== "USER_NAME" || FilterColumn == "FULL_NAME")
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            else
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterOptions.Texts == "Id")
                e.Handled=!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = cdgvUsersList.GetSelectedRowFirstColumnValue();
            if (personId == -1)
            {
                RJMessageBox.Show("Please select a row", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RJMessageBox.Show($"Are you sure you want to delete user '{personId}'?","Delete user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUserByPersonId(personId))
                {
                    RJMessageBox.Show("User delete successfully", "delete result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrUsersList_Load(null, null);
                }
            }
            
        }
        private void sHOWUSERINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedPersonId = cdgvUsersList.GetSelectedRowFirstColumnValue();
            if (selectedPersonId == -1)
            {
                RJMessageBox.Show("Please select a row", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrShowUserInfo showUserInfo = new ctrShowUserInfo(selectedPersonId,this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                showUserInfo.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(showUserInfo);
            }
        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = cdgvUsersList.GetSelectedRowFirstColumnValue();
            if (personId == -1)
            {
                RJMessageBox.Show("Please select a row", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrAddUser addUser = new ctrAddUser(personId,this);            
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                addUser.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(addUser);
            }
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddUser addUser = new ctrAddUser(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                addUser.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(addUser);
            }
        }
    }
}
