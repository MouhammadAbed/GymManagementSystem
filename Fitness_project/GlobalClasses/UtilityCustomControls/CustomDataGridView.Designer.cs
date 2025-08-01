namespace Fitness_project.GlobalClasses
{
    partial class CustomDataGridView
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
            this.dgvBindData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBindData
            // 
            this.dgvBindData.AllowUserToAddRows = false;
            this.dgvBindData.AllowUserToDeleteRows = false;
            this.dgvBindData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBindData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBindData.Location = new System.Drawing.Point(0, 0);
            this.dgvBindData.Name = "dgvBindData";
            this.dgvBindData.Size = new System.Drawing.Size(684, 410);
            this.dgvBindData.TabIndex = 3;
            this.dgvBindData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBindData_CellClick_1);
            this.dgvBindData.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBindData_CellMouseEnter);
            this.dgvBindData.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBindData_CellMouseLeave);
            // 
            // CustomDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.dgvBindData);
            this.Name = "CustomDataGridView";
            this.Size = new System.Drawing.Size(684, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBindData;
    }
}
