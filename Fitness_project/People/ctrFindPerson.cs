using CustomMessageBox;
using Fitness_project.Categories.ShowCategoriesInfo;
using Fitness_project.Localization;
using fitnessDataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.People
{
    public partial class ctrFindPerson : UserControl
    {
        string _selectedText;
        string _value;
        bool enable = true;
        int _PersonId = -1;

        public event Action<int> onPersonSelected;
        protected virtual void Person_Selected(int personId)
        {
            onPersonSelected?.Invoke(personId);
        }
        public bool EnableFilter
        {
            set
            {
                enable = value;
                gbFilter.Enabled = enable;
                cbFilter.SelectedText = "Person Id";
            }
        }
        public int exposePersonId
        {
            get { return _PersonId; }
        }
        public clsPeople PersonInfo
        {
            get { return ctrPersonInfo22.exposePersonInfo; }
        }
        private void ApplyLocalization()
        {
            lblFind.Text = Strings.lblFind;         
            btnSearch.Text = Strings.btnSearch;
            btnAddPeson.Text = Strings.btnAddPeson;
            gbFilter.Text= Strings.gbFilter;
            cbFilter.Items[0] = Strings.FilterById;
            cbFilter.Items[1] = Strings.FilterByName;
        }
        public ctrFindPerson()
        {
            InitializeComponent();
            ApplyLocalization();
        }
        public void SetFocus()
        {
            txtValue.Focus();
        }
        private void _FindNow()
        {
            int value = 0;

            _value = txtValue.Text;
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    int.TryParse(txtValue.Text.Trim(), out value);
                    _value = txtValue.Text;
                    ctrPersonInfo22.LoadPersonInfo(value);
                    _PersonId = ctrPersonInfo22.exposePersonId;
                    break;

                default:
                    _value = txtValue.Text;
                    ctrPersonInfo22.LoadPersonInfo(txtValue.Text);
                    _PersonId = ctrPersonInfo22.exposePersonId;
                    break;
            }
            if (_PersonId <= 0)
            {
                RJMessageBox.Show(Strings.InvalidPersonInput, Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (onPersonSelected != null)
            {
                onPersonSelected(_PersonId);                
            }
        }
        public void LoadPerson(int id)
        {
            cbFilter.SelectedIndex = 0;
            txtValue.Text=id.ToString();
            enable = false;
            _FindNow();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedText = cbFilter.Text;
            SetFocus();
            txtValue.Text = "";
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                RJMessageBox.Show("Please fill in all required fields before searching.",
                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }
        private void ctrFindPerson_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            SetFocus();
        }
        private void modernDesignButton1_Click(object sender, EventArgs e)
        {
            ctrAddUpdatePerson u =new ctrAddUpdatePerson(this);
            u.PersonDataBack += AddPerson_DataBack;
            Control parent = this.Parent;
            if(parent!= null)
            {
                parent.Controls.Add(u);
                this.Hide();        
            }
        }
        private void AddPerson_DataBack(object sender,clsPeople person)
        {
           LoadPerson(person.PersonID);            
        }
    }
}
