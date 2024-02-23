using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class HoopPositionChanged : MonoBehaviour
    {
        [SerializeField] private BallManager _ball;

        private float _startPositionX;
        private float _startPositionZ;

        private float _firstPositionZ = 0.5f;
        private float _secondPositionZ = -2f;

        private float _firstPositionX = -2f;
        private float _secondPositionX = 2f;

        private void Awake()
        {
            _ball.OnBallFall += ChangePosition;

            _startPositionX = transform.position.x;
            _startPositionZ = transform.position.z;

            _firstPositionZ += transform.position.z;
            _secondPositionZ += transform.position.z;
            _firstPositionX += transform.position.x;
            _secondPositionX += transform.position.x;
        }

        public void ChangePosition()
        {
            float randomX = Random.Range(_firstPositionX, _secondPositionX);
            float randomZ = Random.Range(_firstPositionZ, _secondPositionZ);

            Vector3 newPosition = new Vector3(randomX, transform.position.y, randomZ);

            transform.position = newPosition;
        }

        private void OnDestroy()
        {
            _ball.OnBallFall -= ChangePosition;
        }

        private void OnDisable()
        {
            transform.position = new Vector3(_startPositionX, transform.position.y, _startPositionZ); ;
        }
    }
}

