using CustomMessageBox;
using Fitness_project.Dashboard;
using Fitness_project.GlobalClasses;
using Fitness_project.Localization;
using Fitness_project.Properties;
using FitnessBusinessLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.login
{
    public partial class loginform : Form
    {      
        public loginform()
        {
            InitializeComponent();
        }
        private void modernDesignButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsUser.isUserExistByUserNameAndPassword(txtUserName.Texts, clsUtil.ComputedHash(txtPassword.Texts)))
            {
                clsGlobalUser.CurrentUser = clsUser.FindUser(txtUserName.Texts);
                txtPassword.Texts = "";
                txtUserName.Texts = "";
                MainDashboard mainDashboard = new MainDashboard(this);  
                mainDashboard.Show();
                this.Hide();
            }
            else
            {               
                RJMessageBox.Show( "Wrong username/password. Please try again.","Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loginform_Resize(object sender, EventArgs e)
        {
            clsResizeMoveFom.SetFormPosition(this);
        }
        private void loginform_Move(object sender, EventArgs e)
        {
            clsResizeMoveFom.SetFormPosition(this);
        }
        private void loginform_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LogoPath) &&
                File.Exists(Properties.Settings.Default.LogoPath))
            {
                pictureBox1.Image = Image.FromFile(Properties.Settings.Default.LogoPath);
            }
            string UserName = "";
            string Password = "";
            if (clsGlobalUser.GetSortedCredentialFromWindowRegistry(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Your Business Logo";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                    // Optional: save path to settings so it loads again later
                    Properties.Settings.Default.LogoPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
