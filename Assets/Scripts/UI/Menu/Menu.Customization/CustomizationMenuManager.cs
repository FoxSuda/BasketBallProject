using Doozy.Runtime.UIManager.Animators;
using Doozy.Runtime.UIManager.Components;
using Doozy.Runtime.UIManager.Containers;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTask.BasketballProject
{
    public class CustomizationMenuManager : MonoBehaviour
    {
        [SerializeField] private Image _image;

        [SerializeField] private BallSkinChange _ballSkinChange;

        [SerializeField] private UIButton _leftArrowButton;
        [SerializeField] private UIButton _rightArrowButton;

        [SerializeField] private UIToggle _toggle;

        private Texture2D _skin;

        private UIContainer _uiContainer;
        private UIContainerUIAnimator _uiContainerUIAnimator;

        private void Start()
        {
            _uiContainer = gameObject.GetComponent<UIContainer>();
            _uiContainerUIAnimator = gameObject.GetComponent<UIContainerUIAnimator>();

            _leftArrowButton.onClickEvent.AddListener(PreviousSkin);
            _rightArrowButton.onClickEvent.AddListener(NextSkin);

            _toggle.onClickEvent.AddListener(ToggleSkin);

            _skin = _ballSkinChange.GetCurrentSkin();

            _image.sprite = ChangeSprite();

            _toggle.isOn = _ballSkinChange.GetSkinToggleValidation();
        }

        public void PreviousSkin()
        {
            _skin = _ballSkinChange.MoveToPreviousMaterial();
            _image.sprite = ChangeSprite();
            _toggle.isOn = _ballSkinChange.GetSkinToggleValidation();
        }
        
        public void NextSkin()
        {
            _skin = _ballSkinChange.MoveToNextMaterial();
            _image.sprite = ChangeSprite();
            _toggle.isOn = _ballSkinChange.GetSkinToggleValidation();
        }

        public void ToggleSkin()
        {
            if (_toggle.isOn == false)
            {
                _toggle.isOn = true;
            }
            _ballSkinChange.AcceptMaterialValidation();
        }

        public void Show()
        {
            //_uiContainer.Show();
            _uiContainerUIAnimator.Show();
        }

        public void Hide()
        {
            //_uiContainer.Hide();
            _uiContainerUIAnimator.Hide();
        }

        private Sprite ChangeSprite()
        {
            return Sprite.Create(_skin, new Rect(0, 0, _skin.width, _skin.height), Vector2.zero);
        }

        private void OnDestroy()
        {
            _leftArrowButton.onClickEvent.RemoveListener(PreviousSkin);
            _rightArrowButton.onClickEvent.RemoveListener(NextSkin);

            _toggle.onClickEvent.RemoveListener(ToggleSkin);
        }
    }
}

