using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UISalaryIncrementViewModel
    {
        public string title;
        public Dictionary<string, string> senioritySalaries;

        public UISalaryIncrementViewModel(string title, Dictionary<string, string> senioritySalaries)
        {
            this.title = title;
            this.senioritySalaries = senioritySalaries;
        }
    }
}