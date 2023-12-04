using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.BadExample
{
    internal class Square : Rectangle
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
