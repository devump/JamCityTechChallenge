using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public interface SalaryIncrementRepository
    {
        public List<SalaryIncrement> GetAll();
    }
}
