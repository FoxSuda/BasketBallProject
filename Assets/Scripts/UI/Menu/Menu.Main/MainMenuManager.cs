using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _settingsObject;
        [SerializeField] private UIContainerUIAnimator _customizationObject;
        [SerializeField] private UIContainerUIAnimator _InGameMenuObject;

        private UIContainerUIAnimator _animator;

        private void Awake()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _animator.Show();
        }

        public void StartGame()
        {
            _animator.Hide();
            _InGameMenuObject.Show();
        }

        public void OpenSettings()
        {
            _animator.Hide();
            _settingsObject.Show();
        }

        public void OpenCustomization()
        {
            _animator.Hide();
            _customizationObject.Show();
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

