using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeeSeniorityFindAllResult
    {
        private List<EmployeeSeniority> seniorities;

        public EmployeeSeniorityFindAllResult(List<EmployeeSeniority> seniorities)
        {
            this.seniorities = seniorities;
        }

        public List<string> GetSeniorities()
        {
            List<string> seniorityNames = seniorities.ConvertAll((EmployeeSeniority position) =>
            {
                return position.GetName();
            });

            return seniorityNames;
        }
    }
}