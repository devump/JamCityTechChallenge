using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    interface SalaryIncrementPresenter<T> : Presenter
    {
        public List<T> GetIncrements();
    }
}