using Doozy.Runtime.UIManager.Animators;
using UnityEngine;
using UnityEngine.Audio;

namespace UnityTask.BasketballProject
{
    public class SettingsMenuManager : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixer;

        [SerializeField] private string audioChannelMaster;
        [SerializeField] private string audioChannelSfx;
        [SerializeField] private string audioChannelMusic;

        [SerializeField] private float minVolume;
        [SerializeField] private float maxVolume;

        [SerializeField] private UIContainerUIAnimator _mainMenuObject;

        [SerializeField] private MuteButtonVisual _masterVolumeMute;
        [SerializeField] private MuteButtonVisual _sfxVolumeMute;
        [SerializeField] private MuteButtonVisual _musicVolumeMute;

        [SerializeField] private ÑhangePercentValue _masterSliderClass;
        [SerializeField] private ÑhangePercentValue _sfxSliderClass;
        [SerializeField] private ÑhangePercentValue _musicSliderClass;

        private bool _isMasterMuted = false;
        private bool _isSfxMuted = false;
        private bool _isMusicMuted = false;

        private float _masterValue;
        private float _sfxValue;
        private float _musicValue;

        private UIContainerUIAnimator _animator;

        private void Start()
        {
            _animator = gameObject.GetComponent<UIContainerUIAnimator>();
        }

        public void ChangeVolumeValue(VolumeType volumeType, float value)
        {
            if (volumeType == VolumeType.Master)
            {
                if (!_isMasterMuted)
                {
                    mixer.SetFloat("Master", minVolume + (maxVolume - minVolume) * value);
                }
                _masterValue = value;
                _masterSliderClass.ChangeObjectValue(value);
            } else if (volumeType == VolumeType.Sfx)
            {
                if (!_isSfxMuted)
                {
                    mixer.SetFloat(audioChannelSfx, minVolume + (maxVolume - minVolume) * value);
                }
                _sfxValue = value;
                _sfxSliderClass.ChangeObjectValue(value);
            } else if (volumeType == VolumeType.Music)
            {
                if (!_isMusicMuted)
                {
                    mixer.SetFloat(audioChannelMusic, minVolume + (maxVolume - minVolume) * value);
                }
                _musicValue = value;
                _musicSliderClass.ChangeObjectValue(value);
            }
        }
        
        public void MuteVolumeValidation(VolumeType volumeType)
        {
            if (volumeType == VolumeType.Master)
            {
                if (_isMasterMuted)
                {
                    mixer.SetFloat(audioChannelMaster, minVolume + (maxVolume - minVolume) * _masterValue);
                    _isMasterMuted = false;
                } else
                {
                    mixer.SetFloat(audioChannelMaster, minVolume);
                    _isMasterMuted = true;
                }
            }
            else if (volumeType == VolumeType.Sfx)
            {
                if (_isSfxMuted)
                {
                    mixer.SetFloat(audioChannelSfx, minVolume + (maxVolume - minVolume) * _sfxValue);
                    _isSfxMuted = false;
                }
                else
                {
                    mixer.SetFloat(audioChannelSfx, minVolume);
                    _isSfxMuted = true;
                }
            }
            else if (volumeType == VolumeType.Music)
            {
                if (_isMusicMuted)
                {
                    mixer.SetFloat(audioChannelMusic, minVolume + (maxVolume - minVolume) * _musicValue);
                    _isMusicMuted = false;
                }
                else
                {
                    mixer.SetFloat(audioChannelMusic, minVolume);
                    _isMusicMuted = true;
                }
            }
        }

        public void BackToMainMenu()
        {
            _mainMenuObject.Show();
            _animator.Hide();
        }

        public void ApplyChanges()
        {
            return;
        }
    }
}

