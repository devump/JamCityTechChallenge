using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class DataAssetEmployeeSeniorityRepository : EmployeeSeniorityRepository
    {
        private ProviderData providerData;

        public DataAssetEmployeeSeniorityRepository(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<EmployeeSeniority> GetAll()
        {
            List<EmployeeSeniority> seniorities = new List<EmployeeSeniority>();

            providerData.seniorities.ForEach((SeniorityData seniorityData) =>
            {
                EmployeeSeniority seniority = new EmployeeSeniority(seniorityData.name);
                seniorities.Add(seniority);
            });

            return seniorities;
        }
    }
}