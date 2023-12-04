using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Step1
{
    internal class FinancialReportPresenter
    {
        ScreenPresenter screenPresenter = new ScreenPresenter();
        public void Execute()
        {
            screenPresenter.GetView();
        }
    }
}
