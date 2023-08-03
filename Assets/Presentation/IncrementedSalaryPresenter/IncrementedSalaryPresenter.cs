using System.Collections.Generic;

namespace JamCityChallenge.Presentation
{
    interface IncrementedSalaryPresenter<T> : Presenter
    {
        public List<T> GetSalaries();
    }
}