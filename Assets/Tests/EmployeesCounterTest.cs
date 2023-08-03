using JamCityChallenge.Adapters;
using JamCityChallenge.Domain;
using NUnit.Framework;

namespace JamCityChallenge.Tests
{
    public class EmployeesCounterTest
    {
        private EmployeesCounter employeesSorter;

        [SetUp]
        public void SetUp()
        {
            this.employeesSorter = new EmployeesCounter(new TestEmployeeRepository(), new TestEmployeeSeniorityRepository());
        }

        [TestCase("HR", 20, 5, 2, 13)]
        [TestCase("Engineer", 150, 50, 68, 32)]
        [TestCase("Artist", 25, 5, 20, 0)]
        [TestCase("Design", 25, 10, 0, 15)]
        [TestCase("PM", 30, 10, 20, 0)]
        [TestCase("CEO", 1, 1, 0, 0)]
        public void SortEmployees(string position, int expectedTotal, int expectedSeniors, int expectedSemiSeniors, int expectedJuniors)
        {
            EmployeesCountResult countResult = this.employeesSorter.Count(position);

            int totalCount = countResult.GetTotal();
            int seniorCount = countResult.GetCountBySeniority("Senior");
            int semiSeniorCount = countResult.GetCountBySeniority("Semi Senior");
            int juniorCount = countResult.GetCountBySeniority("Junior");

            Assert.AreEqual(expectedTotal, totalCount);
            Assert.AreEqual(expectedSeniors, seniorCount);
            Assert.AreEqual(expectedSemiSeniors, semiSeniorCount);
            Assert.AreEqual(expectedJuniors, juniorCount);
        }
    }
}