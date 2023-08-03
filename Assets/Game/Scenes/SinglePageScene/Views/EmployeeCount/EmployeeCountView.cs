using JamCityChallenge.Presentation;

using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Game
{
    [RequireComponent(typeof(PresenterConsumer))]
    public class EmployeeCountView : MonoBehaviour
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
            UIEmployeeCountPresenter presenter = presenterConsumer.GetPresenter<UIEmployeeCountPresenter>();

            List<UIEmployeeCountViewModel> counts = presenter.GetCounts();

            counts.ForEach((UIEmployeeCountViewModel count) =>
            {
                SimpleTable countItem = Instantiate(simpleTablePrefab, listContainer);
                countItem.SetTitle(count.title);
                countItem.SetRightText(count.totalCount);
                countItem.SetTableRows(count.seniorityCounts);
            });
        }
    }
}