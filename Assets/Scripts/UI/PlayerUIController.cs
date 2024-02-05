using Doozy.Runtime.UIManager.Components;
using UnityEngine;
using static Doozy.Runtime.UIManager.Components.UIToggleGroup;

namespace UnityTask.BasketballProject
{
    public class PlayerUIController : MonoBehaviour
    {
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
        [SerializeField] private UIButton _applySettingsButton;

        [SerializeField] private UISlider _onMasterVolumeChangeSettings;
        [SerializeField] private UISlider _onSfxVolumeChangeSettings;
        [SerializeField] private UISlider _onMusicVolumeChangeSettings;

        [SerializeField] private UIButton _onMasterVolumeMuteSettings;
        [SerializeField] private UIButton _onSfxVolumeMuteSettings;
        [SerializeField] private UIButton _onMusicVolumeMuteSettings;

        [Header("Customization")]
        [SerializeField] private UIButton _backToMenuCustomizationButton;

        [Header("InGame")]
        [SerializeField] private UIButton _backToMenuInGameButton;
        
        [Header("EndGame")]
        [SerializeField] private UIButton _backToMenuEndGameButton;
 
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

            _onMasterVolumeChangeSettings.OnValueChanged.AddListener(value => OnVolumeValueChangedSettings(VolumeType.Master, value));
            _onSfxVolumeChangeSettings.OnValueChanged.AddListener(value => OnVolumeValueChangedSettings(VolumeType.Sfx, value));
            _onMusicVolumeChangeSettings.OnValueChanged.AddListener(value => OnVolumeValueChangedSettings(VolumeType.Music, value));

            _onMasterVolumeMuteSettings.onClickEvent.AddListener(() => OnVolumeMutedSettings(VolumeType.Master));
            _onSfxVolumeMuteSettings.onClickEvent.AddListener(() => OnVolumeMutedSettings(VolumeType.Sfx));
            _onMusicVolumeMuteSettings.onClickEvent.AddListener(() => OnVolumeMutedSettings(VolumeType.Music));

            OnVolumeValueChangedSettings(VolumeType.Master, _onMasterVolumeChangeSettings.value);
            OnVolumeValueChangedSettings(VolumeType.Sfx, _onSfxVolumeChangeSettings.value);
            OnVolumeValueChangedSettings(VolumeType.Music, _onMusicVolumeChangeSettings.value);

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
            _settingsMenuManager.BackToMainMenu();
        }
        
        private void ApplySettings()
        {
            _settingsMenuManager.ApplyChanges();
        }
        
        private void OnVolumeValueChangedSettings(VolumeType volumeType, float value)
        {
            _settingsMenuManager.ChangeVolumeValue(volumeType, value);
        }
        
        private void OnVolumeMutedSettings(VolumeType volumeType)
        {
            _settingsMenuManager.MuteVolumeValidation(volumeType);
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
        
        /* EndGame methods */
        private void BackToMainMenuEndGame()
        {
            _EndGameManager.BackToMainMenu();
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

            _onMasterVolumeChangeSettings.OnValueChanged.RemoveListener(value => OnVolumeValueChangedSettings(VolumeType.Master, value));
            _onSfxVolumeChangeSettings.OnValueChanged.RemoveListener(value => OnVolumeValueChangedSettings(VolumeType.Sfx, value));
            _onMusicVolumeChangeSettings.OnValueChanged.RemoveListener(value => OnVolumeValueChangedSettings(VolumeType.Music, value));

            _onMasterVolumeMuteSettings.onClickEvent.RemoveListener(() => OnVolumeMutedSettings(VolumeType.Master));
            _onSfxVolumeMuteSettings.onClickEvent.RemoveListener(() => OnVolumeMutedSettings(VolumeType.Sfx));
            _onMusicVolumeMuteSettings.onClickEvent.RemoveListener(() => OnVolumeMutedSettings(VolumeType.Music));

            /* Customization */
            _backToMenuCustomizationButton.onClickEvent.RemoveListener(BackToMainMenuCustomization);

            /* InGame */
            _backToMenuInGameButton.onClickEvent.RemoveListener(BackToMainMenuInGame);
        }
    }

    public enum VolumeType
    {
        Master,
        Sfx,
        Music
    }
}

