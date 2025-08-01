using CustomMessageBox;
using Fitness_project.Audit;
using Fitness_project.Categories.controls;
using Fitness_project.Categories.ShowCategoriesInfo;
using Fitness_project.GlobalClasses;
using Fitness_project.GlobalClasses.Utility;
using Fitness_project.Localization;
using Fitness_project.login;
using Fitness_project.Members.controls;
using Fitness_project.People;
using Fitness_project.personControls;
using Fitness_project.Subscription;
using Fitness_project.trainers;
using Fitness_project.users.controls;
using FitnessBusinessLayer;
using FitnessDataLayer;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fitness_project.Dashboard
{
    public partial class MainDashboard : Form
    {
        Form loginfrm;
        UserControl currentControl;
        UserControl previousControl;
        private bool _isLanguageInitializing = false;
        private bool _RefreshFlag = false;
        private void ApplyLocalization()
        {
            btnUsers.Text = Strings.btnUsers;
            btnFindUser.Text = Strings.buttonFind;
            btnUsersList.Text=Strings.btnUsersList;
            btnAddUser.Text = Strings.buttonAdd;
            btnMembers.Text=Strings.btnMembers;
            btnAddMember.Text=Strings.btnAdd;
            btnFindMember.Text = Strings.buttonFind;
            btnMemberList.Text=Strings.btnMemberList;
            btnTrainers.Text=Strings.btnTrainers;
            btnAddTrainer.Text=Strings.btnAdd;
            btnTrainerList.Text=Strings.btnTrainerList;
            btnFindTrainer.Text = Strings.buttonFind;
            btnCategories.Text=Strings.btnCategories;
            btnAddCat.Text = Strings.btnAdd;
            btnFindCat.Text = Strings.buttonFind;
            btnCatLIst.Text=Strings.btnCatLIst;
            btnSubscripton.Text=Strings.btnSubscripton;
            btnAddSub.Text = Strings.btnAdd;
            btnFindSub.Text = Strings.buttonFind;
            btnActiveSub.Text= Strings.btnActiveSub;
            btnAudit.Text=Strings.btnAudit;
            btnExist.Text = Strings.btnExist;
        }
        public MainDashboard(Form frm)
        {
            InitializeComponent();
            ApplyLocalization();
            loginfrm = frm;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            lblUserName.Text = clsGlobalUser.CurrentUser.userName;
            hideSubMenu();
            List<DailyExpiredDTO> dailyExpiredSubs = clsApplication.findTopApplicants();
            LoadLastSubscribers(dailyExpiredSubs);           
        }
        private void hideSubMenu()
        {
            userPanel.Visible = false;
            memberPanel.Visible = false;
            trainerspanel.Visible = false;
            CategoryPanel.Visible = false;
            SubscriptionPanel.Visible = false;
            peoplePanel.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (!SubMenu.Visible)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions,clsPermissions.enPermissions.enUserTabs))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabUsers);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                showSubMenu(userPanel);
        }
        private void btnTrainers_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions, clsPermissions.enPermissions.enTrainersTab))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabTrainers);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showSubMenu(trainerspanel);
        }
        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions, clsPermissions.enPermissions.enMembersTabs))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabMembers);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showSubMenu(memberPanel);
        }
        private void btnSubscripton_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions, clsPermissions.enPermissions.enSubscriptionTab))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabSubsc);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showSubMenu(SubscriptionPanel);
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
            loginfrm.Close();       
        }
        private void MainDashboard_Resize(object sender, EventArgs e)
        {
            clsResizeMoveFom.SetFormPosition(this);
        }
        private void MainDashboard_Move(object sender, EventArgs e)
        {
            clsResizeMoveFom.SetFormPosition(this);
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions, clsPermissions.enPermissions.enCategoriesTab))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabCategory);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showSubMenu(CategoryPanel);
        }
        private void btnMemberList_Click(object sender, EventArgs e)
        {
            ctrMemberList uc = new ctrMemberList();
            LoadUserControl(uc);
        }
        private void LoadUserControl(UserControl uc)
        {
            if (currentControl != null)
                previousControl = currentControl;

            mainPanel.Controls.Clear();

            pbGymImage.Visible = false; // Hide default image when loading user control

            currentControl = uc;
            currentControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(currentControl);
        }
        public void LoadLastSubscribers(List<DailyExpiredDTO> applicants)
        {

            sidePanel.AutoScroll = true;
            sidePanel.VerticalScroll.Visible = true;
            sidePanel.HorizontalScroll.Visible = false;
            sidePanel.Controls.Clear(); 
            int topMargin = 10;

            // 🏷️ Add title label at the top
            Label lblTitle = new Label
            {
                Text = "📅 Today’s Expired Subscriptions",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, topMargin),
                AutoSize = true
            };

            sidePanel.Controls.Add(lblTitle);
            topMargin += lblTitle.Height + 10;

            foreach (var applicant in applicants)
            {
                MaterialCard card = new MaterialCard
                {
                    Width = sidePanel.Width - 20,
                    Height = 100,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    Location = new Point(10, topMargin)
                };

                // Name Label
                Label lblName = new Label
                {
                    Text = $"👤 {applicant.Name}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                // Category Label
                Label lblCategory = new Label
                {
                    Text = $"🏷️ Category: {applicant.CategoryName}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                // Date Label
                Label lblDate = new Label
                {
                    Text = $"📅 Date: {applicant.SubscriptionEndDate}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                // Add labels to card
                card.Controls.Add(lblName);
                card.Controls.Add(lblCategory);
                card.Controls.Add(lblDate);

                // Add card to panel
                sidePanel.Controls.Add(card);

                topMargin += card.Height + 10; 
            }
        }
        private void btnUsersList_Click(object sender, EventArgs e)
        {
            ctrUsersList uc = new ctrUsersList();
            LoadUserControl(uc);
        }
        private void btnTrainerList_Click(object sender, EventArgs e)
        {
            ctrTrainersList uc = new ctrTrainersList();
            LoadUserControl(uc);
        }
        private void btnFindUser_Click(object sender, EventArgs e)
        {           
            ctrProfileTab uc = new ctrProfileTab();
            uc.SwitchToProfileTab(0);         
            LoadUserControl(uc);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ctrAddUser u = new ctrAddUser();
           LoadUserControl(u);
        }
        private void btnFindTrainer_Click(object sender, EventArgs e)
        {           
            ctrProfileTab uc = new ctrProfileTab();
            uc.SwitchToProfileTab(2);
            LoadUserControl(uc);
        }
        private void btnFindMember_Click(object sender, EventArgs e)
        {
            ctrProfileTab uc = new ctrProfileTab();
            uc.SwitchToProfileTab(1);
            LoadUserControl(uc);
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            ctrAddUpdateMember uc = new ctrAddUpdateMember();
            LoadUserControl (uc);
        }
        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            ctrAddUpdateTrainer uc = new ctrAddUpdateTrainer();
            LoadUserControl((uc));
        }        
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(100, 100, 150); // Pressed background
                btn.ForeColor = Color.White; // Pressed text color
            }
        }
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(76, 75, 105); // Original background
                btn.ForeColor = Color.Silver; // Original text color
            }
        }
        private void btnFindCat_Click(object sender, EventArgs e)
        {
            ctrFindCategory uc = new ctrFindCategory();
            LoadUserControl(uc);
        }
        private void btnCatLIst_Click_1(object sender, EventArgs e)
        {
            ctrCategoriesList uc = new ctrCategoriesList();
            LoadUserControl(uc);
        }
        private void btnAddCat_Click_1(object sender, EventArgs e)
        {
            ctrAddUpdateCategories uc = new ctrAddUpdateCategories();
            LoadUserControl(uc);
        }
        private void btnActiveSub_Click(object sender, EventArgs e)
        {
            ctrGetAllSubscriptions uc = new ctrGetAllSubscriptions();
            LoadUserControl(uc);
        }
        private void btnAddSub_Click(object sender, EventArgs e)
        {
            ctrAddNewSubscription uc = new ctrAddNewSubscription();
            LoadUserControl(uc);
        }
        private void btnFindSub_Click(object sender, EventArgs e)
        {
            ctrFindSubscription uc = new ctrFindSubscription();
            LoadUserControl (uc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!clsPermissions.CheckAccessRights(clsGlobalUser.CurrentUser.Permissions, clsPermissions.enPermissions.enAuditTab))
            {
                string message = string.Format(Strings.rjMessageDenied, Strings.TabAudit);
                RJMessageBox.Show(message, Strings.deniedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ctrAuditScreen uc = new ctrAuditScreen();
            LoadUserControl(uc);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.CornflowerBlue;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Transparent;
        }
        private void loadLanguage(string langCode)
        {
            string selectedLanguage = cbLanguageSwitcher.SelectedItem.ToString();
            
            if (selectedLanguage == clsGlobalUser.currentLanguage)
            {
                _RefreshFlag = false;
                return;
            }
            _RefreshFlag=true;
            if (langCode == "Arabic")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
                clsGlobalUser.currentLanguage = selectedLanguage;
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
            else // English
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                clsGlobalUser.currentLanguage = selectedLanguage;
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
            }
        }
        private void cbLanguageSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLanguageInitializing) return;
            string selectedLanguage = cbLanguageSwitcher.SelectedItem.ToString();

            if (selectedLanguage == "Arabic")
                loadLanguage("Arabic");
            else
                loadLanguage("English");
            if (!_RefreshFlag)
            {
                return;
            }
            this.Hide();
            MainDashboard newForm = new MainDashboard(loginfrm);
            newForm.Show();
            this.Close();

        }
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            _isLanguageInitializing = true;
            cbLanguageSwitcher.SelectedIndex = (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "ar") ? 0 : 1;

            _isLanguageInitializing = false;

        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            showSubMenu(peoplePanel);
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            ctrFindPerson uc = new ctrFindPerson();
            LoadUserControl(uc);
        }
        private void btnPeopleLIst_Click(object sender, EventArgs e)
        {
            ctrPeopleList uc = new ctrPeopleList();
            LoadUserControl(uc);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ctrAddUpdatePerson uc = new ctrAddUpdatePerson(currentControl);
            LoadUserControl(uc);
        }
    }
}
