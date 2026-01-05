using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        LoadAdditive("Environment");
        LoadAdditive("Props");
        LoadAdditive("Lighting");
        LoadAdditive("Audio");
    }

    void LoadAdditive(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
