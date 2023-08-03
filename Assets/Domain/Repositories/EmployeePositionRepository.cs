using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public interface EmployeePositionRepository
    {
        public List<EmployeePosition> GetAll();
    }
}
