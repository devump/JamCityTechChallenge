using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UIEmployeeCountPresenter : EmployeeCountPresenter<UIEmployeeCountViewModel>
    {
        private EmployeesCounter employeesCounter;
        private EmployeePositionFinder employeePositionFinder;
        private EmployeeSeniorityFinder employeeSeniorityFinder;

        public UIEmployeeCountPresenter(
            EmployeeRepository employeeRepository,
            EmployeePositionRepository employeePositionRepository,
            EmployeeSeniorityRepository employeeSeniorityRepostitory
        )
        {
            this.employeesCounter = new EmployeesCounter(employeeRepository, employeeSeniorityRepostitory);
            this.employeePositionFinder = new EmployeePositionFinder(employeePositionRepository);
            this.employeeSeniorityFinder = new EmployeeSeniorityFinder(employeeSeniorityRepostitory);
        }

        public List<UIEmployeeCountViewModel> GetCounts()
        {
            List<string> positions = GetPositions();
            List<string> seniorities = GetSeniorities();

            List<UIEmployeeCountViewModel> counts = new List<UIEmployeeCountViewModel>();
            positions.ForEach((string position) =>
            {
                EmployeesCountResult countResult = employeesCounter.Count(position);
                int totalCount = countResult.GetTotal();

                Dictionary<string, string> positionCounts = new Dictionary<string, string>();
                seniorities.ForEach((string seniority) =>
                {
                    int seniorityCount = countResult.GetCountBySeniority(seniority);

                    if (seniorityCount > 0)
                    {
                        positionCounts.Add(seniority, seniorityCount.ToString());
                    }
                });

                UIEmployeeCountViewModel countModel = new UIEmployeeCountViewModel(position, totalCount.ToString(), positionCounts);
                counts.Add(countModel);
            });

            return counts;
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