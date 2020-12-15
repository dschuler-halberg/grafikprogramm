using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace grafikprogramm
{
    public class Viereck : Shape
    {
       
        private int StartX;

        private int StartY;

        private int Width;

        private int Height;


        public Viereck(int xPosition, int yPosition,
            int width, int height, Color color): base(color)
        {
            StartX = xPosition;
            StartY = yPosition;
            Width = width;
            Height = height;
        }

        public override Shape Clone()
        {
            throw new NotImplementedException();
        }

        public override Color GetColor(int x, int y)
        {
            if (x > StartX && x < StartX + Width && y > StartY && y < StartY + Height)
            {
                return FillColor;
            }
            return Color.Empty;
        }
    }
}
