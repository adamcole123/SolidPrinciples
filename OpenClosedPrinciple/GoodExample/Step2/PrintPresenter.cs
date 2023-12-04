using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Step2
{
    internal class PrintPresenter : IPresenter
    {
        public string GetView()
        {
            return "Date,Value,Difference\n12/2/2020,(-52.00),0";
        }
    }
}
