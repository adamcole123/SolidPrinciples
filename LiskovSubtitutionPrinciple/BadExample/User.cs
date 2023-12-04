using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.BadExample
{
    internal class User
    {
        Rectangle Shape;
        public User(Rectangle rectangle)
        {
            Shape = rectangle;
        }

        public void SetShapeArea(int height, int width)
        {
            Shape.SetWidth(width);
            Shape.SetHeight(height);
        }

        public int GetShapeArea()
        {
            return Shape.Area();
        }

        // But isn't a square a rectangle?
        // Things that represent something do not share the relationships of that which they represent
        // e.g. Lawyers representing individuals getting divorced
    }
}
