using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.login
{
    internal class clstransparentPanel:Panel
    {
        public clstransparentPanel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do not paint background
        }
    }
}
