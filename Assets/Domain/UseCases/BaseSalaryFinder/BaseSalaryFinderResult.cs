namespace JamCityChallenge.Domain
{
    public class BaseSalaryFinderResult
    {
        private BaseSalary baseSalary;

        public BaseSalaryFinderResult(BaseSalary baseSalary)
        {
            this.baseSalary = baseSalary;
        }

        public float GetSalaryBySeniority(string seniority)
        {
            return baseSalary.GetSalaryBySeniority(seniority);
        }
    }
}