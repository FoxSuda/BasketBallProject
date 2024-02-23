using Doozy.Runtime.UIManager.Components;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class PlayerUIController : MonoBehaviour
    {
        [Header("GameEnviroment")]
        [SerializeField] private GameObject _gameEnviromentObject;

        [Header("Managers")]
        [SerializeField] private InGameMenuManager _inGameMenuManager;
        [SerializeField] private CustomizationMenuManager _customizationMenuManager;
        [SerializeField] private SettingsMenuManager _settingsMenuManager;
        [SerializeField] private MainMenuManager _mainMenuManager;
        [SerializeField] private EndGameManager _EndGameManager;

        [Header("MainMenu")]
        [SerializeField] private UIButton _startGameButton;
        [SerializeField] private UIButton _openSettingsMenuButton;
        [SerializeField] private UIButton _openCustomizationMenuButton;
        [SerializeField] private UIButton _closeGameButton;

        [Header("Settings")]
        [SerializeField] private UIButton _backToMenuSettingsButton;

        [Header("Customization")]
        [SerializeField] private UIButton _backToMenuCustomizationButton;

        [Header("InGame")]
        [SerializeField] private UIButton _backToMenuInGameButton;
        
        [Header("EndGame")]
        [SerializeField] private UIButton _backToMenuEndGameButton;
 
        private void Awake()
        {
            _settingsMenuManager.Initialize();

            /* Main menu */
            _startGameButton.onClickEvent.AddListener(StartGameMainMenu);
            _openCustomizationMenuButton.onClickEvent.AddListener(OpenCustomizationMainMenu);
            _openSettingsMenuButton.onClickEvent.AddListener(OpenSettingsMainMenu);
            _closeGameButton.onClickEvent.AddListener(CloseGameMainMenu);

            /* Settings */
            _backToMenuSettingsButton.onClickEvent.AddListener(BackToMainMenuSettings);

            /* Customization */
            _backToMenuCustomizationButton.onClickEvent.AddListener(BackToMainMenuCustomization);

            /* InGame */
            _backToMenuInGameButton.onClickEvent.AddListener(BackToMainMenuInGame);

            /* EndGame */
            _backToMenuEndGameButton.onClickEvent.AddListener(BackToMainMenuEndGame);
        }

        /* MainMenu methods */
        private void StartGameMainMenu()
        {
            _mainMenuManager.StartGame();
        }
        
        private void OpenSettingsMainMenu()
        {
            _mainMenuManager.OpenSettings();
        }
        
        private void OpenCustomizationMainMenu()
        {
            _mainMenuManager.OpenCustomization();
        }

        private void CloseGameMainMenu()
        {
            _mainMenuManager.ExitGame();
        }

        /* Settings methods */
        private void BackToMainMenuSettings()
        {
            _settingsMenuManager.Hide();
            _mainMenuManager.Show();
        }

        /* Customization methods */
        private void BackToMainMenuCustomization()
        {
            _customizationMenuManager.Hide();
            _mainMenuManager.Show();
        }

        /* InGame methods */
        private void BackToMainMenuInGame()
        {
            _gameEnviromentObject.SetActive(false);
            _inGameMenuManager.Hide();
            _mainMenuManager.Show();
        }
        
        /* EndGame methods */
        private void BackToMainMenuEndGame()
        {
            _gameEnviromentObject.SetActive(false);
            _EndGameManager.Hide();
            _mainMenuManager.Show();
        }

        private void OnDestroy()
        {
            /* Main menu */
            _startGameButton.onClickEvent.RemoveListener(StartGameMainMenu);
            _openSettingsMenuButton.onClickEvent.RemoveListener(OpenSettingsMainMenu);
            _openCustomizationMenuButton.onClickEvent.RemoveListener(OpenCustomizationMainMenu);
            _closeGameButton.onClickEvent.RemoveListener(CloseGameMainMenu);

            /* Settings */
            _backToMenuSettingsButton.onClickEvent.RemoveListener(BackToMainMenuSettings);

            /* Customization */
            _backToMenuCustomizationButton.onClickEvent.RemoveListener(BackToMainMenuCustomization);

            /* InGame */
            _backToMenuInGameButton.onClickEvent.RemoveListener(BackToMainMenuInGame);
        }
    }
}

