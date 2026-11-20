using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject Container;
    public bool pauseState = false;

    private void Update()
    {
        if (pauseState == true)
        {
            Container.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Paused()
    {
     pauseState = true;
    }

    public void ResumeButton()
    {
        pauseState = false;
        Container.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
