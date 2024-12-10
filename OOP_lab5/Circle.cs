using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5
{
    public class Circle : Figure
    {
        private int radius;

        public Circle(int x, int y, int radius, Form form) : base(x, y, form)
        {
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.DrawEllipse(new Pen(form.BackColor), centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }
        }
    }
}
