using TMPro;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class CoinsCountTextChange : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinText;

        public void ChangeTextCoinsCount(int coinValue)
        {
            _coinText.text = $"Coins: {coinValue}";
        }
    }
}

