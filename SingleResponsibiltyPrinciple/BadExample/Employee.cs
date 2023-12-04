
namespace SingleResponsibiltyPrinciple.BadExample
{
    public class Employee
    {
        //Used by someone that works under the CFO Finance
        public decimal CalculatePay( decimal hours, decimal overtimeHours, string role )
        {
            return RegularHours(hours, role) + overtimeHours * 10;
        }

        // Used by someone that works under the COO Operations
        public string ReportHours (string employeeID)
        {
            IEmployeeEntity employeeEntity = GetEmployeeEntityById(employeeID);
            return $"{employeeID}: {RegularHours(employeeEntity.Hours, employeeEntity.Role)}";
        }

        // Used by someone that works under the CTO Technological
        public bool Save (string employeeId)
        {
            return true;
        }

        #region Extra
        private decimal RegularHours (decimal hours, string role)
        {
            if(role == "Boss")
            {
                return hours * 40;
            } 
            else
            {
                return hours * 10;
            }
        }

        private IEmployeeEntity GetEmployeeEntityById(string employeeID)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
