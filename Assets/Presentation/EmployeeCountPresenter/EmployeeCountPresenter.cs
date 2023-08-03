using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    interface EmployeeCountPresenter<T> : Presenter
    {
        public List<T> GetCounts();
    }
}