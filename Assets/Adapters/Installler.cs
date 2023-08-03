using JamCityChallenge.Presentation;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class Installler
    {
        private ProviderData providerData;

        public Installler(ProviderData providerData)
        {
            this.providerData = providerData;
        }

        public List<Presenter> GetPresenters()
        {
            // Initialize repositories
            DataAssetEmployeeRepository employeeRepository = new DataAssetEmployeeRepository(providerData);
            DataAssetEmployeePositionRepository employeePositionRepository = new DataAssetEmployeePositionRepository(providerData);
            DataAssetEmployeeSeniorityRepository employeeSeniorityRepository = new DataAssetEmployeeSeniorityRepository(providerData);
            DataAssetSalaryIncrementRepository salaryIncrementRepository = new DataAssetSalaryIncrementRepository(providerData);
            DataAssetBaseSalaryRepository baseSalaryRepository = new DataAssetBaseSalaryRepository(providerData);

            // Initialize presenters
            List<Presenter> presenters = new List<Presenter>();

            UIEmployeeCountPresenter employeeCountPresenter = new UIEmployeeCountPresenter(employeeRepository, employeePositionRepository, employeeSeniorityRepository);
            presenters.Add(employeeCountPresenter);

            UISalaryIncrementPresenter salaryIncrementPresenter = new UISalaryIncrementPresenter(salaryIncrementRepository, employeePositionRepository, employeeSeniorityRepository);
            presenters.Add(salaryIncrementPresenter);

            UIIncrementedSalaryPresenter incrementedSalaryPresenter = new UIIncrementedSalaryPresenter(salaryIncrementRepository, baseSalaryRepository, employeePositionRepository, employeeSeniorityRepository);
            presenters.Add(incrementedSalaryPresenter);

            return presenters;
        }
    }
}
