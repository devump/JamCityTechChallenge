using JamCityChallenge.Presentation;

using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Game
{
    public class PresenterProvider : MonoBehaviour
    {
        private List<Presenter> presenters;

        public void Initialize(List<Presenter> presenters)
        {
            this.presenters = presenters;
        }

        public T GetPresenter<T>() where T : Presenter
        {
            Presenter presenter = presenters.Find((Presenter presenter) =>
            {
                return presenter.GetType().Equals(typeof(T));
            });

            return (T)presenter;
        }

        private void Start()
        {
            PresenterConsumer[] consumers = GetComponentsInChildren<PresenterConsumer>();

            foreach (PresenterConsumer consumer in consumers)
            {
                consumer.SetProvider(this);
            }
        }
    }
}