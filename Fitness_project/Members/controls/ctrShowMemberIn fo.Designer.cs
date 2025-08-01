namespace Fitness_project.Members.controls
{
    partial class ctrShowMemberInfo
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
            this.btnClose = new customDesignControl.ModernDesignButton();
            this.lblShowMemberTitle = new System.Windows.Forms.Label();
            this.ctrMemberInfo1 = new Fitness_project.Members.controls.ctrMemberInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 1;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OldLace;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(672, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(7);
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextColor = System.Drawing.Color.OldLace;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowMemberTitle
            // 
            this.lblShowMemberTitle.AutoSize = true;
            this.lblShowMemberTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMemberTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblShowMemberTitle.Location = new System.Drawing.Point(346, 17);
            this.lblShowMemberTitle.Name = "lblShowMemberTitle";
            this.lblShowMemberTitle.Size = new System.Drawing.Size(230, 30);
            this.lblShowMemberTitle.TabIndex = 3;
            this.lblShowMemberTitle.Text = "SHOW MEMBER INFO";
            // 
            // ctrMemberInfo1
            // 
            this.ctrMemberInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrMemberInfo1.Location = new System.Drawing.Point(50, 52);
            this.ctrMemberInfo1.Name = "ctrMemberInfo1";
            this.ctrMemberInfo1.Size = new System.Drawing.Size(787, 441);
            this.ctrMemberInfo1.TabIndex = 0;
            // 
            // ctrShowMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.lblShowMemberTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrMemberInfo1);
            this.Name = "ctrShowMemberInfo";
            this.Size = new System.Drawing.Size(887, 554);
            this.Load += new System.EventHandler(this.ctrShowMemberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrMemberInfo ctrMemberInfo1;
        private customDesignControl.ModernDesignButton btnClose;
        private System.Windows.Forms.Label lblShowMemberTitle;
    }
}
