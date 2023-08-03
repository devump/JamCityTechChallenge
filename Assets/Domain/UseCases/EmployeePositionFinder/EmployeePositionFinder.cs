using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeePositionFinder
    {
        private EmployeePositionRepository employeePositionRepository;

        public EmployeePositionFinder(EmployeePositionRepository employeePositionRepository)
        {
            this.employeePositionRepository = employeePositionRepository;
        }

        public EmployeePositionFindAllResult FindAll()
        {
            List<EmployeePosition> positions = employeePositionRepository.GetAll();
            EmployeePositionFindAllResult result = new EmployeePositionFindAllResult(positions);
            return result;
        }
    }
}