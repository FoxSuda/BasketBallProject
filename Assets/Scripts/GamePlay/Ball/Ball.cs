using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTask.BasketballProject
{
    [RequireComponent(typeof(Rigidbody))]
    public class Ball : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float _throwingVelScale;
        [SerializeField] private BallHitCircleCheck ballHitCircleCheck;
        private Rigidbody rb;
        private bool isThrown;
        private bool isGetThrowCircle;

        public delegate void BallFallDelegate();
        public event BallFallDelegate OnBallFall;

        private void Start()
        {
            ballHitCircleCheck.OnBallGetThrowCircle += BallGetThrowCircleValidation;
            rb = GetComponent<Rigidbody>();
            isThrown = false;
            isGetThrowCircle = false;
        }

        public void ThrowBall(Vector3 velocity)
        {
            if (!isThrown)
            {
                rb.useGravity = true;
                isThrown = true;
                rb.velocity = velocity * _throwingVelScale;
            }
        }

        public void ReturnBall()
        {
            if (isGetThrowCircle)
            {
                isGetThrowCircle = false;
                rb.useGravity = false;
                transform.position = spawnPoint.position;
                isThrown = false;
                rb.velocity = Vector3.zero;
                ballHitCircleCheck.BallHitsValidation(false);
                OnBallFall.Invoke();
            } else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }

        public void BallGetThrowCircleValidation()
        {
            isGetThrowCircle = true;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Floor"))
            {
                ReturnBall();
            }
        }

        private void OnDestroy()
        {
            ballHitCircleCheck.OnBallGetThrowCircle -= BallGetThrowCircleValidation;
        }
    }
}

