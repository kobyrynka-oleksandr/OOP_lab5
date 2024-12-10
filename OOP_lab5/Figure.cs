using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        protected Form form;

        public Figure(int x, int y, Form form)
        {
            centerX = x;
            centerY = y;
            this.form = form;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 60; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                centerX += 10;
            }
        }
    }
}
