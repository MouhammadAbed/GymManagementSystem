namespace Fitness_project.Subscription
{
    partial class ctrAddNewSubscription
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.Tabcontrol = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrFindPerson1 = new Fitness_project.People.ctrFindPerson();
            this.tbSubsInfo = new System.Windows.Forms.TabPage();
            this.cmbMonthDuration = new System.Windows.Forms.ComboBox();
            this.lblMonthDuration = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.cmbTrainers = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtMemberName = new customDesignControl.ModernTextBox();
            this.txtFees = new customDesignControl.ModernTextBox();
            this.txtFinalFees = new customDesignControl.ModernTextBox();
            this.dtpSubEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSubStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinalFees = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnSave = new customDesignControl.ModernDesignButton();
            this.btnNext = new customDesignControl.ModernDesignButton();
            this.Tabcontrol.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbSubsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTitle.Location = new System.Drawing.Point(307, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADD NEW SUBSCRIPTION";
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tabcontrol.Controls.Add(this.tbPersonInfo);
            this.Tabcontrol.Controls.Add(this.tbSubsInfo);
            this.Tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Tabcontrol.ItemSize = new System.Drawing.Size(185, 30);
            this.Tabcontrol.Location = new System.Drawing.Point(24, 38);
            this.Tabcontrol.Multiline = true;
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(837, 552);
            this.Tabcontrol.TabIndex = 1;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tbPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPersonInfo.Controls.Add(this.ctrFindPerson1);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 34);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(829, 514);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrFindPerson1.Location = new System.Drawing.Point(2, -1);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.Size = new System.Drawing.Size(823, 504);
            this.ctrFindPerson1.TabIndex = 0;
            this.ctrFindPerson1.onPersonSelected += new System.Action<int>(this.ctrFindPerson1_onPersonSelected);
            // 
            // tbSubsInfo
            // 
            this.tbSubsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tbSubsInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSubsInfo.Controls.Add(this.cmbMonthDuration);
            this.tbSubsInfo.Controls.Add(this.lblMonthDuration);
            this.tbSubsInfo.Controls.Add(this.cmbDiscount);
            this.tbSubsInfo.Controls.Add(this.cmbTrainers);
            this.tbSubsInfo.Controls.Add(this.cmbCategories);
            this.tbSubsInfo.Controls.Add(this.txtMemberName);
            this.tbSubsInfo.Controls.Add(this.txtFees);
            this.tbSubsInfo.Controls.Add(this.txtFinalFees);
            this.tbSubsInfo.Controls.Add(this.dtpSubEndDate);
            this.tbSubsInfo.Controls.Add(this.dtpSubStartDate);
            this.tbSubsInfo.Controls.Add(this.lblFinalFees);
            this.tbSubsInfo.Controls.Add(this.lblDiscount);
            this.tbSubsInfo.Controls.Add(this.lblFees);
            this.tbSubsInfo.Controls.Add(this.lblEndDate);
            this.tbSubsInfo.Controls.Add(this.lblStartDate);
            this.tbSubsInfo.Controls.Add(this.lblCategory);
            this.tbSubsInfo.Controls.Add(this.lblTrainerName);
            this.tbSubsInfo.Controls.Add(this.lblMemberName);
            this.tbSubsInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbSubsInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tbSubsInfo.Location = new System.Drawing.Point(4, 34);
            this.tbSubsInfo.Name = "tbSubsInfo";
            this.tbSubsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbSubsInfo.Size = new System.Drawing.Size(829, 514);
            this.tbSubsInfo.TabIndex = 1;
            this.tbSubsInfo.Text = "Subscription Info";
            // 
            // cmbMonthDuration
            // 
            this.cmbMonthDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMonthDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonthDuration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbMonthDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbMonthDuration.FormattingEnabled = true;
            this.cmbMonthDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonthDuration.Location = new System.Drawing.Point(237, 286);
            this.cmbMonthDuration.Name = "cmbMonthDuration";
            this.cmbMonthDuration.Size = new System.Drawing.Size(562, 33);
            this.cmbMonthDuration.TabIndex = 24;
            this.cmbMonthDuration.SelectedIndexChanged += new System.EventHandler(this.cmbMonthDuration_SelectedIndexChanged);
            // 
            // lblMonthDuration
            // 
            this.lblMonthDuration.AutoSize = true;
            this.lblMonthDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMonthDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblMonthDuration.Location = new System.Drawing.Point(25, 292);
            this.lblMonthDuration.Name = "lblMonthDuration";
            this.lblMonthDuration.Size = new System.Drawing.Size(158, 21);
            this.lblMonthDuration.TabIndex = 23;
            this.lblMonthDuration.Text = "MONTH DURATION";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "0",
            "10",
            "25",
            "50",
            "75",
            "100"});
            this.cmbDiscount.Location = new System.Drawing.Point(237, 380);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(562, 33);
            this.cmbDiscount.TabIndex = 22;
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            this.cmbDiscount.TextUpdate += new System.EventHandler(this.cmbDiscount_TextUpdate);
            this.cmbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDiscount_KeyPress);
            // 
            // cmbTrainers
            // 
            this.cmbTrainers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTrainers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTrainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrainers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbTrainers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbTrainers.FormattingEnabled = true;
            this.cmbTrainers.Location = new System.Drawing.Point(237, 145);
            this.cmbTrainers.Name = "cmbTrainers";
            this.cmbTrainers.Size = new System.Drawing.Size(562, 33);
            this.cmbTrainers.TabIndex = 21;
            // 
            // cmbCategories
            // 
            this.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(237, 98);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(562, 33);
            this.cmbCategories.TabIndex = 20;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMemberName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMemberName.BorderFocusColor = System.Drawing.Color.Red;
            this.txtMemberName.BorderSize = 3;
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtMemberName.Location = new System.Drawing.Point(237, 49);
            this.txtMemberName.Multiline = false;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Padding = new System.Windows.Forms.Padding(7);
            this.txtMemberName.PasswordChar = false;
            this.txtMemberName.Size = new System.Drawing.Size(562, 36);
            this.txtMemberName.TabIndex = 19;
            this.txtMemberName.Texts = "";
            this.txtMemberName.UnderlinedStyle = false;
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFees.BorderFocusColor = System.Drawing.Color.Red;
            this.txtFees.BorderSize = 3;
            this.txtFees.Enabled = false;
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtFees.Location = new System.Drawing.Point(237, 331);
            this.txtFees.Multiline = false;
            this.txtFees.Name = "txtFees";
            this.txtFees.Padding = new System.Windows.Forms.Padding(7);
            this.txtFees.PasswordChar = false;
            this.txtFees.Size = new System.Drawing.Size(562, 36);
            this.txtFees.TabIndex = 17;
            this.txtFees.Texts = "";
            this.txtFees.UnderlinedStyle = false;
            // 
            // txtFinalFees
            // 
            this.txtFinalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFinalFees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFinalFees.BorderFocusColor = System.Drawing.Color.Red;
            this.txtFinalFees.BorderSize = 3;
            this.txtFinalFees.Enabled = false;
            this.txtFinalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtFinalFees.Location = new System.Drawing.Point(237, 425);
            this.txtFinalFees.Multiline = false;
            this.txtFinalFees.Name = "txtFinalFees";
            this.txtFinalFees.Padding = new System.Windows.Forms.Padding(7);
            this.txtFinalFees.PasswordChar = false;
            this.txtFinalFees.Size = new System.Drawing.Size(562, 36);
            this.txtFinalFees.TabIndex = 15;
            this.txtFinalFees.Texts = "";
            this.txtFinalFees.UnderlinedStyle = false;
            // 
            // dtpSubEndDate
            // 
            this.dtpSubEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtpSubEndDate.Enabled = false;
            this.dtpSubEndDate.Location = new System.Drawing.Point(237, 241);
            this.dtpSubEndDate.Name = "dtpSubEndDate";
            this.dtpSubEndDate.Size = new System.Drawing.Size(562, 29);
            this.dtpSubEndDate.TabIndex = 12;
            // 
            // dtpSubStartDate
            // 
            this.dtpSubStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtpSubStartDate.Location = new System.Drawing.Point(237, 194);
            this.dtpSubStartDate.Name = "dtpSubStartDate";
            this.dtpSubStartDate.Size = new System.Drawing.Size(562, 29);
            this.dtpSubStartDate.TabIndex = 11;
            this.dtpSubStartDate.ValueChanged += new System.EventHandler(this.dtpSubStartDate_ValueChanged);
            // 
            // lblFinalFees
            // 
            this.lblFinalFees.AutoSize = true;
            this.lblFinalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFinalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFinalFees.Location = new System.Drawing.Point(25, 433);
            this.lblFinalFees.Name = "lblFinalFees";
            this.lblFinalFees.Size = new System.Drawing.Size(94, 21);
            this.lblFinalFees.TabIndex = 7;
            this.lblFinalFees.Text = "FINAL FEES";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblDiscount.Location = new System.Drawing.Point(25, 386);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(92, 21);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "DISCOUNT";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFees.Location = new System.Drawing.Point(25, 339);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(45, 21);
            this.lblFees.TabIndex = 5;
            this.lblFees.Text = "FEES";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblEndDate.Location = new System.Drawing.Point(25, 245);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 21);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "END DATE";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblStartDate.Location = new System.Drawing.Point(25, 198);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(101, 21);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "START DATE";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCategory.Location = new System.Drawing.Point(25, 104);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 21);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "CATEGORY";
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTrainerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTrainerName.Location = new System.Drawing.Point(25, 151);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(129, 21);
            this.lblTrainerName.TabIndex = 1;
            this.lblTrainerName.Text = "TRAINER NAME";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMemberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblMemberName.Location = new System.Drawing.Point(25, 57);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(130, 21);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "MEMBER NAME";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 2;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(708, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnNext.BorderColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 2;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(541, 596);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrAddNewSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Tabcontrol);
            this.Controls.Add(this.lblTitle);
            this.Name = "ctrAddNewSubscription";
            this.Size = new System.Drawing.Size(884, 642);
            this.Tabcontrol.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbSubsInfo.ResumeLayout(false);
            this.tbSubsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl Tabcontrol;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private People.ctrFindPerson ctrFindPerson1;
        private System.Windows.Forms.TabPage tbSubsInfo;
        private customDesignControl.ModernDesignButton btnSave;
        private customDesignControl.ModernDesignButton btnNext;
        private System.Windows.Forms.Label lblFinalFees;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.DateTimePicker dtpSubEndDate;
        private System.Windows.Forms.DateTimePicker dtpSubStartDate;
        private System.Windows.Forms.ComboBox cmbCategories;
        private customDesignControl.ModernTextBox txtMemberName;
        private customDesignControl.ModernTextBox txtFees;
        private customDesignControl.ModernTextBox txtFinalFees;
        private System.Windows.Forms.ComboBox cmbTrainers;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.ComboBox cmbMonthDuration;
        private System.Windows.Forms.Label lblMonthDuration;
    }
}
