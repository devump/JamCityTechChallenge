using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UIIncrementedSalaryViewModel
    {
        public string title;
        public Dictionary<string, string> amount;

        public UIIncrementedSalaryViewModel(string title, Dictionary<string, string> amount)
        {
            this.title = title;
            this.amount = amount;
        }
    }
}