﻿using Fitness_project.Audit;
using Fitness_project.Subscription;
using Fitness_project.users.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.test
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();            
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            ctrAuditScreen audit = new ctrAuditScreen();            
        }
    }
}
