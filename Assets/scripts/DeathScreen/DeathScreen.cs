using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreen : MonoBehaviour
{
    public MainMenu mainMenu;
    public GameObject screen;

    public void Replay()
    {
        Hide();
        mainMenu.ResetGame();
    }

    public void Hide()
    {
        screen.SetActive(false);
    }

    public void Show()
    {
        screen.SetActive(true);
    }

}