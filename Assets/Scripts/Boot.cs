using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTask.BasketballProject
{
    public class Boot : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene("Loading");
        }
    }
}

