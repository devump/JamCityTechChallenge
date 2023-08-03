using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public interface EmployeeSeniorityRepository
    {
        public List<EmployeeSeniority> GetAll();
    }
}