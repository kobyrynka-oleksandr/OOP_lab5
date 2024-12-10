using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5
{
    public class Triangle : Figure
    {
        private int sideLength;

        public Triangle(int x, int y, int sideLength, Form form) : base(x, y, form)
        {
            this.sideLength = sideLength;
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                Point[] points = new Point[]
                {
                new Point(centerX, centerY - sideLength / 2),
                new Point(centerX - sideLength / 2, centerY + (int)(sideLength * Math.Sqrt(3) / 4)),
                new Point(centerX + sideLength / 2, centerY + (int)(sideLength * Math.Sqrt(3) / 4)),
                };
                g.DrawPolygon(Pens.Black, points);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                Point[] points = new Point[]
                {
                new Point(centerX, centerY - sideLength / 2),
                new Point(centerX - sideLength / 2, centerY + (int)(sideLength * Math.Sqrt(3) / 4)),
                new Point(centerX + sideLength / 2, centerY + (int)(sideLength * Math.Sqrt(3) / 4)),
                };
                g.DrawPolygon(new Pen(form.BackColor), points);
            }
        }
    }
}
