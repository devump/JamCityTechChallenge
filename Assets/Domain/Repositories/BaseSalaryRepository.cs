using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public interface BaseSalaryRepository
    {
        public List<BaseSalary> GetAll();
    }
}
