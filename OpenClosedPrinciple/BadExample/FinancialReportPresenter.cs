namespace OpenClosedPrinciple.BadExample
{
    public class FinancialReportPresenter
    {
        ScreenPresenter screenPresenter = new ScreenPresenter();
        public void Execute()
        {
            screenPresenter.GetView();
        }
    }
}
