using UnityEngine;

namespace UnityTask.BasketballProject
{
    public class SettingsMenuManager : MonoBehaviour
    {

        [SerializeField] GameObject _mainMenuObject;
        [SerializeField] GameObject _settingsObject;

        private void Awake()
        {
            return;
        }

        public void BackToMainMenu()
        {
            _mainMenuObject.SetActive(true);
            _settingsObject.SetActive(false);
        }

        public void ApplyChanges()
        {

        }
    }
}

