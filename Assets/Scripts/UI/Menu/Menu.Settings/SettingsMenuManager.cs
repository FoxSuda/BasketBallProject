using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class SettingsMenuManager : MonoBehaviour
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
            _mainMenuObject.Show();
            _animator.Hide();
        }

        public void ApplyChanges()
        {
            return;
        }
    }
}

