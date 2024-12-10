using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5
{
    public class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;

        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen, Form form) : base(x, y, form)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                Point[] points = new Point[]
                {
                new Point(centerX, centerY - vertDiagLen / 2),
                new Point(centerX + horDiagLen / 2, centerY),
                new Point(centerX, centerY + vertDiagLen / 2),
                new Point(centerX - horDiagLen / 2, centerY),
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
                new Point(centerX, centerY - vertDiagLen / 2),
                new Point(centerX + horDiagLen / 2, centerY),
                new Point(centerX, centerY + vertDiagLen / 2),
                new Point(centerX - horDiagLen / 2, centerY),
                };
                g.DrawPolygon(new Pen(form.BackColor), points);
            }
        }
    }
}
