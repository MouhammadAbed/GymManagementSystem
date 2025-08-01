using customDesignControl;
using CustomMessageBox;
using Fitness_project.GlobalClasses;
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
using System.Xml.Linq;

namespace Fitness_project.Members.controls
{
    public partial class ctrMemberList : UserControl
    {
        DataTable dtMembers;
        public ctrMemberList()
        {
            InitializeComponent();           
        }       
        private void ApplyLocalization()
        {
            lblSortBy.Text = Strings.lblSortBy;
            lblNoData.Text = Strings.lblNoData;
        }
        private void ctrMemberList_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
            dtMembers = clsMembers.getAllMembers();
            cmbFilterOptions.SelectedIndex = 1;
            if(dtMembers==null || dtMembers.Rows.Count <= 0)
            {
                lblNoData.Visible = true;
            }
            else
            {                
                lblNoData.Visible = false;
                cmbFilterOptions.SelectedIndex = 0;
                cdgvMembersList.BindData(dtMembers);
                cdgvMembersList.InnerGrid.ReadOnly = true;
                cdgvMembersList.InnerGrid.Columns[0].Width = 183;
                cdgvMembersList.InnerGrid.Columns[1].Width = 203;
                cdgvMembersList.InnerGrid.Columns[2].Width = 163;
                cdgvMembersList.InnerGrid.Columns[3].Width = 183;
                cdgvMembersList.InnerGrid.Columns[4].Width = 183;

            }

        }
        private void cmbFilterOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbFilterOptions.SelectedIndex == 0)
                dtMembers.DefaultView.RowFilter = "";
            txtSearch.Visible = (cmbFilterOptions.SelectedIndex!= 0)&&(cmbFilterOptions.SelectedIndex!=3);
            if (cmbFilterOptions.SelectedIndex == 3)
            {
                dtMembers.DefaultView.RowFilter = "Status = 'Active'";
            }
            if(cmbFilterOptions.SelectedIndex==1||cmbFilterOptions.SelectedIndex==2)
            {
                txtSearch.Focus();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string FilterValue = txtSearch.Text;
            switch (cmbFilterOptions.SelectedIndex)
            {
                case 1:
                    FilterColumn = "PERSON ID";
                    break;
                case 2:
                    FilterColumn = "FULL NAME";
                    break;
                case 3:
                    FilterColumn = "Status";
                    FilterValue = "Active";
                        break;
            }
            if (cmbFilterOptions.SelectedIndex == 0 || string.IsNullOrEmpty(FilterValue))
            {

                dtMembers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "FULL NAME")
                dtMembers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);           

            else
                dtMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterOptions.SelectedIndex == 1)
            {
                e.Handled=!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
            }
        }
        private void sHOWMemberINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Personid = cdgvMembersList.GetSelectedRowFirstColumnValue();
            if (Personid == -1)
            {
                RJMessageBox.Show("Please selected a row", "Member info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrShowMemberInfo showMemberInfo = new ctrShowMemberInfo(Personid, this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                showMemberInfo.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(showMemberInfo);
            }
        }        
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddUpdateMember addMember = new ctrAddUpdateMember(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                addMember.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(addMember);
            }
        }
    }
}
