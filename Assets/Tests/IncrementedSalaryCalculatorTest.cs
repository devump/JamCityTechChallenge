using JamCityChallenge.Adapters;
using JamCityChallenge.Domain;
using NUnit.Framework;

namespace JamCityChallenge.Tests
{
    class IncrementedSalaryCalculatorTest
    {
        private IncrementedSalaryCalculator incrementedSalaryCalculator;

        [SetUp]
        public void SetUp()
        {
            incrementedSalaryCalculator = new IncrementedSalaryCalculator(new TestEmployeeSeniorityRepository(), new TestBaseSalaryRepository(), new TestSalaryIncrementsRepository());
        }

        [TestCase("HR", 1575f, 1020f, 502.5f)]
        [TestCase("Engineer", 5500f, 3210f, 1575f)]
        [TestCase("Artist", 2100f, 1230f, 0f)]
        [TestCase("Design", 2140f, 0f, 832f)]
        [TestCase("PM", 4400f, 2520f, 0f)]
        [TestCase("CEO", 40000f, 0f, 0f)]
        public void FindSalaryIncrements(string position, float expectedSeniors, float expectedSemiSeniors, float expectedJuniors)
        {
            IncrementedSalaryCalculatorResult result = incrementedSalaryCalculator.Calculate(position);

            float seniorSalary = result.GetSalaryBySeniority("Senior");
            float semiSeniorSalary = result.GetSalaryBySeniority("Semi Senior");
            float juniorSalary = result.GetSalaryBySeniority("Junior");

            Assert.AreEqual(expectedSeniors, seniorSalary);
            Assert.AreEqual(expectedSemiSeniors, semiSeniorSalary);
            Assert.AreEqual(expectedJuniors, juniorSalary);
        }
    }
}