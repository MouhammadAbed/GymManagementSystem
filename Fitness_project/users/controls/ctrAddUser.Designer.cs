namespace Fitness_project.users.controls
{
    partial class ctrAddUser
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
            this.btnSave = new customDesignControl.ModernDesignButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new customDesignControl.ModernDesignButton();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValidatePassword = new customDesignControl.ModernTextBox();
            this.txtPassword = new customDesignControl.ModernTextBox();
            this.txtUsername = new customDesignControl.ModernTextBox();
            this.lblValidatePassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbPermission = new System.Windows.Forms.GroupBox();
            this.chbSubscriptionsTab = new System.Windows.Forms.CheckBox();
            this.chbCategoriesTab = new System.Windows.Forms.CheckBox();
            this.chbTrainersTab = new System.Windows.Forms.CheckBox();
            this.chbMembersTab = new System.Windows.Forms.CheckBox();
            this.chbUsersTab = new System.Windows.Forms.CheckBox();
            this.chbAuditTab = new System.Windows.Forms.CheckBox();
            this.chbfullAccess = new System.Windows.Forms.CheckBox();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrFindPerson1 = new Fitness_project.People.ctrFindPerson();
            this.tbaddUser = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPermission.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbaddUser.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(720, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.OldLace;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAddNewUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblAddNewUser.Location = new System.Drawing.Point(357, 5);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(171, 30);
            this.lblAddNewUser.TabIndex = 0;
            this.lblAddNewUser.Text = "ADD NEW USER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 31);
            this.panel1.TabIndex = 1;
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
            this.btnNext.Location = new System.Drawing.Point(564, 613);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.OldLace;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbUser.Controls.Add(this.panel2);
            this.tbUser.Controls.Add(this.gbPermission);
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbUser.Location = new System.Drawing.Point(4, 34);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbUser.Size = new System.Drawing.Size(856, 524);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "User Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtValidatePassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lblValidatePassword);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(7, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 157);
            this.panel2.TabIndex = 7;
            // 
            // txtValidatePassword
            // 
            this.txtValidatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtValidatePassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValidatePassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValidatePassword.BorderSize = 2;
            this.txtValidatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtValidatePassword.Location = new System.Drawing.Point(175, 110);
            this.txtValidatePassword.Multiline = false;
            this.txtValidatePassword.Name = "txtValidatePassword";
            this.txtValidatePassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtValidatePassword.PasswordChar = true;
            this.txtValidatePassword.Size = new System.Drawing.Size(633, 35);
            this.txtValidatePassword.TabIndex = 11;
            this.txtValidatePassword.Texts = "";
            this.txtValidatePassword.UnderlinedStyle = false;
            this.txtValidatePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtValidatePassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtPassword.Location = new System.Drawing.Point(125, 58);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(683, 35);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtValidating);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtUsername.Location = new System.Drawing.Point(125, 6);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.Size = new System.Drawing.Size(683, 35);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblValidatePassword
            // 
            this.lblValidatePassword.AutoSize = true;
            this.lblValidatePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblValidatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblValidatePassword.Location = new System.Drawing.Point(3, 118);
            this.lblValidatePassword.Name = "lblValidatePassword";
            this.lblValidatePassword.Size = new System.Drawing.Size(153, 21);
            this.lblValidatePassword.TabIndex = 8;
            this.lblValidatePassword.Text = "Validate Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblPassword.Location = new System.Drawing.Point(9, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 21);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblUsername.Location = new System.Drawing.Point(9, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // gbPermission
            // 
            this.gbPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gbPermission.Controls.Add(this.chbSubscriptionsTab);
            this.gbPermission.Controls.Add(this.chbCategoriesTab);
            this.gbPermission.Controls.Add(this.chbTrainersTab);
            this.gbPermission.Controls.Add(this.chbMembersTab);
            this.gbPermission.Controls.Add(this.chbUsersTab);
            this.gbPermission.Controls.Add(this.chbAuditTab);
            this.gbPermission.Controls.Add(this.chbfullAccess);
            this.gbPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gbPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gbPermission.Location = new System.Drawing.Point(7, 164);
            this.gbPermission.Name = "gbPermission";
            this.gbPermission.Size = new System.Drawing.Size(838, 350);
            this.gbPermission.TabIndex = 6;
            this.gbPermission.TabStop = false;
            this.gbPermission.Text = "USER PERMISSIONS";
            // 
            // chbSubscriptionsTab
            // 
            this.chbSubscriptionsTab.AutoSize = true;
            this.chbSubscriptionsTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbSubscriptionsTab.Location = new System.Drawing.Point(19, 239);
            this.chbSubscriptionsTab.Name = "chbSubscriptionsTab";
            this.chbSubscriptionsTab.Size = new System.Drawing.Size(272, 29);
            this.chbSubscriptionsTab.TabIndex = 10;
            this.chbSubscriptionsTab.Tag = "32";
            this.chbSubscriptionsTab.Text = "Access to Subscriptions tab";
            this.chbSubscriptionsTab.UseVisualStyleBackColor = true;
            // 
            // chbCategoriesTab
            // 
            this.chbCategoriesTab.AutoSize = true;
            this.chbCategoriesTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbCategoriesTab.Location = new System.Drawing.Point(19, 196);
            this.chbCategoriesTab.Name = "chbCategoriesTab";
            this.chbCategoriesTab.Size = new System.Drawing.Size(245, 29);
            this.chbCategoriesTab.TabIndex = 9;
            this.chbCategoriesTab.Tag = "16";
            this.chbCategoriesTab.Text = "Access to Categories tab";
            this.chbCategoriesTab.UseVisualStyleBackColor = true;
            // 
            // chbTrainersTab
            // 
            this.chbTrainersTab.AutoSize = true;
            this.chbTrainersTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbTrainersTab.Location = new System.Drawing.Point(19, 153);
            this.chbTrainersTab.Name = "chbTrainersTab";
            this.chbTrainersTab.Size = new System.Drawing.Size(222, 29);
            this.chbTrainersTab.TabIndex = 8;
            this.chbTrainersTab.Tag = "8";
            this.chbTrainersTab.Text = "Access to Trainers tab";
            this.chbTrainersTab.UseVisualStyleBackColor = true;
            // 
            // chbMembersTab
            // 
            this.chbMembersTab.AutoSize = true;
            this.chbMembersTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbMembersTab.Location = new System.Drawing.Point(19, 110);
            this.chbMembersTab.Name = "chbMembersTab";
            this.chbMembersTab.Size = new System.Drawing.Size(234, 29);
            this.chbMembersTab.TabIndex = 7;
            this.chbMembersTab.Tag = "4";
            this.chbMembersTab.Text = "Access to Members tab";
            this.chbMembersTab.UseVisualStyleBackColor = true;
            // 
            // chbUsersTab
            // 
            this.chbUsersTab.AutoSize = true;
            this.chbUsersTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbUsersTab.Location = new System.Drawing.Point(19, 67);
            this.chbUsersTab.Name = "chbUsersTab";
            this.chbUsersTab.Size = new System.Drawing.Size(199, 29);
            this.chbUsersTab.TabIndex = 6;
            this.chbUsersTab.Tag = "2";
            this.chbUsersTab.Text = "Access to Users tab";
            this.chbUsersTab.UseVisualStyleBackColor = true;
            // 
            // chbAuditTab
            // 
            this.chbAuditTab.AutoSize = true;
            this.chbAuditTab.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbAuditTab.Location = new System.Drawing.Point(19, 282);
            this.chbAuditTab.Name = "chbAuditTab";
            this.chbAuditTab.Size = new System.Drawing.Size(200, 29);
            this.chbAuditTab.TabIndex = 5;
            this.chbAuditTab.Tag = "64";
            this.chbAuditTab.Text = "Access to Audit tab";
            this.chbAuditTab.UseVisualStyleBackColor = true;
            // 
            // chbfullAccess
            // 
            this.chbfullAccess.AutoSize = true;
            this.chbfullAccess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chbfullAccess.Location = new System.Drawing.Point(19, 24);
            this.chbfullAccess.Name = "chbfullAccess";
            this.chbfullAccess.Size = new System.Drawing.Size(266, 29);
            this.chbfullAccess.TabIndex = 0;
            this.chbfullAccess.Tag = "0";
            this.chbfullAccess.Text = "Give full access to this user";
            this.chbfullAccess.UseVisualStyleBackColor = true;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbPersonInfo.Controls.Add(this.ctrFindPerson1);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 34);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(856, 524);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrFindPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrFindPerson1.Location = new System.Drawing.Point(3, 3);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.Size = new System.Drawing.Size(846, 514);
            this.ctrFindPerson1.TabIndex = 0;
            this.ctrFindPerson1.onPersonSelected += new System.Action<int>(this.ctrFindPerson1_onPersonSelected);
            // 
            // tbaddUser
            // 
            this.tbaddUser.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbaddUser.Controls.Add(this.tbPersonInfo);
            this.tbaddUser.Controls.Add(this.tbUser);
            this.tbaddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbaddUser.ItemSize = new System.Drawing.Size(185, 30);
            this.tbaddUser.Location = new System.Drawing.Point(10, 45);
            this.tbaddUser.Multiline = true;
            this.tbaddUser.Name = "tbaddUser";
            this.tbaddUser.SelectedIndex = 0;
            this.tbaddUser.Size = new System.Drawing.Size(864, 562);
            this.tbaddUser.TabIndex = 0;
            // 
            // ctrAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbaddUser);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrAddUser";
            this.Size = new System.Drawing.Size(884, 651);
            this.Load += new System.EventHandler(this.ctrAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbUser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbPermission.ResumeLayout(false);
            this.gbPermission.PerformLayout();
            this.tbPersonInfo.ResumeLayout(false);
            this.tbaddUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private customDesignControl.ModernDesignButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNewUser;
        private customDesignControl.ModernDesignButton btnNext;
        private System.Windows.Forms.TabControl tbaddUser;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private People.ctrFindPerson ctrFindPerson1;
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.Panel panel2;
        private customDesignControl.ModernTextBox txtValidatePassword;
        private customDesignControl.ModernTextBox txtPassword;
        private customDesignControl.ModernTextBox txtUsername;
        private System.Windows.Forms.Label lblValidatePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbPermission;
        private System.Windows.Forms.CheckBox chbSubscriptionsTab;
        private System.Windows.Forms.CheckBox chbCategoriesTab;
        private System.Windows.Forms.CheckBox chbTrainersTab;
        private System.Windows.Forms.CheckBox chbMembersTab;
        private System.Windows.Forms.CheckBox chbUsersTab;
        private System.Windows.Forms.CheckBox chbAuditTab;
        private System.Windows.Forms.CheckBox chbfullAccess;
    }
}
