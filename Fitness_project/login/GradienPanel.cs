using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.login
{
    internal class GradienPanel:Panel
    {
        public Color gradientTop {  get; set; }
        public Color gradientButton { get; set; }

        public GradienPanel()
        {
            this.Resize += GradienPanel1_Resize;
        }

        public void GradienPanel1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(
                this.ClientRectangle,
                this.gradientTop,
                this.gradientButton,
                90F
                );
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.FillRectangle(linear,this.ClientRectangle);
        }
    }
}
