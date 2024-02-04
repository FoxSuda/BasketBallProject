using Doozy.Runtime.UIManager.Animators;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class InGameMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _mainMenuObject;
        [SerializeField] private CoinsCountTextChange _coinsCountTextChange;

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

        private void CoinCountChange(int coinValue)
        {
            _coinsCountTextChange.ChangeTextCoinsCount(coinValue);
        }
    }
}

