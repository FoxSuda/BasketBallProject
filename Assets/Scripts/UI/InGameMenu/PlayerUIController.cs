using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class PlayerUIController : MonoBehaviour
    {
        [SerializeField] private CoinsCountTextChange _coinsCountTextChange;
        [SerializeField] private BallHitCircleCheck _ballHitCircleCheck;

        private void Awake()
        {
            _ballHitCircleCheck.OnBallHits += CoinCountChange;
        }

        private void CoinCountChange(int coinValue)
        {
            _coinsCountTextChange.ChangeTextCoinsCount(coinValue);
        }

        private void OnDestroy()
        {
            _ballHitCircleCheck.OnBallHits -= CoinCountChange;
        }
    }
}

