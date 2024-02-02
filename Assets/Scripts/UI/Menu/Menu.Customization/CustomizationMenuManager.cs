using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class CustomizationMenuManager : MonoBehaviour
    {
        [SerializeField] GameObject _mainMenuObject;
        [SerializeField] GameObject _customizationObject;

        public void BackToMainMenu()
        {
            _mainMenuObject.SetActive(true);
            _customizationObject.SetActive(false);
        }
    }
}

