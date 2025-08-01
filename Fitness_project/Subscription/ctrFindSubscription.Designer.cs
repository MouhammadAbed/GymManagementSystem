namespace Fitness_project.Subscription
{
    partial class ctrFindSubscription
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
            this.lblFindSubTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSerach = new customDesignControl.ModernDesignButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.ctrSubscriptionInfo1 = new Fitness_project.Subscription.ctrSubscriptionInfo();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFindSubTitle
            // 
            this.lblFindSubTitle.AutoSize = true;
            this.lblFindSubTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFindSubTitle.Location = new System.Drawing.Point(283, 14);
            this.lblFindSubTitle.Name = "lblFindSubTitle";
            this.lblFindSubTitle.Size = new System.Drawing.Size(304, 30);
            this.lblFindSubTitle.TabIndex = 0;
            this.lblFindSubTitle.Text = "FIND SUBSCRIPTION SCREEN";
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gbFilter.Controls.Add(this.btnSerach);
            this.gbFilter.Controls.Add(this.txtValue);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.lblFind);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gbFilter.Location = new System.Drawing.Point(38, 47);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(802, 58);
            this.gbFilter.TabIndex = 8;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSerach.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnSerach.BorderColor = System.Drawing.Color.White;
            this.btnSerach.BorderRadius = 20;
            this.btnSerach.BorderSize = 2;
            this.btnSerach.FlatAppearance.BorderSize = 0;
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSerach.Location = new System.Drawing.Point(667, 12);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(129, 35);
            this.btnSerach.TabIndex = 2;
            this.btnSerach.Text = "search";
            this.btnSerach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSerach.UseVisualStyleBackColor = false;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(437, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(228, 27);
            this.txtValue.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.cbFilter.Location = new System.Drawing.Point(220, 16);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(211, 26);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFind.Location = new System.Drawing.Point(35, 19);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(70, 21);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Find By:";
            // 
            // ctrSubscriptionInfo1
            // 
            this.ctrSubscriptionInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrSubscriptionInfo1.Location = new System.Drawing.Point(38, 106);
            this.ctrSubscriptionInfo1.Name = "ctrSubscriptionInfo1";
            this.ctrSubscriptionInfo1.Size = new System.Drawing.Size(802, 467);
            this.ctrSubscriptionInfo1.TabIndex = 9;
            // 
            // ctrFindSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.ctrSubscriptionInfo1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblFindSubTitle);
            this.Name = "ctrFindSubscription";
            this.Size = new System.Drawing.Size(879, 593);
            this.Load += new System.EventHandler(this.ctrFindSubscription_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindSubTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private customDesignControl.ModernDesignButton btnSerach;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFind;
        private ctrSubscriptionInfo ctrSubscriptionInfo1;
    }
}
