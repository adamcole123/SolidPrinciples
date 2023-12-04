using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.GoodExample
{
    internal class User
    {
        Shape square = new Square();
        Shape rectangle = new Rectangle();

        public void SetShapeArea(int height, int width)
        {
            square.SetWidth(width);
            square.SetHeight(height);

            rectangle.SetWidth(width);
            rectangle.SetHeight(height);
        }

        public int GetSquareArea()
        {
            return square.Area();
        }

        public int GetRectangleArea()
        {
            return rectangle.Area();
        }
    }
}
