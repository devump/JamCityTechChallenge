using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeePositionFindAllResult
    {
        private List<EmployeePosition> positions;

        public EmployeePositionFindAllResult(List<EmployeePosition> positions)
        {
            this.positions = positions;
        }

        public List<string> GetPositions()
        {
            List<string> positionNames = positions.ConvertAll((EmployeePosition position) =>
            {
                return position.GetName();
            });

            return positionNames;
        }
    }
}