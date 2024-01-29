using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTask.BasketballProject
{
    public class Loading : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene("Main");
        }
    }
}

