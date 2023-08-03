using JamCityChallenge.Presentation;

using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Game
{
    [RequireComponent(typeof(PresenterConsumer))]
    public class IncrementedSalaryView : MonoBehaviour
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
            UIIncrementedSalaryPresenter presenter = presenterConsumer.GetPresenter<UIIncrementedSalaryPresenter>();

            List<UIIncrementedSalaryViewModel> salaries = presenter.GetSalaries();

            salaries.ForEach((UIIncrementedSalaryViewModel salary) =>
            {
                SimpleTable incrementTable = Instantiate(simpleTablePrefab, listContainer);
                incrementTable.SetTitle(salary.title);
                incrementTable.SetTableRows(salary.amount);
            });
        }
    }
}