using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class InGameMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _mainMenuObject;
        [SerializeField] private CoinsCountTextChange _coinsCountTextChange;
        [SerializeField] private HitCircleCountCoins _hitCircleCountCoins;

        [SerializeField] private GameObject _gameEnviromentObject;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _hitCircleCountCoins.OnCoinsCountChanged += CoinCountChange;
        }

        public void BackToMainMenu()
        {
            _gameEnviromentObject.SetActive(false);
            _animator.Hide();
            _mainMenuObject.Show();
        }

        private void CoinCountChange()
        {
            _coinsCountTextChange.ChangeTextCoinsCount(_hitCircleCountCoins.GetCoinsCount());
        }
    }
}

