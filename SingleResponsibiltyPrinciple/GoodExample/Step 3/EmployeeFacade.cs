using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibiltyPrinciple.GoodExample.Step_3
{
    public class Employee
    {
        private EmployeeData employeeData { get; set; }
        public decimal CalculatePay () { 
            employeeData.Pay = PayCalculator.CalculatePay(); 
            return employeeData.Pay;
        }
        public string ReportHours () {
            employeeData.Report = HourReporter.ReportHours(); 
            return employeeData.Report;
        }
        public bool SaveEmployee () {
            EmployeeRepository.Save(employeeData);
            return true;
        }
    }
}
