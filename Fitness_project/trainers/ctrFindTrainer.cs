using CustomMessageBox;
using Fitness_project.Localization;
using Fitness_project.Members.controls;
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
using System.Xml.Linq;

namespace Fitness_project.trainers
{
    public partial class ctrFindTrainer : UserControl
    {
        clsTrainers _trainer;
        string _selectedText;
        string _value;
     
        public event Action<int> onTrainerSelected;
        protected virtual void Trainer_Selected(int trainerId)
        {
            onTrainerSelected?.Invoke(trainerId);
        }
        private void ApplyLocalization()
        {
            btnSearch.Text=Strings.btnSearch;
            gbFilter.Text=Strings.gbFilter;
            lblSearchBy.Text=Strings.lblSearchBy;

        }
        public ctrFindTrainer()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        bool enable = true;
        public bool EnableFilter
        {
            set
            {
                enable = value;
                gbFilter.Enabled = enable;
                cbFilter.SelectedText = "Person Id";
            }
        }
        public void SetFocus()
        {
            txtValue.Focus();
        }
        private void _FindNow()
        {
            int value = 0;
            switch (cbFilter.Text)
            {
                case "Trainer Id":
                    int.TryParse(txtValue.Text.Trim(), out value);
                    ctrTrainerInfo1.LoadTrainer(value);
                    break;
                case "Id":
                    int.TryParse(txtValue.Text.Trim(), out value);
                    ctrTrainerInfo1.LoadTrainerByPersonId(value);
                    break;
                default:
                    ctrTrainerInfo1.LoadTrainer(txtValue.Text);
                    
                    break;
            }
            if (ctrTrainerInfo1.TrainerId <= 0)
            {
                RJMessageBox.Show(Strings.rjNotValidTrainer, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
            Trainer_Selected(ctrTrainerInfo1.TrainerId);               
            
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedText = cbFilter.Text;
            txtValue.Text = string.Empty;
            SetFocus();
        }
        public void LoadTrainer(int trainerId)
        {
            cbFilter.Text = "Trainer Id";
            txtValue.Text = trainerId.ToString();
            _FindNow();
        }
        private void ctrFindTrainer_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 2;
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                RJMessageBox.Show(Strings.RequiredFields,
                Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }
    }
}
