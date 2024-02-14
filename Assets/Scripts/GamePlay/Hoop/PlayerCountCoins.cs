using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class PlayerCountCoins : MonoBehaviour
    {
        [SerializeField] private BallHitCircleCheck _ballHitCircleCheck;

        private int _coinsCount = 0;
        private int _coinsValueHitMultiply = 5;

        public delegate void CoinsCountAdd();
        public event CoinsCountAdd OnCoinsCountChanged;

        public int CoinsCount
        {
            get { return _coinsCount; }
            set { _coinsCount = value; }
        }

        void Start()
        {
            _ballHitCircleCheck.OnBallGetThrowCircle += AddCoinsCount;
        }

        private void AddCoinsCount()
        {
            CoinsCount += _coinsValueHitMultiply;
            OnCoinsCountChanged?.Invoke();
        }
        
        public void RemoveCoinsCount(int count)
        {
            CoinsCount -= count;
            OnCoinsCountChanged?.Invoke();
        }
        
        public int GetCoinsCount()
        {
            return CoinsCount;
        }

        private void OnDestroy()
        {
            _ballHitCircleCheck.OnBallGetThrowCircle -= AddCoinsCount;
        }
    }
}

