using JamCityChallenge.Adapters;

using UnityEngine;

namespace JamCityChallenge.Game
{
    public class DataProvider : MonoBehaviour
    {
        public ProviderData data;

        private void Start()
        {
            DataConsumer[] consumers = GetComponentsInChildren<DataConsumer>();

            foreach (DataConsumer consumer in consumers)
            {
                consumer.ProvideData(data);
            }
        }
    }
}