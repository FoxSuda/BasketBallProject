using Doozy.Runtime.UIManager.Components;
using Doozy.Runtime.UIManager.Containers;
using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class SettingsMenuManager : MonoBehaviour
    {
        [SerializeField] private AudioManager _audioManager;

        [SerializeField] private UIButton _applySettingsButton;

        [SerializeField] private UISlider _masterVolumeSlider;
        [SerializeField] private UISlider _sfxVolumeSlider;
        [SerializeField] private UISlider _musicVolumeSlider;

        [SerializeField] private UIButton _masterMuteButton;
        [SerializeField] private UIButton _sfxMuteButton;
        [SerializeField] private UIButton _musicMuteButton;

        [SerializeField] private ÑhangePercentValue _masterSliderClass;
        [SerializeField] private ÑhangePercentValue _sfxSliderClass;
        [SerializeField] private ÑhangePercentValue _musicSliderClass;

        private UIContainer _uiContainer;

        private void Start()
        {
            _uiContainer = gameObject.GetComponent<UIContainer>();
        }

        public void Initialize()
        {
            _applySettingsButton.onClickEvent.AddListener(ApplyChanges);

            _masterVolumeSlider.OnValueChanged.AddListener(MasterVolumeChanged);
            _sfxVolumeSlider.OnValueChanged.AddListener(SfxVolumeChanged);
            _musicVolumeSlider.OnValueChanged.AddListener(MusicVolumeChanged);

            _masterMuteButton.onClickEvent.AddListener(MasterVolumeMuted);
            _sfxMuteButton.onClickEvent.AddListener(SfxVolumeMuted);
            _musicMuteButton.onClickEvent.AddListener(MusicVolumeMuted);

            MasterVolumeChanged(_masterVolumeSlider.value);
            SfxVolumeChanged(_sfxVolumeSlider.value);
            MusicVolumeChanged(_musicVolumeSlider.value);
        }

        public void MasterVolumeChanged(float value)
        {
            _audioManager.ChangeAudioMaster(value);
            _masterSliderClass.ChangeObjectValue(value);
        }
        
        public void SfxVolumeChanged(float value)
        {
            _audioManager.ChangeAudioSfx(value);
            _sfxSliderClass.ChangeObjectValue(value);
        }
        
        public void MusicVolumeChanged(float value)
        {
            _audioManager.ChangeAudioMusic(value);
            _musicSliderClass.ChangeObjectValue(value);
        }

        public void MasterVolumeMuted()
        {
            _audioManager.MuteAudioMaster();
        }
        
        public void SfxVolumeMuted()
        {
            _audioManager.MuteAudioSfx();
        }
        
        public void MusicVolumeMuted()
        {
            _audioManager.MuteAudioMusic();
        }

        public void ApplyChanges()
        {
            return;
        }

        public void Show()
        {
            _uiContainer.Show();
        }

        public void Hide()
        {
            _uiContainer.Hide();
        }

        private void OnDestroy()
        {
            _applySettingsButton.onClickEvent.RemoveListener(ApplyChanges);

            _masterVolumeSlider.OnValueChanged.RemoveListener(MasterVolumeChanged);
            _sfxVolumeSlider.OnValueChanged.RemoveListener(SfxVolumeChanged);
            _musicVolumeSlider.OnValueChanged.RemoveListener(MusicVolumeChanged);

            _masterMuteButton.onClickEvent.RemoveListener(MasterVolumeMuted);
            _sfxMuteButton.onClickEvent.RemoveListener(SfxVolumeMuted);
            _musicMuteButton.onClickEvent.RemoveListener(MusicVolumeMuted);
        }
    }
}

