using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.GoodExample
{
    internal class Shape
    {
        private int height;
        private int width;

        public void SetHeight(int newHeight) {  height = newHeight; }
        public void SetWidth(int newWidth) {  width = newWidth; }
        public int Area() { return height * width; }
    }
}
