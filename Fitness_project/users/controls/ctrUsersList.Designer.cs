namespace Fitness_project.users.controls
{
    partial class ctrUsersList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNoData = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbFilterOptions = new customDesignControl.ModernComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWUSERINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdgvUsersList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(389, 336);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(247, 21);
            this.lblNoData.TabIndex = 1;
            this.lblNoData.Text = "No users found in the datebase";
            this.lblNoData.Visible = false;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(20, 11);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 21);
            this.lblSortBy.TabIndex = 7;
            this.lblSortBy.Text = "Sort By:";
            // 
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFilterOptions.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbFilterOptions.BorderSize = 1;
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterOptions.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.IconColor = System.Drawing.Color.Blue;
            this.cmbFilterOptions.Items.AddRange(new object[] {
            "All",
            "Id",
            "Username",
            "Full Name"});
            this.cmbFilterOptions.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFilterOptions.ListTextColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.Location = new System.Drawing.Point(92, 6);
            this.cmbFilterOptions.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFilterOptions.Size = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.TabIndex = 0;
            this.cmbFilterOptions.Texts = "";
            this.cmbFilterOptions.OnSelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_OnSelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(302, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumBlue;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.sHOWUSERINFOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 156);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addUserToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.addUserToolStripMenuItem.Text = "ADD USER";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateUserToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_32;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.updateUserToolStripMenuItem.Text = "UPDATE USER";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteUserToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_delete_48;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.deleteUserToolStripMenuItem.Text = "DELETE USER";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // sHOWUSERINFOToolStripMenuItem
            // 
            this.sHOWUSERINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sHOWUSERINFOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sHOWUSERINFOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOWUSERINFOToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.sHOWUSERINFOToolStripMenuItem.Name = "sHOWUSERINFOToolStripMenuItem";
            this.sHOWUSERINFOToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.sHOWUSERINFOToolStripMenuItem.Text = "SHOW USER INFO";
            this.sHOWUSERINFOToolStripMenuItem.Click += new System.EventHandler(this.sHOWUSERINFOToolStripMenuItem_Click);
            // 
            // cdgvUsersList
            // 
            this.cdgvUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cdgvUsersList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdgvUsersList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdgvUsersList.Location = new System.Drawing.Point(0, 42);
            this.cdgvUsersList.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cdgvUsersList.Name = "cdgvUsersList";
            this.cdgvUsersList.Size = new System.Drawing.Size(991, 484);
            this.cdgvUsersList.TabIndex = 2;
            // 
            // ctrUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbFilterOptions);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cdgvUsersList);
            this.Name = "ctrUsersList";
            this.Size = new System.Drawing.Size(991, 526);
            this.Load += new System.EventHandler(this.ctrUsersList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private customCtrDatagridview.CustomDatagridview CdgvUsersList;
        private System.Windows.Forms.Label lblNoData;
        private GlobalClasses.CustomDataGridView cdgvUsersList;
        private System.Windows.Forms.Label lblSortBy;
        private customDesignControl.ModernComboBox cmbFilterOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWUSERINFOToolStripMenuItem;
    }
}
