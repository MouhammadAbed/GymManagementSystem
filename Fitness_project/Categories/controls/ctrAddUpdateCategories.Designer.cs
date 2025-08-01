namespace Fitness_project.Categories.controls
{
    partial class ctrAddUpdateCategories
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
            this.lblAddCatTitle = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.txtCategoryId = new customDesignControl.ModernTextBox();
            this.txtCategoryName = new customDesignControl.ModernTextBox();
            this.txtDescription = new customDesignControl.ModernTextBox();
            this.txtFees = new customDesignControl.ModernTextBox();
            this.btnSave = new customDesignControl.ModernDesignButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNoData = new System.Windows.Forms.Label();
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.cdgvCategoriesList = new Fitness_project.GlobalClasses.CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.addCategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCatTitle
            // 
            this.lblAddCatTitle.AutoSize = true;
            this.lblAddCatTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblAddCatTitle.Location = new System.Drawing.Point(326, 9);
            this.lblAddCatTitle.Name = "lblAddCatTitle";
            this.lblAddCatTitle.Size = new System.Drawing.Size(227, 30);
            this.lblAddCatTitle.TabIndex = 0;
            this.lblAddCatTitle.Text = "ADD NEW CATEGORY";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCategoryId.Location = new System.Drawing.Point(97, 31);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(103, 21);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category Id:";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCategoryName.Location = new System.Drawing.Point(97, 102);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(134, 21);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblDescription.Location = new System.Drawing.Point(97, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 21);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblfees.Location = new System.Drawing.Point(97, 256);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(47, 21);
            this.lblfees.TabIndex = 4;
            this.lblfees.Text = "Fees:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtCategoryId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCategoryId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCategoryId.BorderSize = 2;
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtCategoryId.Location = new System.Drawing.Point(97, 55);
            this.txtCategoryId.Multiline = false;
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategoryId.PasswordChar = false;
            this.txtCategoryId.Size = new System.Drawing.Size(600, 35);
            this.txtCategoryId.TabIndex = 5;
            this.txtCategoryId.Texts = "";
            this.txtCategoryId.UnderlinedStyle = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtCategoryName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCategoryName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCategoryName.BorderSize = 2;
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtCategoryName.Location = new System.Drawing.Point(97, 126);
            this.txtCategoryName.Multiline = false;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategoryName.PasswordChar = false;
            this.txtCategoryName.Size = new System.Drawing.Size(600, 35);
            this.txtCategoryName.TabIndex = 6;
            this.txtCategoryName.Texts = "";
            this.txtCategoryName.UnderlinedStyle = false;
            this.txtCategoryName.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCategoryName.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoryName_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtDescription.Location = new System.Drawing.Point(96, 200);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Size = new System.Drawing.Size(600, 35);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            this.txtDescription.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFees.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFees.BorderSize = 2;
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtFees.Location = new System.Drawing.Point(96, 280);
            this.txtFees.Multiline = false;
            this.txtFees.Name = "txtFees";
            this.txtFees.Padding = new System.Windows.Forms.Padding(7);
            this.txtFees.PasswordChar = false;
            this.txtFees.Size = new System.Drawing.Size(600, 35);
            this.txtFees.TabIndex = 8;
            this.txtFees.Texts = "";
            this.txtFees.UnderlinedStyle = false;
            this.txtFees.Enter += new System.EventHandler(this.txt_Enter);
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modernTextBox4_KeyPress);
            this.txtFees.Leave += new System.EventHandler(this.txt_Leave);
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(336, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Add";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.Location = new System.Drawing.Point(338, 553);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(247, 21);
            this.lblNoData.TabIndex = 16;
            this.lblNoData.Text = "No users found in the datebase";
            this.lblNoData.Visible = false;
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.addCategoryPanel.Controls.Add(this.txtCategoryId);
            this.addCategoryPanel.Controls.Add(this.txtCategoryName);
            this.addCategoryPanel.Controls.Add(this.txtDescription);
            this.addCategoryPanel.Controls.Add(this.btnSave);
            this.addCategoryPanel.Controls.Add(this.txtFees);
            this.addCategoryPanel.Controls.Add(this.lblfees);
            this.addCategoryPanel.Controls.Add(this.lblCategoryId);
            this.addCategoryPanel.Controls.Add(this.lblDescription);
            this.addCategoryPanel.Controls.Add(this.lblCategoryName);
            this.addCategoryPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryPanel.Location = new System.Drawing.Point(79, 50);
            this.addCategoryPanel.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Padding = new System.Windows.Forms.Padding(20);
            this.addCategoryPanel.Size = new System.Drawing.Size(720, 400);
            this.addCategoryPanel.TabIndex = 17;
            // 
            // cdgvCategoriesList
            // 
            this.cdgvCategoriesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.cdgvCategoriesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cdgvCategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdgvCategoriesList.Location = new System.Drawing.Point(0, 490);
            this.cdgvCategoriesList.Margin = new System.Windows.Forms.Padding(4);
            this.cdgvCategoriesList.Name = "cdgvCategoriesList";
            this.cdgvCategoriesList.Size = new System.Drawing.Size(879, 231);
            this.cdgvCategoriesList.TabIndex = 12;
            // 
            // ctrAddUpdateCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.cdgvCategoriesList);
            this.Controls.Add(this.lblAddCatTitle);
            this.Name = "ctrAddUpdateCategories";
            this.Size = new System.Drawing.Size(879, 721);
            this.Load += new System.EventHandler(this.ctrAddUpdateCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCatTitle;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblfees;
        private customDesignControl.ModernTextBox txtCategoryId;
        private customDesignControl.ModernTextBox txtCategoryName;
        private customDesignControl.ModernTextBox txtDescription;
        private customDesignControl.ModernTextBox txtFees;
        private customDesignControl.ModernDesignButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNoData;
        private GlobalClasses.CustomDataGridView cdgvCategoriesList;
        private System.Windows.Forms.Panel addCategoryPanel;
    }
}
