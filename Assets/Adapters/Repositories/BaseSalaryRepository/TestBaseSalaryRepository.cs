using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class TestBaseSalaryRepository : BaseSalaryRepository
    {
        private List<BaseSalary> baseSalaries;

        public TestBaseSalaryRepository()
        {
            baseSalaries = new List<BaseSalary>();

            baseSalaries.Add(new BaseSalary(new EmployeePosition("HR"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 1500f },
                { new EmployeeSeniority("Semi Senior"), 1000f },
                { new EmployeeSeniority("Junior"), 500f }
            }));

            baseSalaries.Add(new BaseSalary(new EmployeePosition("Engineer"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 5000f },
                { new EmployeeSeniority("Semi Senior"), 3000f },
                { new EmployeeSeniority("Junior"), 1500f }
            }));

            baseSalaries.Add(new BaseSalary(new EmployeePosition("Artist"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 2000f },
                { new EmployeeSeniority("Semi Senior"), 1200f },
                { new EmployeeSeniority("Junior"), 0f }
            }));

            baseSalaries.Add(new BaseSalary(new EmployeePosition("Design"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 2000f },
                { new EmployeeSeniority("Semi Senior"), 0f },
                { new EmployeeSeniority("Junior"), 800f }
            }));

            baseSalaries.Add(new BaseSalary(new EmployeePosition("PM"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 4000f },
                { new EmployeeSeniority("Semi Senior"), 2400f },
                { new EmployeeSeniority("Junior"), 0f }
            }));

            baseSalaries.Add(new BaseSalary(new EmployeePosition("CEO"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 20000f },
                { new EmployeeSeniority("Semi Senior"), 0f },
                { new EmployeeSeniority("Junior"), 0f }
            }));
        }

        public List<BaseSalary> GetAll()
        {
            return baseSalaries;
        }
    }
}