using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeeSeniorityFinder
    {
        private EmployeeSeniorityRepository employeeSeniorityRepository;

        public EmployeeSeniorityFinder(EmployeeSeniorityRepository employeeSeniorityRepository)
        {
            this.employeeSeniorityRepository = employeeSeniorityRepository;
        }

        public EmployeeSeniorityFindAllResult FindAll()
        {
            List<EmployeeSeniority> seniorities = employeeSeniorityRepository.GetAll();
            EmployeeSeniorityFindAllResult result = new EmployeeSeniorityFindAllResult(seniorities);
            return result;
        }
    }
}