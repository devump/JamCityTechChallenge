using System;
using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Adapters
{
    [CreateAssetMenu(fileName = "EmployeesData", menuName = "ScriptableObjects/EmployeesData", order = 1)]
    public class EmployeesData : ScriptableObject
    {
        public PositionData position;
        public List<SeniorityCount> seniorityCounts;
    }

    [Serializable]
    public class SeniorityCount
    {
        public SeniorityData seniority;
        public int count;
    }
}