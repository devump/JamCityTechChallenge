using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class DataAssetBaseSalaryRepository : BaseSalaryRepository
    {
        private ProviderData providerData;

        public DataAssetBaseSalaryRepository(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<BaseSalary> GetAll()
        {
            List<BaseSalary> salaries = new List<BaseSalary>();

            List<BaseSalaryData> salariesData = providerData.baseSalaries;

            salariesData.ForEach((BaseSalaryData salaryData) =>
            {
                EmployeePosition position = new EmployeePosition(salaryData.position.position);
                Dictionary<EmployeeSeniority, float> senioritySalaries = new Dictionary<EmployeeSeniority, float>();

                salaryData.positionSalary.ForEach((SenioritySalaryData senioritySalary) =>
                {
                    EmployeeSeniority seniority = new EmployeeSeniority(senioritySalary.seniority.seniority);
                    senioritySalaries.Add(seniority, senioritySalary.salary);
                });

                salaries.Add(new BaseSalary(position, senioritySalaries));
            });

            return salaries;
        }
    }
}