using UnityEngine;
using UnityEngine.Audio;

namespace UnityTask.BasketballProject
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixer;

        [SerializeField] private string audioChannelMaster;
        [SerializeField] private string audioChannelSfx;
        [SerializeField] private string audioChannelMusic;

        [SerializeField] private float minVolume;
        [SerializeField] private float maxVolume;

        private bool _isMasterMuted = false;
        private bool _isSfxMuted = false;
        private bool _isMusicMuted = false;

        private float _masterValue;
        private float _sfxValue;
        private float _musicValue;

        public void ChangeAudioMaster(float value)
        {
            if (!_isMasterMuted)
            {
                mixer.SetFloat(audioChannelMaster, minVolume + (maxVolume - minVolume) * value);
            }
            _masterValue = value;
        }
        
        public void ChangeAudioSfx(float value)
        {
            if (!_isSfxMuted)
            {
                mixer.SetFloat(audioChannelSfx, minVolume + (maxVolume - minVolume) * value);
            }
            _sfxValue = value;
        }
        
        public void ChangeAudioMusic(float value)
        {
            if (!_isMusicMuted)
            {
                mixer.SetFloat(audioChannelMusic, minVolume + (maxVolume - minVolume) * value);
            }
            _musicValue = value;
        }

        public void MuteAudioMaster()
        {
            if (_isMasterMuted)
            {
                mixer.SetFloat(audioChannelMaster, minVolume + (maxVolume - minVolume) * _masterValue);
                _isMasterMuted = false;
            }
            else
            {
                mixer.SetFloat(audioChannelMaster, minVolume);
                _isMasterMuted = true;
            }
        }
        
        public void MuteAudioSfx()
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
        
        public void MuteAudioMusic()
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
}

