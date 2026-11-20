using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TestGM : MonoBehaviour
{
    //public PlayerController player;

    public GameObject PauseMenu;

    public TextMeshProUGUI coinAmmount;

    public Image coin;

    public bool paused = false;

    /*public bool enemiesGone = false; //scaning how many enimies are left
    public int enemyCount = 0;*/


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;

        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            //player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

            PauseMenu = GameObject.FindGameObjectWithTag("Pause");


            PauseMenu.SetActive(false);

            //enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (paused)
            {
                Time.timeScale = 0;

                PauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;

                PauseMenu.SetActive(false);
            }

            /*if (enemyCount <= 0)
            {
                //enemiesGone = true;
            }*/

            /* 

            If you wanted to indicate some powerup in UI text do something like this
            if (player.jumpBoostActivated)
            {
                boostText.text = "Jump Boost Activated";

                healthBar.enabled = true;


            }
            else
            {
                boostText.text = "";
                healthBar.enabled = false;
            }

            */
        }
    }

    public void Pause()
    {
        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        PauseMenu.SetActive(paused);
    }

    /*public void LoadLevel(int levelID) //modify for seed system
    {
        if (levelID >= SceneManager.sceneCountInBuildSettings)
            Debug.Log("Scene ID too high: " + levelID);
       else
            //SceneManager.LoadScene(levelID);
    }*/

    /*public void MainMenu()
    {
        LoadLevel(0);
    }*/

    public void Quit()
    {
        Application.Quit();
    }
}