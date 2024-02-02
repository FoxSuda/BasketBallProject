using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTask.BasketballProject
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenuObject;
        [SerializeField] private GameObject _settingsObject;
        [SerializeField] private GameObject _customizationObject;

        public void StartGame()
        {
            SceneManager.LoadScene("Main");
        }

        public void OpenSettings()
        {
            _mainMenuObject.SetActive(false);
            _settingsObject.SetActive(true);
        }

        public void OpenCustomization()
        {
            _mainMenuObject.SetActive(false);
            _customizationObject.SetActive(true);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

