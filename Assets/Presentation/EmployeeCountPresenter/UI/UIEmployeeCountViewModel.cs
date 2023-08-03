using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    public class UIEmployeeCountViewModel
    {
        public string title;
        public string totalCount;
        public Dictionary<string, string> seniorityCounts;

        public UIEmployeeCountViewModel(string title, string totalCount, Dictionary<string, string> seniorityCounts)
        {
            this.title = title;
            this.totalCount = totalCount;
            this.seniorityCounts = seniorityCounts;
        }
    }
}