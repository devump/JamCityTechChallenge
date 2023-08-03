using JamCityChallenge.Adapters;

using UnityEngine;

namespace JamCityChallenge.Game
{
    public class DataConsumer : MonoBehaviour
    {
        private ProviderData data;

        public delegate void DataProvided();
        public event DataProvided OnDataProvided;

        public void ProvideData(ProviderData data)
        {
            this.data = data;
            OnDataProvided?.Invoke();
        }

        public ProviderData GetData()
        {
            return data;
        }
    }
}