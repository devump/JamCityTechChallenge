using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UISalaryIncrementPresenter : SalaryIncrementPresenter<UISalaryIncrementViewModel>
    {
        private SalaryIncrementFinder incrementFinder;
        private EmployeePositionFinder employeePositionFinder;
        private EmployeeSeniorityFinder employeeSeniorityFinder;

        public UISalaryIncrementPresenter(
            SalaryIncrementRepository salaryIncrementRepository,
            EmployeePositionRepository employeePositionRepository,
            EmployeeSeniorityRepository employeeSeniorityRepository
        )
        {
            this.incrementFinder = new SalaryIncrementFinder(salaryIncrementRepository);
            this.employeePositionFinder = new EmployeePositionFinder(employeePositionRepository);
            this.employeeSeniorityFinder = new EmployeeSeniorityFinder(employeeSeniorityRepository);
        }

        public List<UISalaryIncrementViewModel> GetIncrements()
        {
            List<string> positions = GetPositions();
            List<string> seniorities = GetSeniorities();

            List<UISalaryIncrementViewModel> increments = new List<UISalaryIncrementViewModel>();
            positions.ForEach((string position) =>
            {
                SalaryIncrementFinderResult findResult = incrementFinder.FindByPosition(position);

                Dictionary<string, string> seniorityIncrements = new Dictionary<string, string>();
                seniorities.ForEach((string seniority) =>
                {
                    float seniorityIncrement = findResult.GetIncrementBySeniority(seniority);

                    if (seniorityIncrement > 0)
                    {
                        seniorityIncrements.Add(seniority, $"{seniorityIncrement}%");
                    }
                });

                UISalaryIncrementViewModel incrementModel = new UISalaryIncrementViewModel(position, seniorityIncrements);
                increments.Add(incrementModel);
            });

            return increments;
        }

        private List<string> GetPositions()
        {
            EmployeePositionFindAllResult findAllResult = employeePositionFinder.FindAll();
            List<string> positions = findAllResult.GetPositions();
            return positions;
        }

        private List<string> GetSeniorities()
        {
            EmployeeSeniorityFindAllResult findAllResult = employeeSeniorityFinder.FindAll();
            List<string> seniorities = findAllResult.GetSeniorities();
            return seniorities;
        }
    }
}