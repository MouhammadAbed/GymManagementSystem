namespace Fitness_project.Members.controls
{
    partial class ctrAddUpdateMember
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddNewMember = new System.Windows.Forms.Label();
            this.btnAddMember = new customDesignControl.ModernDesignButton();
            this.ctrFindPerson2 = new Fitness_project.People.ctrFindPerson();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddNewMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 47);
            this.panel1.TabIndex = 2;
            // 
            // lblAddNewMember
            // 
            this.lblAddNewMember.AutoSize = true;
            this.lblAddNewMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblAddNewMember.Location = new System.Drawing.Point(337, 5);
            this.lblAddNewMember.Name = "lblAddNewMember";
            this.lblAddNewMember.Size = new System.Drawing.Size(208, 30);
            this.lblAddNewMember.TabIndex = 0;
            this.lblAddNewMember.Text = "ADD NEW MEMBER";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddMember.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddMember.BorderRadius = 20;
            this.btnAddMember.BorderSize = 0;
            this.btnAddMember.Enabled = false;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.OldLace;
            this.btnAddMember.Location = new System.Drawing.Point(669, 573);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(170, 45);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.TextColor = System.Drawing.Color.OldLace;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // ctrFindPerson2
            // 
            this.ctrFindPerson2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrFindPerson2.Location = new System.Drawing.Point(45, 53);
            this.ctrFindPerson2.Name = "ctrFindPerson2";
            this.ctrFindPerson2.Size = new System.Drawing.Size(794, 514);
            this.ctrFindPerson2.TabIndex = 7;
            this.ctrFindPerson2.onPersonSelected += new System.Action<int>(this.ctrFindPerson2_onPersonSelected);
            // 
            // ctrAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.ctrFindPerson2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddMember);
            this.Name = "ctrAddUpdateMember";
            this.Size = new System.Drawing.Size(884, 698);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNewMember;
        private customDesignControl.ModernDesignButton btnAddMember;
        private People.ctrFindPerson ctrFindPerson2;
    }
}
