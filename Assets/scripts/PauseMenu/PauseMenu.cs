using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;

    
    

    public void Hide()
    {

        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
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