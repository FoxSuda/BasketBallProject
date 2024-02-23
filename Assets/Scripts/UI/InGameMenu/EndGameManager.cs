using Doozy.Runtime.UIManager.Containers;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class EndGameManager : MonoBehaviour
    {
        [SerializeField] private BallManager _ballManager;
        [SerializeField] private UIContainer _InGameMenuUiContainer;
        [SerializeField] private GameObject _gameEnviromentUiContainer;

        private UIContainer _uiContainer;

        private void Start()
        {
            _uiContainer = gameObject.GetComponent<UIContainer>();
            _ballManager.OnBallFallWithoutCircle += EndGame;
        }

        private void EndGame()
        {
            _gameEnviromentUiContainer.SetActive(false);
            _InGameMenuUiContainer.Hide();
            _uiContainer.Show();
        }

        private void OnDestroy()
        {
            _ballManager.OnBallFallWithoutCircle -= EndGame;
        }

        public void Show()
        {
            _uiContainer.Show();
        }

        public void Hide()
        {
            _uiContainer.Hide();
        }
    }
}

