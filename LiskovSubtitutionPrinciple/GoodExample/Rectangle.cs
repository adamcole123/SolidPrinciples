using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.GoodExample
{
    internal class Rectangle : Shape
    {
        public void SetHeight(int h) { base.SetHeight(h); }
        public void SetWidth(int w) { base.SetWidth(w); }
    }
}
