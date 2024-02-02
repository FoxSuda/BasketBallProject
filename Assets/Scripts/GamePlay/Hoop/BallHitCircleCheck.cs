using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class BallHitCircleCheck : MonoBehaviour
    {
        [SerializeField] private PlayerUIController playerUIController;

        private int _coinsValueHit = 0;
        private int _coinsValueHitMultiply = 5;
        private bool _ballHitTopTrigger = false;

        public delegate void BallHitsDelegate(int coinValue);
        public event BallHitsDelegate OnBallHits;

        public delegate void BallGetThrowCircle();
        public event BallGetThrowCircle OnBallGetThrowCircle;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Ball ball) && _ballHitTopTrigger)
            {
                _coinsValueHit += _coinsValueHitMultiply;
                OnBallHits?.Invoke(_coinsValueHit);
                OnBallGetThrowCircle?.Invoke();
            }
        }

        public void BallHitsValidation(bool boolValue)
        {
            _ballHitTopTrigger = boolValue;
        }
    }
}

