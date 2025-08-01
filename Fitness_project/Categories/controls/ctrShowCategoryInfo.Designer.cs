namespace Fitness_project.Categories.controls
{
    partial class ctrShowCategoryInfo
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
            this.ctrCategoryInfo1 = new Fitness_project.Categories.controls.ctrCategoryInfo();
            this.lblShowCatTitle = new System.Windows.Forms.Label();
            this.btnClose = new customDesignControl.ModernDesignButton();
            this.SuspendLayout();
            // 
            // ctrCategoryInfo1
            // 
            this.ctrCategoryInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.ctrCategoryInfo1.Location = new System.Drawing.Point(59, 51);
            this.ctrCategoryInfo1.Name = "ctrCategoryInfo1";
            this.ctrCategoryInfo1.Size = new System.Drawing.Size(720, 323);
            this.ctrCategoryInfo1.TabIndex = 0;
            // 
            // lblShowCatTitle
            // 
            this.lblShowCatTitle.AutoSize = true;
            this.lblShowCatTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblShowCatTitle.Location = new System.Drawing.Point(294, 7);
            this.lblShowCatTitle.Name = "lblShowCatTitle";
            this.lblShowCatTitle.Size = new System.Drawing.Size(262, 30);
            this.lblShowCatTitle.TabIndex = 1;
            this.lblShowCatTitle.Text = "CATEGROY INFO SCREEN";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(362, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrShowCategoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblShowCatTitle);
            this.Controls.Add(this.ctrCategoryInfo1);
            this.Name = "ctrShowCategoryInfo";
            this.Size = new System.Drawing.Size(850, 456);
            this.Load += new System.EventHandler(this.ctrShowCategoryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrCategoryInfo ctrCategoryInfo1;
        private System.Windows.Forms.Label lblShowCatTitle;
        private customDesignControl.ModernDesignButton btnClose;
    }
}
