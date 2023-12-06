using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Rhomb : Figure
    {
        protected int _horDiagLen;
        protected int _vertDiagLen;
        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
        {
            _centerX = centerX;
            _centerY = centerY;            
            _horDiagLen = horDiagLen;
            _vertDiagLen = vertDiagLen;
        }

        public override void DrawBlack()
        {            
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, CreateRhomb());
        }

        public override void HideDrawingBackGround()
        {            
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), CreateRhomb());
        }

        private Point[] CreateRhomb()
        {
            int halfHorizontal = _horDiagLen / 2;
            int halfVertical = _vertDiagLen / 2;

            return new Point[]
            {
            new Point(_centerX, _centerY - halfVertical),
            new Point(_centerX + halfHorizontal, _centerY),
            new Point(_centerX, _centerY + halfVertical),
            new Point(_centerX - halfHorizontal, _centerY)
            };
        }
    }
}
