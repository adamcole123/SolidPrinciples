using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Step3
{
    internal class ScreenPresenter : IPresenter
    {
        public string GetView()
        {
            return "<html>...</html>";
        }
    }
}
