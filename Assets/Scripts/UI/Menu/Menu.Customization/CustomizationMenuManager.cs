using Doozy.Runtime.Reactor.Animators;
using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class CustomizationMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _mainMenuObject;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
        }

        public void BackToMainMenu()
        {
            _animator.Hide();
            _mainMenuObject.Show();
        }
    }
}

