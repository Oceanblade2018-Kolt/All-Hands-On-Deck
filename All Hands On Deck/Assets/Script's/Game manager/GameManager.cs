using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TestGM : MonoBehaviour
{

    public GameObject PauseMenu;

    public TextMeshProUGUI ammount;

    public Image coin;

    public bool paused = false;

   
    void Start()
    {
        Time.timeScale = 1;

        if (SceneManager.GetActiveScene().buildIndex != 0)
        {

            //ammount = GameObject.Find("ammount").GetComponent<TextMeshProUGUI>();

            //coin = GameObject.Find("coin").GetComponent<Image>();

            //enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        }
    }
    public void LoadLevel(int levelID)
    {
        if (levelID >= SceneManager.sceneCountInBuildSettings)
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
}