using Doozy.Runtime.Reactor.Animators;
using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class CustomizationMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _mainMenuObject;

        private UIContainerUIAnimator _animator;

        private void Awake()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _animator.InstantHide();
        }

        public void BackToMainMenu()
        {
            _animator.Hide();
            _mainMenuObject.Show();
        }
    }
}

