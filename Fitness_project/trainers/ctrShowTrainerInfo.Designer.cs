namespace Fitness_project.trainers
{
    partial class ctrShowTrainerInfo
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
            this.ctrTrainerInfo1 = new Fitness_project.Categories.ShowCategoriesInfo.ctrTrainerInfo();
            this.btnClose = new customDesignControl.ModernDesignButton();
            this.lblShowTrainerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrTrainerInfo1
            // 
            this.ctrTrainerInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrTrainerInfo1.Location = new System.Drawing.Point(12, 50);
            this.ctrTrainerInfo1.Name = "ctrTrainerInfo1";
            this.ctrTrainerInfo1.Size = new System.Drawing.Size(820, 495);
            this.ctrTrainerInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OldLace;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(674, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(7);
            this.btnClose.Size = new System.Drawing.Size(158, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextColor = System.Drawing.Color.OldLace;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowTrainerInfo
            // 
            this.lblShowTrainerInfo.AutoSize = true;
            this.lblShowTrainerInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTrainerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblShowTrainerInfo.Location = new System.Drawing.Point(328, 13);
            this.lblShowTrainerInfo.Name = "lblShowTrainerInfo";
            this.lblShowTrainerInfo.Size = new System.Drawing.Size(231, 30);
            this.lblShowTrainerInfo.TabIndex = 3;
            this.lblShowTrainerInfo.Text = "SHOW TRAINER INFO";
            // 
            // ctrShowTrainerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.lblShowTrainerInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrTrainerInfo1);
            this.Name = "ctrShowTrainerInfo";
            this.Size = new System.Drawing.Size(850, 601);
            this.Load += new System.EventHandler(this.ctrShowTrainerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Categories.ShowCategoriesInfo.ctrTrainerInfo ctrTrainerInfo1;
        private customDesignControl.ModernDesignButton btnClose;
        private System.Windows.Forms.Label lblShowTrainerInfo;
    }
}
