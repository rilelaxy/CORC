using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlescreen : MonoBehaviour
{   
    public GameObject ControlMenuPanel;

    void Start()
    {
        ControlMenuPanel.SetActive(false);
    }

    public void OnControls()
    {
        ControlMenuPanel.SetActive(true);
    }

    public void OnBack()
    {
        ControlMenuPanel.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
