using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.GoodExample
{
    internal class Square : Shape
    {
        public void SetHeight(int newHeight)
        {
            base.SetHeight(newHeight);
            base.SetWidth(newHeight);
        }

        public void SetWidth(int newWidth)
        {
            base.SetWidth(newWidth);
            base.SetHeight(newWidth);
        }
    }
}
