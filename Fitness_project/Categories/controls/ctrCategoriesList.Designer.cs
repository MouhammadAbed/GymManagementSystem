namespace Fitness_project.Categories.controls
{
    partial class ctrCategoriesList
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCategoryInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdgvCategoriesList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(404, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(411, 29);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(20, 19);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(68, 21);
            this.lblSortBy.TabIndex = 10;
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
            "ALL",
            "ID",
            "CATEGORY NAME"});
            this.cmbFilterOptions.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFilterOptions.ListTextColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.Location = new System.Drawing.Point(92, 14);
            this.cmbFilterOptions.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFilterOptions.Size = new System.Drawing.Size(286, 30);
            this.cmbFilterOptions.TabIndex = 8;
            this.cmbFilterOptions.Texts = "";
            this.cmbFilterOptions.OnSelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_OnSelectedIndexChanged);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(335, 366);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(247, 21);
            this.lblNoData.TabIndex = 11;
            this.lblNoData.Text = "No users found in the datebase";
            this.lblNoData.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.showCategoryInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 118);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.addCategoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCategoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addCategoryToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.addCategoryToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.updateCategoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateCategoryToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_32;
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // showCategoryInfoToolStripMenuItem
            // 
            this.showCategoryInfoToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.showCategoryInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCategoryInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showCategoryInfoToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.showCategoryInfoToolStripMenuItem.Name = "showCategoryInfoToolStripMenuItem";
            this.showCategoryInfoToolStripMenuItem.Size = new System.Drawing.Size(244, 38);
            this.showCategoryInfoToolStripMenuItem.Text = "Show Category Info";
            this.showCategoryInfoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCategoryInfoToolStripMenuItem.Click += new System.EventHandler(this.showCategoryInfoToolStripMenuItem_Click);
            // 
            // cdgvCategoriesList
            // 
            this.cdgvCategoriesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.cdgvCategoriesList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdgvCategoriesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cdgvCategoriesList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdgvCategoriesList.Location = new System.Drawing.Point(0, 65);
            this.cdgvCategoriesList.Margin = new System.Windows.Forms.Padding(4);
            this.cdgvCategoriesList.Name = "cdgvCategoriesList";
            this.cdgvCategoriesList.Size = new System.Drawing.Size(879, 656);
            this.cdgvCategoriesList.TabIndex = 0;
            // 
            // ctrCategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbFilterOptions);
            this.Controls.Add(this.cdgvCategoriesList);
            this.Name = "ctrCategoriesList";
            this.Size = new System.Drawing.Size(879, 721);
            this.Load += new System.EventHandler(this.ctrCategoriesList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlobalClasses.CustomDataGridView cdgvCategoriesList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSortBy;
        private customDesignControl.ModernComboBox cmbFilterOptions;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCategoryInfoToolStripMenuItem;
    }
}
