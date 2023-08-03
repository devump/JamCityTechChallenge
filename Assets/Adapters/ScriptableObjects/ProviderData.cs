using System.Collections.Generic;
using UnityEngine;

namespace JamCityChallenge.Adapters
{
    [CreateAssetMenu(fileName = "ProviderData", menuName = "ScriptableObjects/ProviderData", order = 1)]
    public class ProviderData : ScriptableObject
    {
        public List<PositionData> positions;
        public List<SeniorityData> seniorities;
        public List<EmployeesData> employees;
        public List<SalaryIncrementData> salaryIncrements;
        public List<BaseSalaryData> baseSalaries;
    }
}