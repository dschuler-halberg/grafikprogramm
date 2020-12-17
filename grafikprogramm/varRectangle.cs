using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace grafikprogramm
{
    public class VarRectangle : Shape
    {
        private Point P1, P2, P3, P4;
        public VarRectangle(Point p1, Point p2, Point p3, Point p4, Color Color) : base(Color)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }

        public override Shape Clone()
        {
            throw new NotImplementedException();
        }

        public override Color GetColor(int x, int y)
        {
            bool rightToP1P2 = Triangle.IsRightToLine(P1, P2, x, y);
            bool rightToP2P3 = Triangle.IsRightToLine(P2, P3, x, y);
            bool rightToP3P4 = Triangle.IsRightToLine(P3, P4, x, y);
            bool rightToP4P1 = Triangle.IsRightToLine(P4, P1, x, y);
            if (rightToP1P2 && rightToP2P3 && rightToP3P4 && rightToP4P1)
            {
                return FillColor;
            }
            return Color.Empty;
        }

    }


}
