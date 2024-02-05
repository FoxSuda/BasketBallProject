using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class HitCircleCountCoins : MonoBehaviour
    {
        [SerializeField] private BallHitCircleCheck _ballHitCircleCheck;

        private int _coinsValueHit = 0;
        private int _coinsValueHitMultiply = 5;

        public delegate void CoinsCountAdd();
        public event CoinsCountAdd OnCoinsCountChanged;

        public int CoinsValueHit
        {
            get { return _coinsValueHit; }
            set { _coinsValueHit = value; }
        }

        void Start()
        {
            _ballHitCircleCheck.OnBallGetThrowCircle += AddCoinsCount;
        }

        private void AddCoinsCount()
        {
            CoinsValueHit += _coinsValueHitMultiply;
            OnCoinsCountChanged?.Invoke();
        }
        
        public int GetCoinsCount()
        {
            return CoinsValueHit;
        }

        private void OnDestroy()
        {
            _ballHitCircleCheck.OnBallGetThrowCircle -= AddCoinsCount;
        }
    }
}

