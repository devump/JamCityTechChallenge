using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class DataAssetSalaryIncrementRepository : SalaryIncrementRepository
    {
        private ProviderData providerData;

        public DataAssetSalaryIncrementRepository(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<SalaryIncrement> GetAll()
        {
            List<SalaryIncrement> increments = new List<SalaryIncrement>();

            List<SalaryIncrementData> incrementsData = providerData.salaryIncrements;

            incrementsData.ForEach((SalaryIncrementData incrementData) =>
            {
                EmployeePosition position = new EmployeePosition(incrementData.position.position);
                Dictionary<EmployeeSeniority, float> incrementPercentages = new Dictionary<EmployeeSeniority, float>();

                incrementData.positionIncrements.ForEach((SeniorityIncrementData incrementData) =>
                {
                    EmployeeSeniority seniority = new EmployeeSeniority(incrementData.seniority.seniority);
                    incrementPercentages.Add(seniority, incrementData.increment);
                });

                increments.Add(new SalaryIncrement(position, incrementPercentages));
            });

            return increments;
        }
    }
}