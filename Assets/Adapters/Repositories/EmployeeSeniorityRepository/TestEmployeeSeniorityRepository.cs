using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class TestEmployeeSeniorityRepository : EmployeeSeniorityRepository
    {
        private List<EmployeeSeniority> seniorities;

        public TestEmployeeSeniorityRepository()
        {
            seniorities = new List<EmployeeSeniority>();

            seniorities.Add(new EmployeeSeniority("Senior"));
            seniorities.Add(new EmployeeSeniority("Semi Senior"));
            seniorities.Add(new EmployeeSeniority("Junior"));
        }

        public List<EmployeeSeniority> GetAll()
        {
            return seniorities;
        }
    }
}