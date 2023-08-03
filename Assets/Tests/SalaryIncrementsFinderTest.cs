using JamCityChallenge.Adapters;
using JamCityChallenge.Domain;
using NUnit.Framework;

namespace JamCityChallenge.Tests
{
    public class SalaryIncrementsFinderTest
    {
        private SalaryIncrementFinder salaryIncrementsFinder;

        [SetUp]
        public void SetUp()
        {
            salaryIncrementsFinder = new SalaryIncrementFinder(new TestSalaryIncrementsRepository());
        }

        [TestCase("HR", 5f, 2f, 0.5f)]
        [TestCase("Engineer", 10f, 7f, 5f)]
        [TestCase("Artist", 5f, 2.5f, 0f)]
        [TestCase("Design", 7f, 0f, 4f)]
        [TestCase("PM", 10f, 5f, 0f)]
        [TestCase("CEO", 100f, 0f, 0f)]
        public void FindSalaryIncrements(string position, float expectedSeniors, float expectedSemiSeniors, float expectedJuniors)
        {
            SalaryIncrementFinderResult result = salaryIncrementsFinder.FindByPosition(position);

            Assert.AreEqual(expectedSeniors, result.GetIncrementBySeniority("Senior"));
            Assert.AreEqual(expectedSemiSeniors, result.GetIncrementBySeniority("Semi Senior"));
            Assert.AreEqual(expectedJuniors, result.GetIncrementBySeniority("Junior"));
        }
    }
}