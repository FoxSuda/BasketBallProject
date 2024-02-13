using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class BallHitCircleCheck : MonoBehaviour
    {
        private bool _ballHitTopTrigger = false;

        [SerializeField] private int _ballGetThrowTimesNeeded;
        private int _ballGetThrowTimes;

        public delegate void BallGetThrowCircle();
        public event BallGetThrowCircle OnBallGetThrowCircle;
        public event BallGetThrowCircle OnBallGetThrowCircleTimes;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out BallManager ball) && _ballHitTopTrigger)
            {
                _ballGetThrowTimes++;

                if (_ballGetThrowTimes >= _ballGetThrowTimesNeeded)
                {
                    _ballGetThrowTimes = 0;
                    OnBallGetThrowCircleTimes?.Invoke();
                }

                OnBallGetThrowCircle?.Invoke();
            }
        }

        private void OnDisable()
        {
            _ballGetThrowTimes = 0;
        }

        public void BallHitsValidation(bool boolValue)
        {
            _ballHitTopTrigger = boolValue;
        }
    }
}

