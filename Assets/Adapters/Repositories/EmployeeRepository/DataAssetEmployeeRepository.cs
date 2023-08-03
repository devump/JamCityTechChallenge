using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class DataAssetEmployeeRepository : EmployeeRepository
    {
        private ProviderData providerData;

        public DataAssetEmployeeRepository(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<Employee> GetAll()
        {
            EmployeesBuilder employeesBuilder = new EmployeesBuilder();

            providerData.employees.ForEach((EmployeesData employeesData) =>
            {
                employeesData.seniorityCounts.ForEach((SeniorityCount seniorityCount) =>
                {
                    EmployeePosition position = new EmployeePosition(employeesData.position.name);
                    EmployeeSeniority seniority = new EmployeeSeniority(seniorityCount.seniority.name);
                    employeesBuilder.BuildStep(position, seniority, seniorityCount.count);
                });
            });

            List<Employee> result = employeesBuilder.GetResult();

            return result;
        }
    }
}