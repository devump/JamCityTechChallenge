using JamCityChallenge.Domain;

using System.Collections.Generic;

namespace JamCityChallenge.Adapters
{
    public class TestEmployeeRepository : EmployeeRepository
    {
        private List<Employee> data;

        public TestEmployeeRepository()
        {
            EmployeePosition hr = new("HR");
            EmployeePosition engineer = new EmployeePosition("Engineer");
            EmployeePosition artist = new EmployeePosition("Artist");
            EmployeePosition design = new EmployeePosition("Design");
            EmployeePosition pm = new EmployeePosition("PM");
            EmployeePosition ceo = new EmployeePosition("CEO");

            EmployeeSeniority senior = new EmployeeSeniority("Senior");
            EmployeeSeniority semiSenior = new EmployeeSeniority("SemiSenior");
            EmployeeSeniority junior = new EmployeeSeniority("Junior");

            EmployeesBuilder builder = new EmployeesBuilder();

            builder.BuildStep(hr, senior, 5);
            builder.BuildStep(hr, semiSenior, 2);
            builder.BuildStep(hr, junior, 13);

            builder.BuildStep(engineer, senior, 50);
            builder.BuildStep(engineer, semiSenior, 68);
            builder.BuildStep(engineer, junior, 32);

            builder.BuildStep(artist, senior, 5);
            builder.BuildStep(artist, semiSenior, 20);

            builder.BuildStep(design, senior, 10);
            builder.BuildStep(design, junior, 15);

            builder.BuildStep(pm, senior, 10);
            builder.BuildStep(pm, semiSenior, 20);

            builder.BuildStep(ceo, senior, 1);

            this.data = builder.GetResult();
        }

        public List<Employee> GetAll()
        {
            return this.data;
        }
    }
}