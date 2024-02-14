using Doozy.Runtime.UIManager.Animators;
using System.Collections;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class InGameMenuManager : MonoBehaviour
    {
        [SerializeField] private UIContainerUIAnimator _mainMenuObject;
        [SerializeField] private CoinsCountTextChange _coinsCountTextChange;
        [SerializeField] private PlayerCountCoins _playerCountCoins;

        [SerializeField] private BallHitCircleCheck _ballHitCircleCheck;

        [SerializeField] private GameObject _gameEnviromentObject;
        [SerializeField] private GameObject _announceTextObject;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
            _playerCountCoins.OnCoinsCountChanged += CoinCountChange;
            _ballHitCircleCheck.OnBallGetThrowCircleTimes += AnnouncePlayer;
        }

        private void CoinCountChange()
        {
            _coinsCountTextChange.ChangeTextCoinsCount(_playerCountCoins.GetCoinsCount());
        }

        private void AnnouncePlayer()
        {
            StartCoroutine(Announce());
        }

        private IEnumerator Announce()
        {
            _announceTextObject.SetActive(true);

            yield return new WaitForSeconds(0.75f);

            _announceTextObject.SetActive(false);
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

