using Doozy.Runtime.UIManager.Containers;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private SettingsMenuManager _settingsUiContainer;
        [SerializeField] private CustomizationMenuManager _customizationUiContainer;
        [SerializeField] private InGameMenuManager _InGameMenuUiContainer;

        [SerializeField] private GameObject _gameEnviromentObject;

        private UIContainer _uiContainer;

        private void Start()
        {
            _uiContainer = gameObject.GetComponent<UIContainer>();
            _uiContainer.Show();
        }

        public void StartGame()
        {
            _gameEnviromentObject.SetActive(true);
            _uiContainer.Hide();
            _InGameMenuUiContainer.Show();
        }

        public void OpenSettings()
        {
            _uiContainer.Hide();
            _settingsUiContainer.Show();
        }

        public void OpenCustomization()
        {
            _uiContainer.Hide();
            _customizationUiContainer.Show();
        }

        public void ExitGame()
        {
            Application.Quit();
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

