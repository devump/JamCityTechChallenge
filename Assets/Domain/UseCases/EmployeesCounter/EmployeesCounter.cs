using System.Collections.Generic;

namespace JamCityChallenge.Domain
{
    public class EmployeesCounter
    {
        private EmployeeRepository employeeRepository;
        private EmployeeSeniorityRepository employeeSeniorityRepository;

        public EmployeesCounter(EmployeeRepository employeeRepository, EmployeeSeniorityRepository employeeSeniorityRepository)
        {
            this.employeeRepository = employeeRepository;
            this.employeeSeniorityRepository = employeeSeniorityRepository;
        }

        public EmployeesCountResult Count(string position)
        {
            List<Employee> employees = employeeRepository.GetAll();
            List<EmployeeSeniority> seniorities = employeeSeniorityRepository.GetAll();

            int total = GetCountByPosition(employees, position);

            Dictionary<EmployeeSeniority, int> counts = new Dictionary<EmployeeSeniority, int>();
            seniorities.ForEach((EmployeeSeniority seniority) =>
            {
                int seniorityCount = GetCountByPositionAndSeniority(employees, position, seniority.GetName());
                counts.Add(seniority, seniorityCount);
            });

            return new EmployeesCountResult(total, counts);
        }

        private int GetCountByPosition(List<Employee> employees, string position)
        {
            List<Employee> employeesFound = employees.FindAll((Employee employee) =>
            {
                return employee.CheckPosition(position);
            });

            return employeesFound.Count;
        }

        private int GetCountByPositionAndSeniority(List<Employee> employees, string position, string seniority)
        {
            List<Employee> employeesFound = employees.FindAll((Employee employee) =>
            {
                return employee.CheckPosition(position) && employee.CheckSeniority(seniority);
            });

            return employeesFound.Count;
        }
    }
}