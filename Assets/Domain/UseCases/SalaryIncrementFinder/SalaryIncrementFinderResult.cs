namespace JamCityChallenge.Domain
{
    public class SalaryIncrementFinderResult
    {
        private SalaryIncrement salaryIncrements;

        public SalaryIncrementFinderResult(SalaryIncrement salaryIncrements)
        {
            this.salaryIncrements = salaryIncrements;
        }

        public float GetIncrementBySeniority(string seniority)
        {
            return salaryIncrements.GetIncrementBySeniority(new EmployeeSeniority(seniority));
        }
    }
}