using JamCityChallenge.Adapters;
using JamCityChallenge.Domain;
using NUnit.Framework;

namespace JamCityChallenge.Tests
{
    public class BaseSalaryFinderTest
    {
        private BaseSalaryFinder baseSalaryFinder;

        [SetUp]
        public void SetUp()
        {
            baseSalaryFinder = new BaseSalaryFinder(new TestBaseSalaryRepository());
        }

        [TestCase("HR", 1500f, 1000f, 500f)]
        [TestCase("Engineer", 5000f, 3000f, 1500f)]
        [TestCase("Artist", 2000f, 1200f, 0f)]
        [TestCase("Design", 2000f, 0f, 800f)]
        [TestCase("PM", 4000f, 2400f, 0f)]
        [TestCase("CEO", 20000f, 0f, 0f)]
        public void FindBaseSalaries(string position, float expectedSeniors, float expectedSemiSeniors, float expectedJuniors)
        {
            BaseSalaryFinderResult result = baseSalaryFinder.FindByPosition(position);

            float seniorSalary = result.GetSalaryBySeniority("Senior");
            float semiSeniorSalary = result.GetSalaryBySeniority("Semi Senior");
            float juniorSalary = result.GetSalaryBySeniority("Junior");

            Assert.AreEqual(expectedSeniors, seniorSalary);
            Assert.AreEqual(expectedSemiSeniors, semiSeniorSalary);
            Assert.AreEqual(expectedJuniors, juniorSalary);
        }
    }
}
