using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibiltyPrinciple.GoodExample.Step_2;

namespace SingleResponsibiltyPrinciple.GoodExample.Step_2
{
    public class EmployeeFacade
    {
        public decimal CalculatePay { get => PayCalculator.CalculatePay(); }
        public string ReportHours { get => HourReporter.ReportHours(); }
        public bool SaveEmployee { get => EmployeeSaver.SaveEmployee(); }
    }
}
