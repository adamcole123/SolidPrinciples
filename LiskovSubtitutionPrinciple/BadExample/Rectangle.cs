using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.BadExample
{
    public class Rectangle
    {
        private int height;
        private int width;
        public void SetHeight(int h) { height = h; }
        public void SetWidth(int w) { width = w; }
        public int Area() { return height*width; }
    }
}
