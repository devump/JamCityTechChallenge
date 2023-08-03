using System;
using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Adapters
{
    [CreateAssetMenu(fileName = "BaseSalaryData", menuName = "ScriptableObjects/BaseSalaryData", order = 1)]
    public class BaseSalaryData : ScriptableObject
    {
        public PositionData position;
        public List<SenioritySalaryData> positionSalary;
    }

    [Serializable]
    public class SenioritySalaryData
    {
        public SeniorityData seniority;
        public float salary;
    }
}