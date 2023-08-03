using JamCityChallenge.Adapters;

using UnityEngine;

namespace JamCityChallenge.Game
{
    [RequireComponent(typeof(DataProvider))]
    [RequireComponent(typeof(PresenterProvider))]
    public class SinglePageScene : MonoBehaviour
    {
        private DataProvider dataProvider;
        private PresenterProvider presenterProvider;

        private void Awake()
        {
            dataProvider = GetComponent<DataProvider>();
            presenterProvider = GetComponent<PresenterProvider>();

            Installler installer = new Installler(dataProvider.data);
            presenterProvider.Initialize(installer.GetPresenters());
        }
    }
}