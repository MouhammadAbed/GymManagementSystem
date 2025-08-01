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

namespace Fitness_project.Subscription
{
    public partial class ctrGetAllSubscriptions : UserControl
    {
        DataTable dtSubscriptions = new DataTable();
        public ctrGetAllSubscriptions()
        {
            InitializeComponent();
            lblSearchBy.Text=Strings.lblSearchBy;
        }
        private void RefreshSubscriptions()
        {
            dtSubscriptions = clsSubscription.GetAllSubscriptions();

            if (dtSubscriptions.Rows.Count < 1)
            {
                cdgvSubscriptionsList.BindData(null); // clear grid
                return;
            }           

            cdgvSubscriptionsList.BindData(dtSubscriptions);

            var grid = cdgvSubscriptionsList.InnerGrid;

            // Format date columns
            grid.Columns["START DATE"].DefaultCellStyle.Format = "dd/MM/yyyy";
            grid.Columns["END DATE"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // ReadOnly and Width
            grid.ReadOnly = true;
            grid.Columns[0].Width = 100;
            grid.Columns[1].Width = 140;
            grid.Columns[2].Width = 142;
            grid.Columns[3].Width = 100;
            grid.Columns[4].Width = 120;
            grid.Columns[5].Width = 120;
            grid.Columns[6].Width = 100;
            grid.Columns[7].Width = 100;
            grid.Columns[8].Width = 100;
            grid.Columns[9].Width = 100;

            cdgvSubscriptionsList.InnerGrid.RowPrePaint += InnerGrid_RowPrePaint;
        }
        private void ctrGetAllSubscriptions_Load(object sender, EventArgs e)
        {
            RefreshSubscriptions();
            cmbFilterOptions.SelectedIndex = 0;
            txtValue.Focus();
        }
        private void InnerGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            var row = dgv.Rows[e.RowIndex];

            if (DateTime.TryParse(row.Cells["END DATE"].Value?.ToString(), out DateTime endDate))
            {
                DateTime today = DateTime.Today;
                TimeSpan diff = today - endDate;

                string isActive = Convert.ToString(row.Cells["STATUS"].Value);

                Color backColor;

                if (endDate >= today)
                {
                    backColor = Color.LightGreen; // 🟩 Active
                }
                else if (diff.TotalDays <= 30 )
                {
                    backColor = Color.Orange; // 🟧 Recently expired
                }
                else
                {
                    backColor = Color.Red; // 🟥 Expired long ago
                }

                // Apply background and selection colors
                row.DefaultCellStyle.BackColor = backColor;
                row.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }
        private void cmbFilterOptions_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Text = "";
            if (cmbFilterOptions.SelectedIndex == 0)
                dtSubscriptions.DefaultView.RowFilter = "";
            txtValue.Visible = (cmbFilterOptions.SelectedIndex != 0);
            txtValue.Focus();
        }
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            string FilterValue = txtValue.Text;
            switch (cmbFilterOptions.SelectedIndex)
            {
                case 1:
                    FilterColumn = "Member NAME";
                    break;
                case 2:
                    FilterColumn = "CATEGORY";
                    break;
                case 3:
                    FilterColumn = "Trainer NAME";
                    break;
            }
            if (cmbFilterOptions.SelectedIndex == 0 || string.IsNullOrEmpty(FilterValue))
            {

                dtSubscriptions.DefaultView.RowFilter = "";
                return;
            }
            else               
                dtSubscriptions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddNewSubscription AddSubscription = new ctrAddNewSubscription(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                AddSubscription.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(AddSubscription);
            }
        }
        private void ShowSubscriptionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int subscriptionId = cdgvSubscriptionsList.GetSelectedRowFirstColumnValue();
            if (subscriptionId == -1)
            {
                RJMessageBox.Show("Please select a row", "Unselected row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrSubscriptionInfo SubscriptionInfo = new ctrSubscriptionInfo();
            SubscriptionInfo.LoadSubscriptionInfoBySubscriptionId(subscriptionId);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                SubscriptionInfo.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(SubscriptionInfo);
            }
        }
        private int ShowDiscountInput(string renewalType)
        {
            int discount = -1; // Default: cancelled or invalid

            Form inputForm = new Form();
            inputForm.Text = $"Renewal: {renewalType}";
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.Size = new Size(300, 160);
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;
            inputForm.ShowInTaskbar = false;

            Label lbl = new Label()
            {
                Text = "Insert a discount (%):",
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
                if (int.TryParse(txt.Text, out discount) && discount >= 0 && discount <= 100)
                {
                    return discount; 
                }
                else
                {
                    RJMessageBox.Show("Please enter a valid number between 0 and 100.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ShowDiscountInput(renewalType); 
                }
            }

            return -1; 
        }
        private void rENEWONEMONTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //In case the application status in the applications table equal to 0 (previous subscription expired), I am going to assing the current
            //Date as start date for the new subscription. otherwise assign the end date in the previous subscription as start date 
            int subscriptionId = cdgvSubscriptionsList.GetSelectedRowFirstColumnValue();
            if (subscriptionId < 1)
            {
                RJMessageBox.Show(Strings.rjSelectRow, Strings.NoSelectedRowTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsSubscription renewSubscription = clsSubscription.FindSubscriptionBySubsId(subscriptionId);
            if(renewSubscription.isRenewed)
            {
                RJMessageBox.Show(Strings.rjSubRenewed, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (renewSubscription != null)
            {
                int discount = ShowDiscountInput("1-Month");

                if (discount == -1)
                {
                    RJMessageBox.Show(Strings.rjRenewCancelled, Strings.Cancelledtitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int newId = 0;
                if ((newId = renewSubscription.renewSubscription(1,renewSubscription.applicationInfo.trainerCategoryInfo.CategoryId,discount)) > 1)
                {
                    RJMessageBox.Show(string.Format(Strings.rjRenewDone,1), Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSubscriptions();
                }

                
            }
        }
        private void rENEWTOWMONTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int subscriptionId = cdgvSubscriptionsList.GetSelectedRowFirstColumnValue();
            if (subscriptionId < 1)
            {
                RJMessageBox.Show(Strings.rjSelectRow, Strings.NoSelectedRowTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsSubscription renewSubscription = clsSubscription.FindSubscriptionBySubsId(subscriptionId);
            if (renewSubscription.isRenewed)
            {
                RJMessageBox.Show(Strings.rjSubRenewed, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (renewSubscription != null)
            {
                int discount = ShowDiscountInput("2-Month");

                if (discount == -1)
                {
                    RJMessageBox.Show(Strings.rjRenewCancelled, Strings.Cancelledtitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int newId=0;
                if ((newId = renewSubscription.renewSubscription(2, renewSubscription.applicationInfo.trainerCategoryInfo.CategoryId, discount)) > 1)
                {
                    RJMessageBox.Show(string.Format(Strings.rjRenewDone, 2), Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSubscriptions();
                }
            }
        }
        private void rENEW3MONTHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int subscriptionId = cdgvSubscriptionsList.GetSelectedRowFirstColumnValue();
            if (subscriptionId < 1)
            {
                RJMessageBox.Show(Strings.rjSelectRow, Strings.NoSelectedRowTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsSubscription renewSubscription = clsSubscription.FindSubscriptionBySubsId(subscriptionId);
            if (renewSubscription.isRenewed)
            {
                RJMessageBox.Show(Strings.rjSubRenewed, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (renewSubscription != null)
            {
                int discount = ShowDiscountInput("3-Month");

                if (discount == -1)
                {
                    RJMessageBox.Show(Strings.rjRenewCancelled, Strings.Cancelledtitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int newId = 0;
                if ((newId = renewSubscription.renewSubscription(3, renewSubscription.applicationInfo.trainerCategoryInfo.CategoryId, discount)) > 1)
                {
                    RJMessageBox.Show(string.Format(Strings.rjRenewDone, 3), Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshSubscriptions();
                }
            }
        }
        private void uPDATESUBSCRIPTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int subscriptionId = cdgvSubscriptionsList.GetSelectedRowFirstColumnValue();
            if (subscriptionId < 1)
            {
                RJMessageBox.Show(Strings.rjSelectRow, Strings.NoSelectedRowTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cdgvSubscriptionsList.GetSelectedCellValue(6).ToString() == "InActive")
            {
                RJMessageBox.Show("Cannot update an inactive subscription", Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctrAddNewSubscription AddSubscription = new ctrAddNewSubscription(subscriptionId,this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                AddSubscription.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(AddSubscription);
            }
        }

    }
}
