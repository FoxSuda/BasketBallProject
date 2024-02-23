using UnityEngine;
using UnityTask.BasketballProject;

public class BallSkinChange : MonoBehaviour
{
    [SerializeField] private PlayerCountCoins _playerCountCoins;

    [SerializeField] private BallManager _ballManager;

    [SerializeField] private SkinConfiguration[] _skinConfiguration;

    [SerializeField] private MeshRenderer _ballMaterial;

    private bool _skinToggle = true;

    Texture _currentTexture;
    Texture _nextTexture;

    private int _currentSkinNumber = 0;

    public Texture2D MoveToNextMaterial()
    {
        _currentSkinNumber++;

        if (_currentSkinNumber == _skinConfiguration.Length)
        {
            _currentSkinNumber = 0;
        }

        _currentTexture = _ballMaterial.material.mainTexture;

        _nextTexture = _skinConfiguration[_currentSkinNumber].SkinMaterial.mainTexture;

        if (_currentTexture == _nextTexture)
        {
            _skinToggle = true;
        }
        else
        {
            _skinToggle = false;
        }

        return _skinConfiguration[_currentSkinNumber].SkinImage;
    }
    
    public Texture2D MoveToPreviousMaterial()
    {
        _currentSkinNumber--;

        if (_currentSkinNumber == -1)
        {
            _currentSkinNumber = _skinConfiguration.Length - 1;
        }

        _currentTexture = _ballMaterial.material.mainTexture;

        _nextTexture = _skinConfiguration[_currentSkinNumber].SkinMaterial.mainTexture;

        if (_currentTexture == _nextTexture)
        {
            _skinToggle = true;
        }
        else
        {
            _skinToggle = false;
        }

        return _skinConfiguration[_currentSkinNumber].SkinImage;
    }
    
    public bool AcceptMaterialValidation()
    {
        if (!_skinConfiguration[_currentSkinNumber].SkinBought)
        {
            SkinBase skinBase = new SkinBase();
            skinBase._skinConfiguration = _skinConfiguration[_currentSkinNumber];
            int coinsChanged = skinBase.BuySkin(_playerCountCoins.GetCoinsCount());
            if (coinsChanged >= 0)
            {
                _playerCountCoins.RemoveCoinsCount(coinsChanged);
                _skinConfiguration[_currentSkinNumber].SkinBought = true;
                _skinToggle = true;
                _ballMaterial.material = _skinConfiguration[_currentSkinNumber].SkinMaterial;
                return true;
            }
            return false;
        } else
        {
            _skinToggle = true;
            _ballMaterial.material = _skinConfiguration[_currentSkinNumber].SkinMaterial;
            return true;
        }
    }
    
    public bool GetSkinToggleValidation()
    {
        return _skinToggle;
    }
    
    public Texture2D GetCurrentSkin()
    {
        return _skinConfiguration[_currentSkinNumber].SkinImage;
    }
}
