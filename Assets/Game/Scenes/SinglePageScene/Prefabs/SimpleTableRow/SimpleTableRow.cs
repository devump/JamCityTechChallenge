using TMPro;
using UnityEngine;

namespace JamCityChallenge.Game
{
    public class SimpleTableRow : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public TextMeshProUGUI value;

        public void SetText(string text)
        {
            this.text.SetText(text);
        }

        public void SetValue(string value)
        {
            this.value.SetText(value);
        }
    }
}