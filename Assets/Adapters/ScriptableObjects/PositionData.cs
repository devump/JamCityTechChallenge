using UnityEngine;

namespace JamCityChallenge.Adapters
{
    [CreateAssetMenu(fileName = "PositionData", menuName = "ScriptableObjects/PositionData", order = 1)]
    public class PositionData : ScriptableObject
    {
        public string position;
    }
}