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

        public async Task MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                await Task.Delay(60);
                HideDrawingBackGround();
                _centerX++;
            }
        }
    }
}
