using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                PlayGame();
            }

            else
            {
                PauseGame();
            }
        }
    }

    public void Hide()
    {

        pauseMenu.SetActive(false);
    }

    public void Show()
    {
        pauseMenu.SetActive(true);
    }

    public void PauseGame()
    {
        Show();
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void PlayGame()
    {
        Hide();
        Time.timeScale = 1f;
        isPaused = false;
    }

}