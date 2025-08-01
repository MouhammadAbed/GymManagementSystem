using CustomMessageBox;
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

namespace Fitness_project.trainers
{
    public partial class ctrTrainersList : UserControl
    {
        DataTable dtTrainers;
        public ctrTrainersList()
        {
            InitializeComponent();
        }
        private void ctrTrainersList_Load(object sender, EventArgs e)
        {
            dtTrainers = clsTrainers.GetAllTrainers();
            cmbFilterOptions.SelectedIndex = 1;
            if (dtTrainers == null || dtTrainers.Rows.Count <= 0)
            {
                lblNoData.Visible = true;
            }
            else
            {
                lblNoData.Visible = false;
                cmbFilterOptions.SelectedIndex = 0;
                cdgvTrainersList.BindData(dtTrainers);
                cdgvTrainersList.InnerGrid.ReadOnly = true;
                cdgvTrainersList.InnerGrid.Columns[0].Width = 120;
                cdgvTrainersList.InnerGrid.Columns[1].Width = 120;
                cdgvTrainersList.InnerGrid.Columns[2].Width = 142;
                cdgvTrainersList.InnerGrid.Columns[3].Width = 142;
                cdgvTrainersList.InnerGrid.Columns[4].Width = 140;
                cdgvTrainersList.InnerGrid.Columns[5].Width = 120;
                cdgvTrainersList.InnerGrid.Columns[6].Width = 130;

            }
        }
        private void cmbFilterOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cmbFilterOptions.SelectedIndex == 0)
                dtTrainers.DefaultView.RowFilter = "";
            txtSearch.Visible = (cmbFilterOptions.SelectedIndex != 0);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string FilterValue = txtSearch.Text;
            switch (cmbFilterOptions.SelectedIndex)
            {
                case 1:
                    FilterColumn = "ID";
                    break;
                case 2:
                    FilterColumn = "FULL NAME";
                    break;
                case 3:
                    FilterColumn = "CATEGORY";
                    break;
            }
            if (cmbFilterOptions.SelectedIndex == 0 || string.IsNullOrEmpty(FilterValue))
            {

                dtTrainers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "FULL NAME" || FilterColumn== "CATEGORY")
                dtTrainers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            else
                dtTrainers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterOptions.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void sHOWUSERINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int assignId = cdgvTrainersList.GetSelectedRowFirstColumnValue();
            if (assignId == -1)
            {
                RJMessageBox.Show("Please select a row", "Unselected row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrShowTrainerInfo trainerInfo = new ctrShowTrainerInfo(assignId,this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                trainerInfo.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(trainerInfo);
            }
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int assignId = cdgvTrainersList.GetSelectedRowFirstColumnValue();
            if(assignId == -1)
            {
                RJMessageBox.Show("Please selecte a row!", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RJMessageBox.Show("Are you sure you want to delete this assignment?", "Delete assignment", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsTrainerCategoryAssignment.DeleteAssignment(assignId))
                {
                    RJMessageBox.Show("Assignment delete successfully", "Delete Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrTrainersList_Load(null, null);
                }
            }
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddUpdateTrainer AddTrainer = new ctrAddUpdateTrainer(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                AddTrainer.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(AddTrainer);
            }
        }
        private decimal updateSlary()
        {
            int discount = -1; // Default: cancelled or invalid

            Form inputForm = new Form();
            inputForm.Text = "Update User Salary";
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.Size = new Size(300, 160);
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;
            inputForm.ShowInTaskbar = false;

            Label lbl = new Label()
            {
                Text = "Insert new salary:",
                Location = new Point(10, 20),
                AutoSize = true
            };

            TextBox txt = new TextBox()
            {
                Location = new Point(10, 45),
                Width = 260
            };

            Button btnOk = new Button()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(110, 80)
            };

            Button btnCancel = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(190, 80)
            };

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOk);
            inputForm.Controls.Add(btnCancel);
            inputForm.AcceptButton = btnOk;
            inputForm.CancelButton = btnCancel;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                if (int.TryParse(txt.Text, out discount) && discount >= 0)
                {
                    return discount;
                }
                else
                {
                    RJMessageBox.Show("Please enter a valid number.", "Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
            }

            return -1;
        }
        private void uPDATEUSERSALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int assignmentId = cdgvTrainersList.GetSelectedRowFirstColumnValue();
            if (assignmentId < 1)
            {
                RJMessageBox.Show("Please select a row", "Unselected row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsTrainerCategoryAssignment assignment = clsTrainerCategoryAssignment.findAssignment(assignmentId);
            if(assignment != null)
            {
                decimal newSalary = updateSlary();
                if (newSalary > 0)
                {
                    if (clsTrainerCategoryAssignment.UpdateTrainerSalary(assignmentId, newSalary))
                    {
                        RJMessageBox.Show($"Salary update successfully for trainer {assignment.trainerInfo.fullName}", "Salary Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrTrainersList_Load(null, null);
                        return;
                    }
                }
            }
        }

    }
}
