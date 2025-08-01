using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses.Utility.focus
{
    public class clsSetButtonFocus
    {
        public static void ChangeColorOnFocusEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.FromArgb(100, 180, 250); 
            btn.FlatAppearance.BorderColor = Color.Blue;
            btn.FlatAppearance.BorderSize = 2;
        }
        public static void ChangeColorOnFocusLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.FromArgb(51, 66, 91); 
            btn.FlatAppearance.BorderSize = 0;
        }
    }
}
