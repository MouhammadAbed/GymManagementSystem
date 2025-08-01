namespace Fitness_project.Categories.ShowCategoriesInfo
{
    partial class ctrTrainerInfo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTrains = new System.Windows.Forms.MaskedTextBox();
            this.lblTrains = new System.Windows.Forms.Label();
            this.ctrPersonInfo22 = new Fitness_project.personControls.ctrPersonInfo2();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.txtTrains);
            this.panel2.Controls.Add(this.lblTrains);
            this.panel2.Controls.Add(this.ctrPersonInfo22);
            this.panel2.Location = new System.Drawing.Point(26, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 501);
            this.panel2.TabIndex = 21;
            // 
            // txtTrains
            // 
            this.txtTrains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtTrains.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtTrains.Location = new System.Drawing.Point(43, 367);
            this.txtTrains.Margin = new System.Windows.Forms.Padding(5);
            this.txtTrains.Name = "txtTrains";
            this.txtTrains.ReadOnly = true;
            this.txtTrains.Size = new System.Drawing.Size(601, 29);
            this.txtTrains.TabIndex = 25;
            // 
            // lblTrains
            // 
            this.lblTrains.AutoSize = true;
            this.lblTrains.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTrains.Location = new System.Drawing.Point(43, 345);
            this.lblTrains.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTrains.Name = "lblTrains";
            this.lblTrains.Size = new System.Drawing.Size(59, 21);
            this.lblTrains.TabIndex = 23;
            this.lblTrains.Text = "Trains:";
            // 
            // ctrPersonInfo22
            // 
            this.ctrPersonInfo22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrPersonInfo22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo22.isReadOnly = false;
            this.ctrPersonInfo22.Location = new System.Drawing.Point(25, 7);
            this.ctrPersonInfo22.Margin = new System.Windows.Forms.Padding(5);
            this.ctrPersonInfo22.Name = "ctrPersonInfo22";
            this.ctrPersonInfo22.Size = new System.Drawing.Size(747, 332);
            this.ctrPersonInfo22.TabIndex = 21;
            // 
            // ctrTrainerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.panel2);
            this.Name = "ctrTrainerInfo";
            this.Size = new System.Drawing.Size(850, 520);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtTrains;
        private System.Windows.Forms.Label lblTrains;
        private personControls.ctrPersonInfo2 ctrPersonInfo22;
    }
}
