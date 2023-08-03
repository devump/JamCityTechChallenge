using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public interface EmployeeRepository
    {
        public List<Employee> GetAll();
    }
}