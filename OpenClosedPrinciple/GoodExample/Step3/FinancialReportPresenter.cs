using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Step3
{
    internal class FinancialReportPresenter
    {
        private IPresenter _presenter;
        public FinancialReportPresenter(IPresenter presenter) 
        {
            _presenter = presenter;
        }
        public void Execute()
        {
            _presenter.GetView();
        }
    }

    internal class WebPage
    {
        FinancialReportPresenter screenFinancialReporter = new FinancialReportPresenter(new ScreenPresenter());
        FinancialReportPresenter printFinancialReporter = new FinancialReportPresenter(new PrintPresenter());
        FinancialReportPresenter radioFinancialReporter = new FinancialReportPresenter(new RadioPresenter());
        public WebPage()
        {
            screenFinancialReporter.Execute();
            printFinancialReporter.Execute();
            radioFinancialReporter.Execute();
        }
    }
}
