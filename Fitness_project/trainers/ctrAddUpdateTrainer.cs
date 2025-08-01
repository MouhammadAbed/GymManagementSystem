using CustomMessageBox;
using Fitness_project.Categories.ShowCategoriesInfo;
using Fitness_project.GlobalClasses.Utility.focus;
using Fitness_project.GlobalClasses.UtilityCustomControls;
using Fitness_project.Localization;
using Fitness_project.People;
using Fitness_project.users.controls;
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
    public partial class ctrAddUpdateTrainer : UserControl
    {
        enum enMode { enUpdate=1,enAdd=2}
        enMode _Mode = enMode.enUpdate;

        clsTrainers _trainer;
        int _trainerId;
        clsTrainerCategoryAssignment _assignment;
        List<string> _trainerCategories;
        bool isPersonTrainer = false;
        UserControl _currentUserControl = null;
        public ctrAddUpdateTrainer(UserControl currentUserControl=null)
        {
            InitializeComponent();
            ApplyLocalization();
            _Mode = enMode.enAdd;
            _loadCategoriesToComboBox();
            this._currentUserControl = currentUserControl;
        }
        public ctrAddUpdateTrainer(int trainerId,UserControl currentUserControl = null)
        {
            InitializeComponent();
            ApplyLocalization();
            _Mode = enMode.enUpdate;
            _loadCategoriesToComboBox();
            this._currentUserControl = currentUserControl;
            _trainerId = trainerId;
        }

        private void ApplyLocalization()
        {
            tbPersonInfo.Text = Strings.tbPersonInfo;
            tbTrainerInfo.Text = Strings.tbTrainerInfo; 
            btnSave.Text = Strings.btnSave;
            btnNext.Text = Strings.btnNext;
            lblPersonId.Text = Strings.lblPersonId;
            lblFullName.Text=Strings.lblFullName;
            lblSalary.Text = Strings.lblSalary;
            lblSelectCategory.Text = Strings.lblSelectCategory;
            lblTrainerCategories.Text = Strings.lblTrainerCategories;

        }
        private void _loadCategoriesToComboBox()
        {
            DataTable dtCategories = clsCategories.getAllCategories();
            if(dtCategories.Rows.Count>0 )
            {
                foreach( DataRow row in dtCategories.Rows )
                {
                    cmbAllCategories.Items.Add(row["Category Name"]); 
                }
                cmbAllCategories.SelectedIndex=0;
            }

        }
        private void _loadTrainerInfo()
        {            
            txtId.Texts = ctrFindPerson2.exposePersonId.ToString();
            txtFullName.Texts = ctrFindPerson2.PersonInfo.fullName;
            _trainerCategories = clsTrainerCategoryAssignment.GetTrainerCategoriesAssignment(ctrFindPerson2.exposePersonId);
            if (_trainerCategories.Count>0)
            {
                txtTrainerCategories.Texts=string.Join(",",_trainerCategories);
            }
            else
            {
                txtTrainerCategories.Texts = "Trainer not assigned to any category yet";
            }            
        }     
        private void ctrUpdateAddUserTab_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Enabled=false;
            btnNext.Enabled=false;
            btnSave.Enabled=false;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void _saveTrainerInfo()
        {
            _assignment = new clsTrainerCategoryAssignment();
            _assignment.PersonID = ctrFindPerson2.exposePersonId;
            if (isPersonTrainer)
            {
                _trainer = clsTrainers.FindTrainerByPersonid(ctrFindPerson2.exposePersonId);
                if (_trainer != null)
                {
                    _assignment.TrainerId = _trainer.id;
                }
            }
            _assignment.Salary = Convert.ToDecimal(txtSalary.Texts);
            _assignment.CategoryId = clsCategories.FindCategory(cmbAllCategories.Text).id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            isPersonTrainer=clsTrainers.IsPersonTrainer(ctrFindPerson2.exposePersonId);
            if(isPersonTrainer)
            {
                //check if trainer subscribe to all the categories
                if (_trainerCategories.Count == clsCategories.GetCategoriesCount())
                {
                    RJMessageBox.Show("Trainer already assign to all categories.", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_trainerCategories.Contains(cmbAllCategories.Text))
                {
                    RJMessageBox.Show($"Trainer alreay assign to the Category {cmbAllCategories.Text}", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }            
            _saveTrainerInfo();
            if (_assignment.AssignNewCategoryToTrainer()>0)
            {
                if (_currentUserControl == null)
                {
                    RJMessageBox.Show($"Trainer assign to a new category '{cmbAllCategories.Text}'", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.enUpdate;
                    _loadTrainerInfo();
                }
                else
                {
                    _ReturnToTrainersList();
                }

            }
        }
        private void ctrFindPerson2_onPersonSelected(int obj)
        {
            if (obj > 0)
            {
                tabControl1.TabPages[1].Enabled = true;
                btnNext.Enabled = true;
                btnSave.Enabled = true;
                _loadTrainerInfo();               
            }
        }     
        private void cmbAllCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalary.Texts = string.Empty;
        }        
        private void _ReturnToTrainersList()
        {
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                ctrTrainersList trainerList = new ctrTrainersList();
                trainerList.Dock = DockStyle.Fill;
                parent.Controls.Add(trainerList);
            }
        }
        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalary.Texts))
            {
                e.Cancel =true;
                errorProvider1.SetError(txtSalary, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSalary, null);
            }
        }
        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            clsSetTextBoxFocus.ChangeBorderBackColorOnFocusEnter(sender, e);
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            clsSetTextBoxFocus.ChangeBorderBackColorOnFocusLeave(sender, e);
        }
    }
}

