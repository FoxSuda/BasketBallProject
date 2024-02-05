using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class BallFalls : MonoBehaviour
    {
        private BallManager _ball;

        private void Awake()
        {
            _ball = GetComponent<BallManager>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Floor"))
            {
                _ball.ReturnBall();
            }
        }
    }
}

