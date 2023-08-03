using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class EmployeesBuilder
    {
        private List<Employee> result;

        public EmployeesBuilder()
        {
            result = new List<Employee>();
        }

        public void BuildStep(EmployeePosition position, EmployeeSeniority seniority, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                result.Add(new Employee(position, seniority));
            }
        }

        public List<Employee> GetResult()
        {
            return this.result;
        }
    }
}