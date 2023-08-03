using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class IncrementedSalaryCalculator
    {
        private EmployeeSeniorityRepository employeeSeniorityRepository;
        private BaseSalaryRepository baseSalariesRepository;
        private SalaryIncrementRepository salaryIncrementsRepository;

        public IncrementedSalaryCalculator(
            EmployeeSeniorityRepository employeeSeniorityRepository,
            BaseSalaryRepository baseSalaryRepository,
            SalaryIncrementRepository salaryIncrementRepository
        )
        {
            this.employeeSeniorityRepository = employeeSeniorityRepository;
            this.baseSalariesRepository = baseSalaryRepository;
            this.salaryIncrementsRepository = salaryIncrementRepository;
        }

        public IncrementedSalaryCalculatorResult Calculate(string position)
        {
            List<BaseSalary> baseSalaries = baseSalariesRepository.GetAll();
            List<SalaryIncrement> salaryIncrements = salaryIncrementsRepository.GetAll();

            List<EmployeeSeniority> seniorities = employeeSeniorityRepository.GetAll();

            BaseSalary positionBaseSalaries = baseSalaries.Find((BaseSalary salaries) =>
            {
                return salaries.CheckPosition(position);
            });

            SalaryIncrement positionSalaryIncrements = salaryIncrements.Find((SalaryIncrement increments) =>
            {
                return increments.CheckPosition(position);
            });

            Dictionary<EmployeeSeniority, float> incrementedSalaries = new Dictionary<EmployeeSeniority, float>();
            seniorities.ForEach((EmployeeSeniority seniority) =>
            {
                float seniorityBaseSalary = positionBaseSalaries.GetSalaryBySeniority(seniority.GetName());
                float senioritySalaryIncrement = positionSalaryIncrements.GetIncrementBySeniority(seniority);

                float increment = seniorityBaseSalary * senioritySalaryIncrement / 100;
                float incrementedSalary = seniorityBaseSalary + increment;

                incrementedSalaries.Add(seniority, incrementedSalary);
            });

            IncrementedSalaryCalculatorResult result = new IncrementedSalaryCalculatorResult(new EmployeePosition(position), incrementedSalaries);

            return result;
        }
    }
}