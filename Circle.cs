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
        public Circle(int centerX, int centerY, int radius)
        {
            _centerX = centerX;
            _centerY = centerY;
            _radius = radius;
        }

        public override void DrawBlack()
        {
            Form1.ActiveForm.CreateGraphics().DrawEllipse(Pens.Black, CreateCircle());
        }

        public override void HideDrawingBackGround()
        {
            Form1.ActiveForm.CreateGraphics().DrawEllipse(new Pen(Form1.ActiveForm.BackColor), CreateCircle());
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
