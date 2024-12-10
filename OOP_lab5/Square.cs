using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5
{
    public class Square : Figure
    {
        private int sideLength;

        public Square(int x, int y, int sideLength, Form form) : base(x, y, form)
        {
            this.sideLength = sideLength;
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.DrawRectangle(Pens.Black, centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.DrawRectangle(new Pen(form.BackColor), centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }
    }
}
