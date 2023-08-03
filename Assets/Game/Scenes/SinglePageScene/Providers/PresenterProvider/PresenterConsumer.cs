using JamCityChallenge.Presentation;

using UnityEngine;

namespace JamCityChallenge.Game
{
    public class PresenterConsumer : MonoBehaviour
    {
        private PresenterProvider provider;

        public delegate void PresenterProvided();
        public event PresenterProvided OnPresenterProvided;

        public void SetProvider(PresenterProvider provider)
        {
            this.provider = provider;
            OnPresenterProvided?.Invoke();
        }

        public T GetPresenter<T>() where T : Presenter
        {
            return provider.GetPresenter<T>();
        }
    }
}