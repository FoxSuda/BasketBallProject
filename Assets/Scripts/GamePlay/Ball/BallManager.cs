using UnityEngine;

namespace UnityTask.BasketballProject
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallManager : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float _throwingVelScale;
        [SerializeField] private BallHitCircleCheck ballHitCircleCheck;
        private Rigidbody rb;
        private bool isThrown;
        private bool isGetThrowCircle;

        public delegate void BallFallDelegate();
        public event BallFallDelegate OnBallFall;
        public event BallFallDelegate OnBallFallWithoutCircle;

        private void Awake()
        {
            ballHitCircleCheck.OnBallGetThrowCircle += BallGetThrowCircleValidation;
            rb = GetComponent<Rigidbody>();
            isThrown = false;
            isGetThrowCircle = false;
        }

        private void OnEnable()
        {
            ResetBall();
        }

        public void ThrowBall(Vector3 velocity)
        {
            if (!isThrown)
            {
                rb.freezeRotation = false;
                rb.useGravity = true;
                isThrown = true;
                rb.velocity = velocity * _throwingVelScale;
            }
        }

        public void ReturnBall()
        {
            if (isGetThrowCircle)
            {
                ResetBall();
                ballHitCircleCheck.BallHitsValidation(false);
                OnBallFall?.Invoke();
            }
            else
            {
                ResetBall();
                OnBallFallWithoutCircle?.Invoke();
            }
        }

        public void ResetBall()
        {
            transform.rotation = Quaternion.identity;
            isGetThrowCircle = false;
            rb.freezeRotation = true;
            rb.useGravity = false;
            transform.position = spawnPoint.position;
            isThrown = false;
            rb.velocity = Vector3.zero;
        }

        public void BallGetThrowCircleValidation()
        {
            isGetThrowCircle = true;
        }

        private void OnDestroy()
        {
            ballHitCircleCheck.OnBallGetThrowCircle -= BallGetThrowCircleValidation;
        }
    }
}

