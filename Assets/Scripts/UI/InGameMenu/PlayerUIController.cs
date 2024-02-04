using Doozy.Runtime.UIManager.Components;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class PlayerUIController : MonoBehaviour
    {
        [Header("Managers")]
        [SerializeField] private InGameMenuManager _inGameMenuManager;
        [SerializeField] private CustomizationMenuManager _customizationMenuManager;
        [SerializeField] private SettingsMenuManager _settingsMenuManager;
        [SerializeField] private MainMenuManager _mainMenuManager;

        [Header("MainMenu")]
        [SerializeField] private UIButton _startGameButton;
        [SerializeField] private UIButton _openSettingsMenuButton;
        [SerializeField] private UIButton _openCustomizationMenuButton;
        [SerializeField] private UIButton _closeGameButton;

        [Header("Settings")]
        [SerializeField] private UIButton _backToMenuSettingsButton;
        [SerializeField] private UIButton _applySettingsButton;
        [SerializeField] private UISlider _onMasterVolumeChangeSettings;
        [SerializeField] private UISlider _onSfxVolumeChangeSettings;
        [SerializeField] private UISlider _onMusicVolumeChangeSettings;

        [Header("Customization")]
        [SerializeField] private UIButton _backToMenuCustomizationButton;

        [Header("InGame")]
        [SerializeField] private UIButton _backToMenuInGameButton;
 
        private void Awake()
        {
            /* Main menu */
            _startGameButton.onClickEvent.AddListener(StartGameMainMenu);
            _openCustomizationMenuButton.onClickEvent.AddListener(OpenCustomizationMainMenu);
            _openSettingsMenuButton.onClickEvent.AddListener(OpenSettingsMainMenu);
            _closeGameButton.onClickEvent.AddListener(CloseGameMainMenu);

            /* Settings */
            _backToMenuSettingsButton.onClickEvent.AddListener(BackToMainMenuSettings);
            _applySettingsButton.onClickEvent.AddListener(ApplySettings);
            _onMasterVolumeChangeSettings.OnValueChanged.AddListener(OnMasterValueChangedSettings);
            _onSfxVolumeChangeSettings.OnValueChanged.AddListener(OnSfxValueChangedSettings);
            _onMusicVolumeChangeSettings.OnValueChanged.AddListener(OnMusicValueChangedSettings);

            /* Customization */
            _backToMenuCustomizationButton.onClickEvent.AddListener(BackToMainMenuCustomization);

            /* InGame */
            _backToMenuInGameButton.onClickEvent.AddListener(BackToMainMenuInGame);
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
            _settingsMenuManager.BackToMainMenu();
        }
        
        private void ApplySettings()
        {
            _settingsMenuManager.ApplyChanges();
        }
        
        private void OnMasterValueChangedSettings(float value)
        {
            _settingsMenuManager.ApplyChanges();
        }

        private void OnSfxValueChangedSettings(float value)
        {
            _settingsMenuManager.ApplyChanges();
        }

        private void OnMusicValueChangedSettings(float value)
        {
            _settingsMenuManager.ApplyChanges();
        }

        /* Customization methods */
        private void BackToMainMenuCustomization()
        {
            _customizationMenuManager.BackToMainMenu();
        }

        /* InGame methods */
        private void BackToMainMenuInGame()
        {
            _inGameMenuManager.BackToMainMenu();
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
            _applySettingsButton.onClickEvent.RemoveListener(ApplySettings);
            _onMasterVolumeChangeSettings.OnValueChanged.RemoveListener(OnMasterValueChangedSettings);
            _onSfxVolumeChangeSettings.OnValueChanged.RemoveListener(OnSfxValueChangedSettings);
            _onMusicVolumeChangeSettings.OnValueChanged.RemoveListener(OnMusicValueChangedSettings);

            /* Customization */
            _backToMenuCustomizationButton.onClickEvent.RemoveListener(BackToMainMenuCustomization);

            /* InGame */
            _backToMenuInGameButton.onClickEvent.RemoveListener(BackToMainMenuInGame);
        }
    }
}

