using System;
using System.Drawing;

namespace grafikprogramm
{
    class VarRectangle : Shape
    {
        private int StartX;

        private int StartY;

        private int EndX;

        private int EndY;


        public VarRectangle(int xPosition, int yPosition,
            int endX, int endY, Color color) : base(color)
        {
            StartX = xPosition;
            StartY = yPosition;
            EndX = endX;
            EndY = endY;
        }

        public override Shape Clone()
        {
            throw new NotImplementedException();
        }

        public override Color GetColor(int x, int y)
        {
            if (x > StartX && x < StartX + EndX && y > StartY && y < StartY + EndY)
            {
                return FillColor;
            }
            return Color.Empty;
        }
    }
}
