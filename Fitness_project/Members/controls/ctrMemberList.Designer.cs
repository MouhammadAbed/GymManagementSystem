namespace Fitness_project.Members.controls
{
    partial class ctrMemberList
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
            this.cmbFilterOptions = new customDesignControl.ModernComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cdgvMembersList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWMemberINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(327, 240);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(242, 21);
            this.lblNoData.TabIndex = 1;
            this.lblNoData.Text = "No data found in the database";
            this.lblNoData.Visible = false;
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
            "ALL",
            "ID",
            "FULL NAME",
            "ACTIVE"});
            this.cmbFilterOptions.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFilterOptions.ListTextColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.Location = new System.Drawing.Point(89, 6);
            this.cmbFilterOptions.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFilterOptions.Size = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.TabIndex = 0;
            this.cmbFilterOptions.Texts = "";
            this.cmbFilterOptions.OnSelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_OnSelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(20, 11);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 21);
            this.lblSortBy.TabIndex = 4;
            this.lblSortBy.Text = "Sort By:";
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
            // cdgvMembersList
            // 
            this.cdgvMembersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cdgvMembersList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdgvMembersList.Location = new System.Drawing.Point(0, 42);
            this.cdgvMembersList.Name = "cdgvMembersList";
            this.cdgvMembersList.Size = new System.Drawing.Size(916, 676);
            this.cdgvMembersList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumBlue;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.updateMemberToolStripMenuItem,
            this.sHOWMemberINFOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 118);
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMemberToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.addMemberToolStripMenuItem.Text = "ADD MEMEBER";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateMemberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateMemberToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_32;
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.updateMemberToolStripMenuItem.Text = "UPDATE MEMBER";
            // 
            // sHOWMemberINFOToolStripMenuItem
            // 
            this.sHOWMemberINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sHOWMemberINFOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sHOWMemberINFOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOWMemberINFOToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.sHOWMemberINFOToolStripMenuItem.Name = "sHOWMemberINFOToolStripMenuItem";
            this.sHOWMemberINFOToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.sHOWMemberINFOToolStripMenuItem.Text = "SHOW MEMBER INFO";
            this.sHOWMemberINFOToolStripMenuItem.Click += new System.EventHandler(this.sHOWMemberINFOToolStripMenuItem_Click);
            // 
            // ctrMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbFilterOptions);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cdgvMembersList);
            this.Name = "ctrMemberList";
            this.Size = new System.Drawing.Size(919, 721);
            this.Load += new System.EventHandler(this.ctrMemberList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlobalClasses.CustomDataGridView cdgvMembersList;
        private System.Windows.Forms.Label lblNoData;
        private customDesignControl.ModernComboBox cmbFilterOptions;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWMemberINFOToolStripMenuItem;
    }
}
