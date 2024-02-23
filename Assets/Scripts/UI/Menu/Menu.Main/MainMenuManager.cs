using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _settingsObject;
        [SerializeField] private UIContainerUIAnimator _customizationObject;
        [SerializeField] private UIContainerUIAnimator _InGameMenuObject;

        [SerializeField] private GameObject _gameEnviromentObject;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _animator.Show();
        }

        public void StartGame()
        {
            _gameEnviromentObject.SetActive(true);
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

        public void Show()
        {
            _animator.Show();
        }

        public void Hide()
        {
            _animator.Hide();
        }
    }
}

