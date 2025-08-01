using CustomMessageBox;
using Fitness_project.Localization;
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

namespace Fitness_project.Members.controls
{
    public partial class ctrFindMember : UserControl
    {
        string _selectedText;
        string _value;

        public event Action<int> onMemberSelected;
        protected virtual void Member_Selected(int MemberId)
        {
            onMemberSelected?.Invoke(MemberId);
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
        public ctrFindMember()
        {
            InitializeComponent();
            lblSearchBy.Text = Strings.lblSearchBy;
            btnSearch.Text=Strings.btnSearch;
            cbFilter.Text=Strings.gbFilter;
        }
        public void SetFocus()
        {
            txtValue.Focus();
        }
        private void _FindNow()
        {
            int value = 0;
            _value= txtValue.Text;
            switch (cbFilter.Text)
            {
                case "Id":
                    int.TryParse(txtValue.Text.Trim(), out value);
                    ctrMemberInfo1.LoadMemberByPersonid(value);
                    break;
                default:
                    ctrMemberInfo1.LoadMemberByName(txtValue.Text);
                    break;
            }
            if(ctrMemberInfo1.MemberId<=0)
            {
                RJMessageBox.Show("Member not found. Please insert a valid value", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            
            Member_Selected(ctrMemberInfo1.MemberId);
            
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedText= cbFilter.Text;
            txtValue.Text = string.Empty;
            SetFocus();
        }
        private void ctrFindMember_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 1;
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text) || string.IsNullOrEmpty(txtValue.Text))
            {
                RJMessageBox.Show(Strings.rjRquiredTextBox,
                Strings.InvalidInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }
    }
}
