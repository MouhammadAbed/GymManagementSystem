using customCtrDatagridview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatDashboad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();

        }
        private void hideSubMenu()
        {
            userPanel.Visible = false;
            memberPanel.Visible = false;
            trainerspanel.Visible = false;
            CategoryPanel.Visible = false;
            SubscriptionPanel.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if(!SubMenu.Visible)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(userPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(trainerspanel);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            showSubMenu(memberPanel);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            showSubMenu(CategoryPanel);
        }

        private void btnSubscripton_Click(object sender, EventArgs e)
        {
            showSubMenu(SubscriptionPanel);
        }

        private void btnFindSub_Click(object sender, EventArgs e)
        {

        }
        
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            CustomDatagridview cust = new CustomDatagridview();
            cust.BindData(CreateSampleData());  
            mainPanel.Dock= DockStyle.Fill;     
            mainPanel.Controls.Add(cust);
        }

        private DataTable CreateSampleData()
        {
            DataTable table = new DataTable();

            // Add columns
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Subscription", typeof(string));
            table.Columns.Add("JoinDate", typeof(DateTime));
            table.Columns.Add("called", typeof(string));
            table.Columns.Add("Subscription end", typeof(string));
            table.Columns.Add("Join", typeof(DateTime));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("phone", typeof(string));
            // Add rows
            table.Rows.Add(1, "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(2, "Sara Khaled", "Yearly", DateTime.Now.AddMonths(-6), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(3, "Mohammed Noor", "Weekly", DateTime.Now.AddDays(-7), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(4, "Lina Ahmed", "Monthly", DateTime.Now.AddDays(-10), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(1, "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(2, "Sara Khaled", "Yearly", DateTime.Now.AddMonths(-6), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(3, "Mohammed Noor", "Weekly", DateTime.Now.AddDays(-7), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(1, "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(2, "Sara Khaled", "Yearly", DateTime.Now.AddMonths(-6), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(3, "Mohammed Noor", "Weekly", DateTime.Now.AddDays(-7), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(4, "Lina Ahmed", "Monthly", DateTime.Now.AddDays(-10), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(4, "Lina Ahmed", "Monthly", DateTime.Now.AddDays(-10), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(1, "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(2, "Sara Khaled", "Yearly", DateTime.Now.AddMonths(-6), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(3, "Mohammed Noor", "Weekly", DateTime.Now.AddDays(-7), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(4, "Lina Ahmed", "Monthly", DateTime.Now.AddDays(-10), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly"); 
            table.Rows.Add(2, "Sara Khaled", "Yearly", DateTime.Now.AddMonths(-6), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(3, "Mohammed Noor", "Weekly", DateTime.Now.AddDays(-7), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            table.Rows.Add(4, "Lina Ahmed", "Monthly", DateTime.Now.AddDays(-10), "Ali Hassan", "Monthly", DateTime.Now.AddDays(-20), "Ali Hassan", "Monthly");
            return table;
        }
     
    }
}
