using customDesignControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses.Utility.focus
{
    public class clsSetTextBoxFocus
    {
        public static void ChangeBorderBackColorOnFocusEnter(object sender, EventArgs e)
        {
            if (sender is ModernTextBox tb)
            {
                tb.BackColor = Color.FromArgb(255, 255, 240);
                tb.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public static void ChangeBorderBackColorOnFocusLeave(object sender, EventArgs e)
        {
            if (sender is ModernTextBox tb)
            {
                tb.BackColor = Color.FromArgb(230, 247, 255);
                tb.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
