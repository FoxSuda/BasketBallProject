using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class SkinBase
    {

        public SkinConfiguration _skinConfiguration;

        public int GetSkinPrice()
        {
            return _skinConfiguration.SkinPrice;
        }
    
        public Material GetSkinMaterial()
        {
            return _skinConfiguration.SkinMaterial;
        }
    
        public Texture2D GetSkinImage()
        {
            return _skinConfiguration.SkinImage;
        }
    
        public bool GetSkinBought()
        {
            return _skinConfiguration.SkinBought;
        }

        public int BuySkin(int summ)
        {
            if (summ >= _skinConfiguration.SkinPrice && _skinConfiguration.SkinBought == false)
            {
                _skinConfiguration.SkinBought = true;
                return _skinConfiguration.SkinPrice;
            }
            return -1;
        }
    }
}

