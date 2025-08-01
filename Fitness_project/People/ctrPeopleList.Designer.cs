namespace Fitness_project.People
{
    partial class ctrPeopleList
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aDDNEWPERSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITPERSONINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWPERSONINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdvPeopleList = new Fitness_project.GlobalClasses.CustomDataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEOPLE LIST SCREEN";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWPERSONToolStripMenuItem,
            this.eDITPERSONINFOToolStripMenuItem,
            this.sHOWPERSONINFOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 140);
            // 
            // aDDNEWPERSONToolStripMenuItem
            // 
            this.aDDNEWPERSONToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aDDNEWPERSONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.aDDNEWPERSONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aDDNEWPERSONToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.Add_35;
            this.aDDNEWPERSONToolStripMenuItem.Name = "aDDNEWPERSONToolStripMenuItem";
            this.aDDNEWPERSONToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.aDDNEWPERSONToolStripMenuItem.Text = "ADD NEW PERSON";
            this.aDDNEWPERSONToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWPERSONToolStripMenuItem_Click);
            // 
            // eDITPERSONINFOToolStripMenuItem
            // 
            this.eDITPERSONINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eDITPERSONINFOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.eDITPERSONINFOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eDITPERSONINFOToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_update_32;
            this.eDITPERSONINFOToolStripMenuItem.Name = "eDITPERSONINFOToolStripMenuItem";
            this.eDITPERSONINFOToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.eDITPERSONINFOToolStripMenuItem.Text = "EDIT PERSON INFO";
            this.eDITPERSONINFOToolStripMenuItem.Click += new System.EventHandler(this.eDITPERSONINFOToolStripMenuItem_Click);
            // 
            // sHOWPERSONINFOToolStripMenuItem
            // 
            this.sHOWPERSONINFOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sHOWPERSONINFOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.sHOWPERSONINFOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOWPERSONINFOToolStripMenuItem.Image = global::Fitness_project.Properties.Resources.icons8_show_32;
            this.sHOWPERSONINFOToolStripMenuItem.Name = "sHOWPERSONINFOToolStripMenuItem";
            this.sHOWPERSONINFOToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.sHOWPERSONINFOToolStripMenuItem.Text = "SHOW PERSON INFO";
            this.sHOWPERSONINFOToolStripMenuItem.Click += new System.EventHandler(this.sHOWPERSONINFOToolStripMenuItem_Click);
            // 
            // cdvPeopleList
            // 
            this.cdvPeopleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.cdvPeopleList.ContextMenuStrip = this.contextMenuStrip1;
            this.cdvPeopleList.Location = new System.Drawing.Point(49, 83);
            this.cdvPeopleList.Margin = new System.Windows.Forms.Padding(10);
            this.cdvPeopleList.Name = "cdvPeopleList";
            this.cdvPeopleList.Padding = new System.Windows.Forms.Padding(10);
            this.cdvPeopleList.Size = new System.Drawing.Size(780, 604);
            this.cdvPeopleList.TabIndex = 1;
            // 
            // ctrPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.cdvPeopleList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(40);
            this.Name = "ctrPeopleList";
            this.Size = new System.Drawing.Size(879, 690);
            this.Load += new System.EventHandler(this.ctrPeopleList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GlobalClasses.CustomDataGridView cdvPeopleList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWPERSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITPERSONINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWPERSONINFOToolStripMenuItem;
    }
}
