namespace Fitness_project.People
{
    partial class ctrFindPerson
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.ctrPersonInfo23 = new Fitness_project.personControls.ctrPersonInfo2();
            this.btnAddPeson = new customDesignControl.ModernDesignButton();
            this.btnSearch = new customDesignControl.ModernDesignButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.ctrPersonInfo22 = new Fitness_project.personControls.ctrPersonInfo2();
            this.ctrPersonInfo21 = new Fitness_project.personControls.ctrPersonInfo2();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gbFilter.Controls.Add(this.ctrPersonInfo23);
            this.gbFilter.Controls.Add(this.btnAddPeson);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtValue);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.lblFind);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gbFilter.Location = new System.Drawing.Point(48, 13);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(746, 60);
            this.gbFilter.TabIndex = 7;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // ctrPersonInfo23
            // 
            this.ctrPersonInfo23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ctrPersonInfo23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo23.isReadOnly = false;
            this.ctrPersonInfo23.Location = new System.Drawing.Point(0, 66);
            this.ctrPersonInfo23.Margin = new System.Windows.Forms.Padding(5);
            this.ctrPersonInfo23.Name = "ctrPersonInfo23";
            this.ctrPersonInfo23.Size = new System.Drawing.Size(625, 243);
            this.ctrPersonInfo23.TabIndex = 8;
            // 
            // btnAddPeson
            // 
            this.btnAddPeson.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPeson.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPeson.BorderColor = System.Drawing.Color.White;
            this.btnAddPeson.BorderRadius = 20;
            this.btnAddPeson.BorderSize = 2;
            this.btnAddPeson.FlatAppearance.BorderSize = 0;
            this.btnAddPeson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAddPeson.Location = new System.Drawing.Point(633, 10);
            this.btnAddPeson.Name = "btnAddPeson";
            this.btnAddPeson.Size = new System.Drawing.Size(113, 37);
            this.btnAddPeson.TabIndex = 6;
            this.btnAddPeson.Text = "add person";
            this.btnAddPeson.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAddPeson.UseVisualStyleBackColor = false;
            this.btnAddPeson.Click += new System.EventHandler(this.modernDesignButton1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSearch.Location = new System.Drawing.Point(505, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "search";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(273, 14);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(226, 27);
            this.txtValue.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.cbFilter.Location = new System.Drawing.Point(105, 15);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(162, 26);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFind.Location = new System.Drawing.Point(15, 18);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(70, 21);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Find By:";
            // 
            // ctrPersonInfo22
            // 
            this.ctrPersonInfo22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ctrPersonInfo22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo22.isReadOnly = false;
            this.ctrPersonInfo22.Location = new System.Drawing.Point(48, 74);
            this.ctrPersonInfo22.Margin = new System.Windows.Forms.Padding(5);
            this.ctrPersonInfo22.Name = "ctrPersonInfo22";
            this.ctrPersonInfo22.Size = new System.Drawing.Size(746, 350);
            this.ctrPersonInfo22.TabIndex = 8;
            // 
            // ctrPersonInfo21
            // 
            this.ctrPersonInfo21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ctrPersonInfo21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo21.isReadOnly = false;
            this.ctrPersonInfo21.Location = new System.Drawing.Point(13, 85);
            this.ctrPersonInfo21.Margin = new System.Windows.Forms.Padding(5);
            this.ctrPersonInfo21.Name = "ctrPersonInfo21";
            this.ctrPersonInfo21.Size = new System.Drawing.Size(625, 267);
            this.ctrPersonInfo21.TabIndex = 8;
            // 
            // ctrFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.ctrPersonInfo22);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrFindPerson";
            this.Size = new System.Drawing.Size(843, 443);
            this.Load += new System.EventHandler(this.ctrFindPerson_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private customDesignControl.ModernDesignButton btnSearch;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFind;
        private personControls.ctrPersonInfo2 ctrPersonInfo21;
        private customDesignControl.ModernDesignButton btnAddPeson;
        private personControls.ctrPersonInfo2 ctrPersonInfo23;
        private personControls.ctrPersonInfo2 ctrPersonInfo22;
    }
}
