using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Square : Figure
    {        
        private int _sideLength;

        private Graphics graphics = Form1.ActiveForm.CreateGraphics();
        public Square(int centerX, int centerY, int sideLength)
        {
            _centerX = centerX;
            _centerY = centerY;
            _sideLength = sideLength;
        }

        public override void DrawBlack()
        {                        
            graphics.DrawRectangle(Pens.Black, CreateSquare());
        }

        public override void HideDrawingBackGround()
        {            
            graphics.DrawRectangle(new Pen(Form1.ActiveForm.BackColor), CreateSquare());
        }

        private Rectangle CreateSquare()
        {
            int halfSide = _sideLength / 2;
            int x = _centerX - halfSide;
            int y = _centerY - halfSide;

            return new Rectangle(x, y, _sideLength, _sideLength);
        }
    }
}
