using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses
{
    public class CircularPictureBox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using(GraphicsPath obj=new GraphicsPath())
            {
                obj.AddEllipse(0,0,this.Width-1,this.Height-1);
                this.Region = new Region(obj);

                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Create yellow border with desired thickness
                int borderThickness = 2;
                using (Pen navyPen = new Pen(Color.Navy, borderThickness))
                {
                    pe.Graphics.DrawEllipse(navyPen,
                        borderThickness / 2,
                        borderThickness / 2,
                        this.Width - borderThickness,
                        this.Height - borderThickness);
                }
            }
        }
        
    }
}
