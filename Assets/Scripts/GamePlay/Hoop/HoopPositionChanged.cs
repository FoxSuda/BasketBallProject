using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class HoopPositionChanged : MonoBehaviour
    {
        [SerializeField] private BallManager _ball;

        private void Awake()
        {
            _ball.OnBallFall += ChangePosition;
        }

        public void ChangePosition()
        {
            float randomX = Random.Range(-0.4f, 0.4f);

            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);

            transform.position = newPosition;
        }

        private void OnDestroy()
        {
            _ball.OnBallFall -= ChangePosition;
        }

        private void OnDisable()
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z); ;
        }
    }
}

