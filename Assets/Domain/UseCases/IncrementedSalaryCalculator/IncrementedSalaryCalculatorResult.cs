using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class IncrementedSalaryCalculatorResult
    {
        public EmployeePosition position;
        public Dictionary<EmployeeSeniority, float> salaries;

        public IncrementedSalaryCalculatorResult(EmployeePosition position, Dictionary<EmployeeSeniority, float> salaries)
        {
            this.position = position;
            this.salaries = salaries;
        }

        public float GetSalaryBySeniority(string seniority)
        {
            salaries.TryGetValue(new EmployeeSeniority(seniority), out float salary);
            return salary;
        }
    }
}