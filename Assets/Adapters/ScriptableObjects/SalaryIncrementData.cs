using System;
using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Adapters
{
    [CreateAssetMenu(fileName = "SalaryIncrementData", menuName = "ScriptableObjects/SalaryIncrementData", order = 1)]
    public class SalaryIncrementData : ScriptableObject
    {
        public PositionData position;
        public List<SeniorityIncrementData> positionIncrements;
    }

    [Serializable]
    public class SeniorityIncrementData
    {
        public SeniorityData seniority;
        public float increment;
    }
}