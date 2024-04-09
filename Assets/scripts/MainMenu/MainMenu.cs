using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public Transform spawnPosition;
    public PlayerControllerX plane;
    public PauseMenu pauseMenu;


    private void Start()
    {
        pauseMenu.PauseGame();
        pauseMenu.Hide();
    }

    public void Play()
    {
        ResetGame();
        Hide();
        pauseMenu.PlayGame();
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player has Quit the Game");
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        Show();
        pauseMenu.PauseGame();
        pauseMenu.Hide();
    }

    public void Hide()
    {
        mainMenu.SetActive(false);
    }

    public void Show()
    {
        mainMenu.SetActive(true);
    }

    public void ResetGame()
    {
        plane.transform.position = spawnPosition.position;
        plane.collision = false;
        Rigidbody rb = plane.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        plane.verticalInput = 0;
        plane.transform.rotation = Quaternion.identity;
    }
}