using CustomMessageBox;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Localization;
using Fitness_project.People;
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

namespace Fitness_project.Categories.ShowCategoriesInfo
{
    public partial class ctrTrainerInfo : UserControl
    {
        clsTrainers _trainer=new clsTrainers();
        int _trainerId = -1;
        public int TrainerId
        {
            get { return _trainerId; }
        }
        private void ApplyLocalization()
        {
            lblTrains.Text = Strings.lblTrains;
        }
        public ctrTrainerInfo()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        private void _ResetDefaultSettings()
        {
            ctrPersonInfo22.ResetDefaultSettinghs();
            txtTrains.Text = "?????";
            _trainerId = -1;
        }
        private void _FillUserInfo()
        {
            ctrPersonInfo22.LoadPersonInfo(_trainer.PersonID, _trainer.FirstName, _trainer.LastName, _trainer.Phone, _trainer.GenderText);
            _trainerId = _trainer.id;
            List<string> _trainerCategories = clsTrainerCategoryAssignment.GetTrainerCategoriesAssignment(_trainer.PersonID);
            if (_trainerCategories.Count > 0)
            {
                txtTrains.Text = string.Join(",", _trainerCategories);
            }
            else
            {
                txtTrains.Text = Strings.rjTrainerNotAssignToCategory;
            }
        }
        public void LoadTrainer(int TrainerId)
        {
            _trainer = clsTrainers.FindTrainer(TrainerId);
            if (_trainer != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();            
        }
        public void LoadTrainerByPersonId(int PersonId)
        {
            _trainer = clsTrainers.FindTrainerByPersonid(PersonId);
            if (_trainer != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();
        }
        public void LoadTrainer(string fullName)
        {
            clsNamePart nameParts=clsNamePart.ParseFullName(fullName);
            if (nameParts == null)
            {
                RJMessageBox.Show(Strings.rjNotValidInput, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _trainer = clsTrainers.FindTrainer(nameParts.firstName,nameParts.secondName,nameParts.lastName);
            if (_trainer != null)
            {
                _FillUserInfo();
                return;
            }
            _ResetDefaultSettings();
        }
        
    }
}
