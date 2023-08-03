namespace JamCityChallenge.Domain
{
    using System.Collections.Generic;

    public class SalaryIncrement
    {
        private EmployeePosition position;
        private Dictionary<EmployeeSeniority, float> incrementPercentages;

        public SalaryIncrement(EmployeePosition position, Dictionary<EmployeeSeniority, float> incrementPercentages)
        {
            this.position = position;
            this.incrementPercentages = incrementPercentages;
        }

        public bool CheckPosition(string positionToCheck)
        {
            return position.Equals(new EmployeePosition(positionToCheck));
        }

        public float GetIncrementBySeniority(EmployeeSeniority seniority)
        {
            incrementPercentages.TryGetValue(seniority, out float increment);
            return increment;
        }
    }
}