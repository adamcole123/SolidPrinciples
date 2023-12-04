using OpenClosedPrinciple.GoodExample.Step2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.BadExample
{
    internal class ScreenPresenter
    {
        public string GetView(bool print)
        {
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            if (print)
            {
                return "Date,Value,Different\n12/12/2020,50,-100";
            }
            return "<html>...</html>";
        }
    }
}
