using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Figure
    {
        protected int _centerX;
        protected int _centerY;

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                _centerX++;
            }
        }
    }
}
