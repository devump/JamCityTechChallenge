using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class DataAssetEmployeePositionRepository : EmployeePositionRepository
    {
        private ProviderData providerData;

        public DataAssetEmployeePositionRepository(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<EmployeePosition> GetAll()
        {
            List<EmployeePosition> positions = new List<EmployeePosition>();

            List<PositionData> positionsData = providerData.positions;

            positionsData.ForEach((PositionData positionData) =>
            {
                positions.Add(new EmployeePosition(positionData.name));
            });

            return positions;
        }
    }
}