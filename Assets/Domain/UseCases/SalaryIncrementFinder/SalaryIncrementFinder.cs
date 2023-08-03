using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class SalaryIncrementFinder
    {
        private SalaryIncrementRepository salaryIncrementRepository;

        public SalaryIncrementFinder(SalaryIncrementRepository salaryIncrementRepository)
        {
            this.salaryIncrementRepository = salaryIncrementRepository;
        }

        public SalaryIncrementFinderResult FindByPosition(string position)
        {
            List<SalaryIncrement> salaryIncrements = salaryIncrementRepository.GetAll();

            SalaryIncrement increments = salaryIncrements.Find((SalaryIncrement increments) =>
            {
                return increments.CheckPosition(position);
            });

            SalaryIncrementFinderResult result = new SalaryIncrementFinderResult(increments);

            return result;
        }
    }
}