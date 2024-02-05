using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class EndGameManager : MonoBehaviour
    {
        [SerializeField] private BallManager _ballManager;
        [SerializeField] private UIContainerUIAnimator _InGameMenuObject;
        [SerializeField] private UIContainerUIAnimator _MainMenuObject;
        [SerializeField] private GameObject _gameEnviromentObject;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _ballManager.OnBallFallWithoutCircle += EndGame;
        }

        private void EndGame()
        {
            _gameEnviromentObject.SetActive(false);
            _InGameMenuObject.Hide();
            _animator.Show();
        }

        public void BackToMainMenu()
        {
            _animator.Hide();
            _MainMenuObject.Show();
        }

        private void OnDestroy()
        {
            _ballManager.OnBallFallWithoutCircle -= EndGame;
        }
    }
}

