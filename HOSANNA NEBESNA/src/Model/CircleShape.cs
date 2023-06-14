using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Draw.src.Model
{
    internal class CircleShape : Shape
    {
        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public CircleShape(CircleShape circle) : base(circle)
        {
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }


        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle);
            grfx.DrawEllipse(Pens.Black, Rectangle);
        }








        public override void ToggleTransparent()
        {
            isTransparent = !isTransparent;
        }
    }
}
