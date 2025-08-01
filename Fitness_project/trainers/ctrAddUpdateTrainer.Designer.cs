namespace Fitness_project.trainers
{
    partial class ctrAddUpdateTrainer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrFindPerson2 = new Fitness_project.People.ctrFindPerson();
            this.tbTrainerInfo = new System.Windows.Forms.TabPage();
            this.txtSalary = new customDesignControl.ModernTextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new customDesignControl.ModernTextBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.txtId = new customDesignControl.ModernTextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbAllCategories = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.lblTrainerCategories = new System.Windows.Forms.Label();
            this.txtTrainerCategories = new customDesignControl.ModernTextBox();
            this.lblAddNewTrainer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new customDesignControl.ModernDesignButton();
            this.btnSave = new customDesignControl.ModernDesignButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbTrainerInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbTrainerInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(185, 30);
            this.tabControl1.Location = new System.Drawing.Point(6, 45);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbPersonInfo.Controls.Add(this.ctrFindPerson2);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbPersonInfo.ForeColor = System.Drawing.Color.White;
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 34);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(865, 514);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            // 
            // ctrFindPerson2
            // 
            this.ctrFindPerson2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrFindPerson2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrFindPerson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFindPerson2.Location = new System.Drawing.Point(3, 3);
            this.ctrFindPerson2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrFindPerson2.Name = "ctrFindPerson2";
            this.ctrFindPerson2.Size = new System.Drawing.Size(855, 504);
            this.ctrFindPerson2.TabIndex = 0;
            this.ctrFindPerson2.onPersonSelected += new System.Action<int>(this.ctrFindPerson2_onPersonSelected);
            // 
            // tbTrainerInfo
            // 
            this.tbTrainerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tbTrainerInfo.Controls.Add(this.txtSalary);
            this.tbTrainerInfo.Controls.Add(this.lblFullName);
            this.tbTrainerInfo.Controls.Add(this.txtFullName);
            this.tbTrainerInfo.Controls.Add(this.lblPersonId);
            this.tbTrainerInfo.Controls.Add(this.txtId);
            this.tbTrainerInfo.Controls.Add(this.lblSalary);
            this.tbTrainerInfo.Controls.Add(this.cmbAllCategories);
            this.tbTrainerInfo.Controls.Add(this.lblSelectCategory);
            this.tbTrainerInfo.Controls.Add(this.lblTrainerCategories);
            this.tbTrainerInfo.Controls.Add(this.txtTrainerCategories);
            this.tbTrainerInfo.Location = new System.Drawing.Point(4, 34);
            this.tbTrainerInfo.Name = "tbTrainerInfo";
            this.tbTrainerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbTrainerInfo.Size = new System.Drawing.Size(865, 514);
            this.tbTrainerInfo.TabIndex = 1;
            this.tbTrainerInfo.Text = "Trainer Info";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSalary.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSalary.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSalary.BorderSize = 2;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtSalary.Location = new System.Drawing.Point(217, 368);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Padding = new System.Windows.Forms.Padding(7);
            this.txtSalary.PasswordChar = false;
            this.txtSalary.Size = new System.Drawing.Size(631, 40);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.Texts = "";
            this.txtSalary.UnderlinedStyle = false;
            this.txtSalary.Enter += new System.EventHandler(this.txt_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress_1);
            this.txtSalary.Leave += new System.EventHandler(this.txt_Leave);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFullName.Location = new System.Drawing.Point(13, 121);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(101, 25);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFullName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFullName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFullName.BorderSize = 2;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtFullName.Location = new System.Drawing.Point(217, 113);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFullName.PasswordChar = false;
            this.txtFullName.Size = new System.Drawing.Size(631, 40);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.Texts = "";
            this.txtFullName.UnderlinedStyle = false;
            this.txtFullName.Enter += new System.EventHandler(this.txt_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblPersonId.Location = new System.Drawing.Point(13, 36);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(98, 25);
            this.lblPersonId.TabIndex = 7;
            this.lblPersonId.Text = "Person ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtId.Location = new System.Drawing.Point(217, 28);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(631, 40);
            this.txtId.TabIndex = 6;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            this.txtId.Enter += new System.EventHandler(this.txt_Enter);
            this.txtId.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblSalary.Location = new System.Drawing.Point(13, 376);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(67, 25);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // cmbAllCategories
            // 
            this.cmbAllCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAllCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAllCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.cmbAllCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAllCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbAllCategories.FormattingEnabled = true;
            this.cmbAllCategories.IntegralHeight = false;
            this.cmbAllCategories.Location = new System.Drawing.Point(217, 287);
            this.cmbAllCategories.Name = "cmbAllCategories";
            this.cmbAllCategories.Size = new System.Drawing.Size(631, 33);
            this.cmbAllCategories.TabIndex = 3;
            this.cmbAllCategories.SelectedIndexChanged += new System.EventHandler(this.cmbAllCategories_SelectedIndexChanged);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblSelectCategory.Location = new System.Drawing.Point(13, 291);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(151, 25);
            this.lblSelectCategory.TabIndex = 2;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // lblTrainerCategories
            // 
            this.lblTrainerCategories.AutoSize = true;
            this.lblTrainerCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTrainerCategories.Location = new System.Drawing.Point(13, 206);
            this.lblTrainerCategories.Name = "lblTrainerCategories";
            this.lblTrainerCategories.Size = new System.Drawing.Size(187, 25);
            this.lblTrainerCategories.TabIndex = 1;
            this.lblTrainerCategories.Text = "Trainer\'s Categories";
            // 
            // txtTrainerCategories
            // 
            this.txtTrainerCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtTrainerCategories.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTrainerCategories.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTrainerCategories.BorderSize = 2;
            this.txtTrainerCategories.Enabled = false;
            this.txtTrainerCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtTrainerCategories.Location = new System.Drawing.Point(217, 198);
            this.txtTrainerCategories.Multiline = false;
            this.txtTrainerCategories.Name = "txtTrainerCategories";
            this.txtTrainerCategories.Padding = new System.Windows.Forms.Padding(7);
            this.txtTrainerCategories.PasswordChar = false;
            this.txtTrainerCategories.Size = new System.Drawing.Size(631, 40);
            this.txtTrainerCategories.TabIndex = 0;
            this.txtTrainerCategories.Texts = "";
            this.txtTrainerCategories.UnderlinedStyle = false;
            this.txtTrainerCategories.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTrainerCategories.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblAddNewTrainer
            // 
            this.lblAddNewTrainer.AutoSize = true;
            this.lblAddNewTrainer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewTrainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblAddNewTrainer.Location = new System.Drawing.Point(338, 5);
            this.lblAddNewTrainer.Name = "lblAddNewTrainer";
            this.lblAddNewTrainer.Size = new System.Drawing.Size(209, 30);
            this.lblAddNewTrainer.TabIndex = 0;
            this.lblAddNewTrainer.Text = "ADD NEW TRAINER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddNewTrainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 0;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.OldLace;
            this.btnNext.Location = new System.Drawing.Point(569, 599);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 45);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.OldLace;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.OldLace;
            this.btnSave.Location = new System.Drawing.Point(725, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.OldLace;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddUpdateTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ctrAddUpdateTrainer";
            this.Size = new System.Drawing.Size(884, 651);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbTrainerInfo.ResumeLayout(false);
            this.tbTrainerInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbTrainerInfo;
        private System.Windows.Forms.Label lblAddNewTrainer;
        private System.Windows.Forms.Panel panel1;
        private customDesignControl.ModernDesignButton btnNext;
        private customDesignControl.ModernDesignButton btnSave;
        private People.ctrFindPerson ctrFindPerson2;
        private System.Windows.Forms.Label lblTrainerCategories;
        private customDesignControl.ModernTextBox txtTrainerCategories;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cmbAllCategories;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFullName;
        private customDesignControl.ModernTextBox txtFullName;
        private System.Windows.Forms.Label lblPersonId;
        private customDesignControl.ModernTextBox txtId;
        private customDesignControl.ModernTextBox txtSalary;
    }
}
