namespace Fitness_project.trainers
{
    partial class ctrTrainersList
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbFilterOptions = new customDesignControl.ModernComboBox();
            this.lblNoData = new System.Windows.Forms.Label();
            this.cdgvTrainersList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWUSERINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEUSERSALARYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(302, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 29);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(20, 11);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 21);
            this.lblSortBy.TabIndex = 9;
            this.lblSortBy.Text = "Sort By:";
            // 
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.AutoCompleteCustomSource.AddRange(new string[] {
            "Id",
            "Full Name",
            "Category"});
            this.cmbFilterOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFilterOptions.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbFilterOptions.BorderSize = 1;
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterOptions.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.IconColor = System.Drawing.Color.Blue;
            this.cmbFilterOptions.Items.AddRange(new object[] {
            "All",
            "id",
            "Full Name",
            "Category"});
            this.cmbFilterOptions.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFilterOptions.ListTextColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.Location = new System.Drawing.Point(89, 6);
            this.cmbFilterOptions.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFilterOptions.Size = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.TabIndex = 5;
            this.cmbFilterOptions.Texts = "";
            this.cmbFilterOptions.OnSelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_OnSelectedIndexChanged);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(288, 248);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(266, 21);
            this.lblNoData.TabIndex = 8;
            this.lblNoData.Text = "No trainers found in the database";
            this.lblNoData.Visible = false;
            // 
            // cdgvTrainersList
            // 
            this.cdgvTrainersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.cdgvTrainersList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdgvTrainersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdgvTrainersList.Location = new System.Drawing.Point(0, 42);
            this.cdgvTrainersList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cdgvTrainersList.Name = "cdgvTrainersList";
            this.cdgvTrainersList.Size = new System.Drawing.Size(916, 484);
            this.cdgvTrainersList.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumBlue;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.sHOWUSERINFOToolStripMenuItem,
            this.uPDATEUSERSALARYToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(253, 178);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addUserToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.addUserToolStripMenuItem.Text = "ADD TRAINER";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteUserToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_delete_48;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.deleteUserToolStripMenuItem.Text = "DELETE TRAINER";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // sHOWUSERINFOToolStripMenuItem
            // 
            this.sHOWUSERINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sHOWUSERINFOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sHOWUSERINFOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOWUSERINFOToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.sHOWUSERINFOToolStripMenuItem.Name = "sHOWUSERINFOToolStripMenuItem";
            this.sHOWUSERINFOToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.sHOWUSERINFOToolStripMenuItem.Text = "SHOW TRAINER INFO";
            this.sHOWUSERINFOToolStripMenuItem.Click += new System.EventHandler(this.sHOWUSERINFOToolStripMenuItem_Click);
            // 
            // uPDATEUSERSALARYToolStripMenuItem
            // 
            this.uPDATEUSERSALARYToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uPDATEUSERSALARYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.uPDATEUSERSALARYToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uPDATEUSERSALARYToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_32;
            this.uPDATEUSERSALARYToolStripMenuItem.Name = "uPDATEUSERSALARYToolStripMenuItem";
            this.uPDATEUSERSALARYToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.uPDATEUSERSALARYToolStripMenuItem.Text = "UPDATE USER SALARY";
            this.uPDATEUSERSALARYToolStripMenuItem.Click += new System.EventHandler(this.uPDATEUSERSALARYToolStripMenuItem_Click);
            // 
            // ctrTrainersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbFilterOptions);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cdgvTrainersList);
            this.Name = "ctrTrainersList";
            this.Size = new System.Drawing.Size(919, 526);
            this.Load += new System.EventHandler(this.ctrTrainersList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSortBy;
        private customDesignControl.ModernComboBox cmbFilterOptions;
        private System.Windows.Forms.Label lblNoData;
        private GlobalClasses.CustomDataGridView cdgvTrainersList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWUSERINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEUSERSALARYToolStripMenuItem;
    }
}
