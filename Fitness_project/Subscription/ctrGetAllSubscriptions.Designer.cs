namespace Fitness_project.Subscription
{
    partial class ctrGetAllSubscriptions
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cmbFilterOptions = new customDesignControl.ModernComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowSubscriptionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewSubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENEWONEMONTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENEWTOWMONTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENEW3MONTHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATESUBSCRIPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETESUBSCRIPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdgvSubscriptionsList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(353, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(325, 29);
            this.txtValue.TabIndex = 11;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(26, 20);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(84, 21);
            this.lblSearchBy.TabIndex = 12;
            this.lblSearchBy.Text = "Search By";
            // 
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.AutoCompleteCustomSource.AddRange(new string[] {
            "Full Name",
            "Category",
            "Trainer"});
            this.cmbFilterOptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFilterOptions.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbFilterOptions.BorderSize = 1;
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterOptions.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.IconColor = System.Drawing.Color.Blue;
            this.cmbFilterOptions.Items.AddRange(new object[] {
            "All",
            "MEMBER Full Name",
            "Category",
            "TRAINER FULL NAME"});
            this.cmbFilterOptions.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFilterOptions.ListTextColor = System.Drawing.Color.Black;
            this.cmbFilterOptions.Location = new System.Drawing.Point(140, 15);
            this.cmbFilterOptions.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFilterOptions.Size = new System.Drawing.Size(200, 30);
            this.cmbFilterOptions.TabIndex = 10;
            this.cmbFilterOptions.Texts = "";
            this.cmbFilterOptions.OnSelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_OnSelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubscriptionToolStripMenuItem,
            this.ShowSubscriptionInfoToolStripMenuItem,
            this.RenewSubscriptionToolStripMenuItem,
            this.uPDATESUBSCRIPTIONToolStripMenuItem,
            this.dELETESUBSCRIPTIONToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 216);
            // 
            // addSubscriptionToolStripMenuItem
            // 
            this.addSubscriptionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addSubscriptionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubscriptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addSubscriptionToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.addSubscriptionToolStripMenuItem.Name = "addSubscriptionToolStripMenuItem";
            this.addSubscriptionToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.addSubscriptionToolStripMenuItem.Text = "ADD SUBSCRIPTION";
            this.addSubscriptionToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // ShowSubscriptionInfoToolStripMenuItem
            // 
            this.ShowSubscriptionInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowSubscriptionInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSubscriptionInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowSubscriptionInfoToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.ShowSubscriptionInfoToolStripMenuItem.Name = "ShowSubscriptionInfoToolStripMenuItem";
            this.ShowSubscriptionInfoToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.ShowSubscriptionInfoToolStripMenuItem.Text = "SHOW SUBSCRIPTION INFO";
            this.ShowSubscriptionInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowSubscriptionInfoToolStripMenuItem_Click);
            // 
            // RenewSubscriptionToolStripMenuItem
            // 
            this.RenewSubscriptionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RenewSubscriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rENEWONEMONTHToolStripMenuItem,
            this.rENEWTOWMONTHToolStripMenuItem,
            this.rENEW3MONTHSToolStripMenuItem});
            this.RenewSubscriptionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.RenewSubscriptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RenewSubscriptionToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_renew_subscription_48;
            this.RenewSubscriptionToolStripMenuItem.Name = "RenewSubscriptionToolStripMenuItem";
            this.RenewSubscriptionToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.RenewSubscriptionToolStripMenuItem.Text = "RENEW SUBSCRIPTION";
            // 
            // rENEWONEMONTHToolStripMenuItem
            // 
            this.rENEWONEMONTHToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rENEWONEMONTHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rENEWONEMONTHToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_renew_subscription_481;
            this.rENEWONEMONTHToolStripMenuItem.Name = "rENEWONEMONTHToolStripMenuItem";
            this.rENEWONEMONTHToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.rENEWONEMONTHToolStripMenuItem.Text = "1-MONTH RENEWAL";
            this.rENEWONEMONTHToolStripMenuItem.Click += new System.EventHandler(this.rENEWONEMONTHToolStripMenuItem_Click);
            // 
            // rENEWTOWMONTHToolStripMenuItem
            // 
            this.rENEWTOWMONTHToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rENEWTOWMONTHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rENEWTOWMONTHToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_renew_subscription_481;
            this.rENEWTOWMONTHToolStripMenuItem.Name = "rENEWTOWMONTHToolStripMenuItem";
            this.rENEWTOWMONTHToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.rENEWTOWMONTHToolStripMenuItem.Text = "2-MONTHS RENEWAL";
            this.rENEWTOWMONTHToolStripMenuItem.Click += new System.EventHandler(this.rENEWTOWMONTHToolStripMenuItem_Click);
            // 
            // rENEW3MONTHSToolStripMenuItem
            // 
            this.rENEW3MONTHSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rENEW3MONTHSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rENEW3MONTHSToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_renew_subscription_481;
            this.rENEW3MONTHSToolStripMenuItem.Name = "rENEW3MONTHSToolStripMenuItem";
            this.rENEW3MONTHSToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.rENEW3MONTHSToolStripMenuItem.Text = "3-MONTHS RENEWAL";
            this.rENEW3MONTHSToolStripMenuItem.Click += new System.EventHandler(this.rENEW3MONTHSToolStripMenuItem_Click);
            // 
            // uPDATESUBSCRIPTIONToolStripMenuItem
            // 
            this.uPDATESUBSCRIPTIONToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.uPDATESUBSCRIPTIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_321;
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Name = "uPDATESUBSCRIPTIONToolStripMenuItem";
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Text = "UPDATE SUBSCRIPTION";
            this.uPDATESUBSCRIPTIONToolStripMenuItem.Click += new System.EventHandler(this.uPDATESUBSCRIPTIONToolStripMenuItem_Click);
            // 
            // dELETESUBSCRIPTIONToolStripMenuItem
            // 
            this.dELETESUBSCRIPTIONToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dELETESUBSCRIPTIONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.dELETESUBSCRIPTIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dELETESUBSCRIPTIONToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.error;
            this.dELETESUBSCRIPTIONToolStripMenuItem.Name = "dELETESUBSCRIPTIONToolStripMenuItem";
            this.dELETESUBSCRIPTIONToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.dELETESUBSCRIPTIONToolStripMenuItem.Text = "DELETE SUBSCRIPTION";
            // 
            // cdgvSubscriptionsList
            // 
            this.cdgvSubscriptionsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.cdgvSubscriptionsList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdgvSubscriptionsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cdgvSubscriptionsList.Location = new System.Drawing.Point(0, 65);
            this.cdgvSubscriptionsList.Name = "cdgvSubscriptionsList";
            this.cdgvSubscriptionsList.Size = new System.Drawing.Size(879, 625);
            this.cdgvSubscriptionsList.TabIndex = 13;
            // 
            // ctrGetAllSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.cdgvSubscriptionsList);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.cmbFilterOptions);
            this.Name = "ctrGetAllSubscriptions";
            this.Size = new System.Drawing.Size(879, 690);
            this.Load += new System.EventHandler(this.ctrGetAllSubscriptions_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblSearchBy;
        private customDesignControl.ModernComboBox cmbFilterOptions;
        private GlobalClasses.CustomDataGridView cdgvSubscriptionsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addSubscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowSubscriptionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenewSubscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENEWONEMONTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENEWTOWMONTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENEW3MONTHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATESUBSCRIPTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETESUBSCRIPTIONToolStripMenuItem;
    }
}
