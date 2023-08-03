using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class TestSalaryIncrementsRepository : SalaryIncrementRepository
    {
        private List<SalaryIncrement> salaryIncrements;

        public TestSalaryIncrementsRepository()
        {
            salaryIncrements = new List<SalaryIncrement>();

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("HR"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 5f },
                { new EmployeeSeniority("Semi Senior"), 2f },
                { new EmployeeSeniority("Junior"), 0.5f }
            }));

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("Engineer"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 10f },
                { new EmployeeSeniority("Semi Senior"), 7f },
                { new EmployeeSeniority("Junior"), 5f }
            }));

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("Artist"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 5f },
                { new EmployeeSeniority("Semi Senior"), 2.5f },
                { new EmployeeSeniority("Junior"), 0f }
            }));

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("Design"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 7f },
                { new EmployeeSeniority("Semi Senior"), 0f },
                { new EmployeeSeniority("Junior"), 4f }
            }));

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("PM"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 10f },
                { new EmployeeSeniority("Semi Senior"), 5f },
                { new EmployeeSeniority("Junior"), 0f }
            }));

            salaryIncrements.Add(new SalaryIncrement(new EmployeePosition("CEO"), new Dictionary<EmployeeSeniority, float>()
            {
                { new EmployeeSeniority("Senior"), 100f },
                { new EmployeeSeniority("Semi Senior"), 0f },
                { new EmployeeSeniority("Junior"), 0f }
            }));
        }

        public List<SalaryIncrement> GetAll()
        {
            return salaryIncrements;
        }
    }
}