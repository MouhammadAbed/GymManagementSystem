using Fitness_project.Localization;
using FitnessBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.trainers
{
    public partial class ctrShowTrainerInfo : UserControl
    {
        int _assignId;
        UserControl _prevUserControl;
        clsTrainerCategoryAssignment _categoryAssignment;

        private void ApplyLocalization()
        {
            btnClose.Text = Strings.btnClose;
            lblShowTrainerInfo.Text= Strings.lblShowTrainerInfo;
        }
        public ctrShowTrainerInfo(int assignId,UserControl prevControl)
        {
            InitializeComponent();
            _assignId = assignId;
            _prevUserControl = prevControl;
        }
        private void ctrShowTrainerInfo_Load(object sender, EventArgs e)
        {

            _categoryAssignment = clsTrainerCategoryAssignment.findAssignment(_assignId);
            ctrTrainerInfo1.LoadTrainer(_categoryAssignment.TrainerId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent is Panel mainPanel)
            {
                mainPanel.Controls.Clear();
                _prevUserControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(_prevUserControl);
            }
            else if (this.Parent is Control p && p.Parent is Panel panel)
            {
                panel.Controls.Clear();
                _prevUserControl.Dock = DockStyle.Fill;
                panel.Controls.Add(_prevUserControl);
            }
        }
    }
}
