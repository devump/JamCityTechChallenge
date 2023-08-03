using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class BaseSalaryFinder
    {
        private BaseSalaryRepository baseSalaryRepository;

        public BaseSalaryFinder(BaseSalaryRepository baseSalaryRepository)
        {
            this.baseSalaryRepository = baseSalaryRepository;
        }

        public BaseSalaryFinderResult FindByPosition(string position)
        {
            List<BaseSalary> baseSalaries = baseSalaryRepository.GetAll();

            BaseSalary salary = baseSalaries.Find((BaseSalary salary) =>
            {
                return salary.CheckPosition(position);
            });

            BaseSalaryFinderResult result = new BaseSalaryFinderResult(salary);

            return result;
        }
    }
}