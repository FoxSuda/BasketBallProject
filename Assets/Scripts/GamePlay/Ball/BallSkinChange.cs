using UnityEngine;
using UnityTask.BasketballProject;

public class BallSkinChange : MonoBehaviour
{
    [SerializeField] private BallManager _ballManager;
    [SerializeField] private Material[] _ballMaterials;
    [SerializeField] private Texture2D[] _ballImage;

    [SerializeField] private MeshRenderer _ballMaterial;

    private bool _skinToggle = true;

    Texture _currentTexture;
    Texture _nextTexture;

    private int _currentSkinNumber = 0;

    public Texture2D MoveToNextMaterial()
    {
        _currentSkinNumber++;

        if (_currentSkinNumber == _ballMaterials.Length)
        {
            _currentSkinNumber = 0;
        }

        _currentTexture = _ballMaterial.material.mainTexture;

        _nextTexture = _ballMaterials[_currentSkinNumber].mainTexture;

        if (_currentTexture == _nextTexture)
        {
            _skinToggle = true;
        }
        else
        {
            _skinToggle = false;
        }

        return _ballImage[_currentSkinNumber];
    }
    
    public Texture2D MoveToPreviousMaterial()
    {
        _currentSkinNumber--;

        if (_currentSkinNumber == -1)
        {
            _currentSkinNumber = _ballMaterials.Length - 1;
        }

        _currentTexture = _ballMaterial.material.mainTexture;

        _nextTexture = _ballMaterials[_currentSkinNumber].mainTexture;

        if (_currentTexture == _nextTexture)
        {
            _skinToggle = true;
        }
        else
        {
            _skinToggle = false;
        }

        return _ballImage[_currentSkinNumber];
    }
    
    public void AcceptMaterialValidation()
    {
        _skinToggle = true;
        _ballMaterial.material = _ballMaterials[_currentSkinNumber];
    }
    
    public bool GetSkinToggleValidation()
    {
        return _skinToggle;
    }
    
    public Texture2D GetCurrentSkin()
    {
        return _ballImage[_currentSkinNumber];
    }
}
