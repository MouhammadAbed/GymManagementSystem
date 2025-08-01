using Fitness_project.Categories.ShowCategoriesInfo;
using Fitness_project.Subscription;
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
    public partial class ctrPeopleList : UserControl
    {
        DataTable dtPeopleLIst = new DataTable();
        public ctrPeopleList()
        {
            InitializeComponent();
        }
        private void ctrPeopleList_Load(object sender, EventArgs e)
        {
            dtPeopleLIst = clsPeople.GetAllPeople();
            cdvPeopleList.BindData(dtPeopleLIst);
            cdvPeopleList.InnerGrid.Columns[0].Width = 130;
            cdvPeopleList.InnerGrid.Columns[1].Width = 130;
            cdvPeopleList.InnerGrid.Columns[2].Width = 130;
            cdvPeopleList.InnerGrid.Columns[3].Width = 130;
            cdvPeopleList.InnerGrid.Columns[4].Width = 130;
            cdvPeopleList.InnerGrid.Columns[5].Width = 130;

            var row = dtPeopleLIst.Rows[0];
            for (int i = 0; i < dtPeopleLIst.Rows.Count; i++)
            {
                cdvPeopleList.InnerGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        private void aDDNEWPERSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrAddUpdatePerson addNewPerson = new ctrAddUpdatePerson(this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                addNewPerson.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(addNewPerson);
            }
        }
        private void sHOWPERSONINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personid = cdvPeopleList.GetSelectedRowFirstColumnValue();
            if (personid < 1) 
            {
                return;
            }
            ctrFindPerson findPerson = new ctrFindPerson();
            findPerson.LoadPerson(personid);
            findPerson.Enabled = false;
        }

        private void eDITPERSONINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = cdvPeopleList.GetSelectedRowFirstColumnValue();
            if (personId < 1)
            {
                return;
            }
            ctrAddUpdatePerson updatePerson = new ctrAddUpdatePerson(personId, this);
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                updatePerson.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(updatePerson);
                ctrPeopleList_Load(null, null);
            }
        }
    }
}
