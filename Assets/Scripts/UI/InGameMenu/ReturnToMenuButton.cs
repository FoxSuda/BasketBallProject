using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTask.BasketballProject
{
    public class ReturnToMenuButton : MonoBehaviour
    {
        public void ReturnToMainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}

