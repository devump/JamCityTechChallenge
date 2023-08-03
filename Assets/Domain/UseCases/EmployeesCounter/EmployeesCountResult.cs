using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeesCountResult
    {
        private int total;
        private Dictionary<EmployeeSeniority, int> counts;

        public EmployeesCountResult(int total, Dictionary<EmployeeSeniority, int> counts)
        {
            this.total = total;
            this.counts = counts;
        }

        public int GetTotal()
        {
            return total;
        }

        public int GetCountBySeniority(string seniority)
        {
            counts.TryGetValue(new EmployeeSeniority(seniority), out int count);
            return count;
        }
    }
}