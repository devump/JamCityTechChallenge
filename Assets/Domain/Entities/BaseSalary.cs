using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class BaseSalary
    {
        private EmployeePosition employeePosition;
        private Dictionary<EmployeeSeniority, float> salariesBySeniority;

        public BaseSalary(EmployeePosition position, Dictionary<EmployeeSeniority, float> salaries)
        {
            employeePosition = position;
            salariesBySeniority = salaries;
        }

        public bool CheckPosition(string position)
        {
            return employeePosition.Equals(new EmployeePosition(position));
        }

        public float GetSalaryBySeniority(string seniority)
        {
            salariesBySeniority.TryGetValue(new EmployeeSeniority(seniority), out float salary);
            return salary;
        }
    }
}
