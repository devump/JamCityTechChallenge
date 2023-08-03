using JamCityChallenge.Presentation;

using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Game
{
    [RequireComponent(typeof(PresenterConsumer))]
    public class SalaryIncrementView : MonoBehaviour
    {
        public Transform listContainer;
        public SimpleTable simpleTablePrefab;

        private PresenterConsumer presenterConsumer;

        private void Awake()
        {
            presenterConsumer = GetComponent<PresenterConsumer>();
            presenterConsumer.OnPresenterProvided += RenderData;
        }

        void RenderData()
        {
            UISalaryIncrementPresenter presenter = presenterConsumer.GetPresenter<UISalaryIncrementPresenter>();

            List<UISalaryIncrementViewModel> increments = presenter.GetIncrements();

            increments.ForEach((UISalaryIncrementViewModel increment) =>
            {
                SimpleTable incrementTable = Instantiate(simpleTablePrefab, listContainer);
                incrementTable.SetTitle(increment.title);
                incrementTable.SetTableRows(increment.senioritySalaries);
            });
        }
    }
}