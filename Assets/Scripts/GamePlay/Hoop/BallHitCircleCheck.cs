using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class BallHitCircleCheck : MonoBehaviour
    {
        private bool _ballHitTopTrigger = false;

        public delegate void BallGetThrowCircle();
        public event BallGetThrowCircle OnBallGetThrowCircle;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out BallManager ball) && _ballHitTopTrigger)
            {
                OnBallGetThrowCircle?.Invoke();
            }
        }

        public void BallHitsValidation(bool boolValue)
        {
            _ballHitTopTrigger = boolValue;
        }
    }
}

