using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class HoopCircleTriggerCheck : MonoBehaviour
    {

        [SerializeField] private GameObject _bottomCircleTrigger;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.TryGetComponent(out Ball ball))
            {
                _bottomCircleTrigger.GetComponent<BallHitCircleCheck>().BallHitsValidation(true);
            }
        }
    }
}
