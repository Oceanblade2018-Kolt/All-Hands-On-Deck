using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject container;
    public bool Paused = false;
    void Update()
    {
        if (Paused)
        {
            container.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnPause()
    {
        Paused = true;
    }
    

    public void Resume()
    {
        Paused = false;
        container.SetActive(false);
        Time.timeScale = 1;
    }
}
