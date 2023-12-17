using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Circle : Figure
    {
        private int _radius;

        private Graphics graphics = Form1.ActiveForm.CreateGraphics();
        public Circle(int centerX, int centerY, int radius)
        {
            _centerX = centerX;
            _centerY = centerY;
            _radius = radius;
        }

        public override void DrawBlack()
        {                        
            graphics.DrawEllipse(Pens.Black, CreateCircle());
        }

        public override void HideDrawingBackGround()
        {                        
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), CreateCircle());
        }
        
        private Rectangle CreateCircle()
        {
            int x = _centerX - _radius;
            int y = _centerY - _radius;
            int diameter = _radius * 2;

            return new Rectangle(x, y, diameter, diameter);
        }
    }    
}
