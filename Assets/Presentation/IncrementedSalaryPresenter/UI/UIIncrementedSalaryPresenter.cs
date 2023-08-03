using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UIIncrementedSalaryPresenter : IncrementedSalaryPresenter<UIIncrementedSalaryViewModel>
    {
        private IncrementedSalaryCalculator incrementedSalaryCalculator;
        private BaseSalaryFinder baseSalaryFinder;
        private EmployeePositionFinder employeePositionFinder;
        private EmployeeSeniorityFinder employeeSeniorityFinder;

        public UIIncrementedSalaryPresenter(
            SalaryIncrementRepository salaryIncrementRepository,
            BaseSalaryRepository baseSalaryRepository,
            EmployeePositionRepository employeePositionRepository,
            EmployeeSeniorityRepository employeeSeniorityRepository
        )
        {
            this.incrementedSalaryCalculator = new IncrementedSalaryCalculator(employeeSeniorityRepository, baseSalaryRepository, salaryIncrementRepository);
            this.baseSalaryFinder = new BaseSalaryFinder(baseSalaryRepository);
            this.employeePositionFinder = new EmployeePositionFinder(employeePositionRepository);
            this.employeeSeniorityFinder = new EmployeeSeniorityFinder(employeeSeniorityRepository);
        }

        public List<UIIncrementedSalaryViewModel> GetSalaries()
        {
            List<string> positions = GetPositions();
            List<string> seniorities = GetSeniorities();

            List<UIIncrementedSalaryViewModel> salaries = new List<UIIncrementedSalaryViewModel>();
            positions.ForEach((string position) =>
            {
                IncrementedSalaryCalculatorResult calculatorResult = incrementedSalaryCalculator.Calculate(position);
                BaseSalaryFinderResult baseSalaryResult = baseSalaryFinder.FindByPosition(position);

                Dictionary<string, string> senioritySalaries = new Dictionary<string, string>();
                seniorities.ForEach((string seniority) =>
                {
                    float baseSalary = baseSalaryResult.GetSalaryBySeniority(seniority);
                    float incrementedSalary = calculatorResult.GetSalaryBySeniority(seniority);

                    if (incrementedSalary > 0)
                    {
                        string increment = $"${baseSalary} > ${incrementedSalary}";
                        senioritySalaries.Add(seniority, increment);
                    }
                });

                UIIncrementedSalaryViewModel salaryModel = new UIIncrementedSalaryViewModel(position, senioritySalaries);
                salaries.Add(salaryModel);
            });

            return salaries;
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