using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JamCityChallenge.Game
{
    public class SimpleTable : MonoBehaviour
    {
        public TextMeshProUGUI headerText;
        public TextMeshProUGUI headerValue;

        public SimpleTableRow seniorityCountItemPrefab;
        public Transform seniorityCountContainer;

        public void SetTitle(string title)
        {
            headerText.SetText(title);
        }

        public void SetRightText(string total)
        {
            headerValue.SetText(total);
        }

        public void SetTableRows(Dictionary<string, string> rows)
        {
            foreach (KeyValuePair<string, string> seniorityCount in rows)
            {
                SimpleTableRow item = Instantiate(seniorityCountItemPrefab, seniorityCountContainer);
                item.SetText(seniorityCount.Key);
                item.SetValue(seniorityCount.Value);
            }
        }
    }
}