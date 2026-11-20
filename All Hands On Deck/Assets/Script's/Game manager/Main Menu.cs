using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool paused = false;
    void Start()
    {
        Time.timeScale = 1;

        if (SceneManager.GetActiveScene().buildIndex != 0)
        {

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (paused)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                Time.timeScale = 0;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                Time.timeScale = 1;
            }

        }
    }
    public void LoadLevel(int levelID)
    {
        if (levelID > SceneManager.sceneCount)
            Debug.Log("Scene ID too high: " + levelID);
        else
            SceneManager.LoadScene(levelID);
    }

    public void MainMenu()
    {
        LoadLevel(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LvL1()
    {
        LoadLevel(1);
    }


}