using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Transform spawnPosition;
    public PauseMenu pauseMenu;
    public PlayerControllerX playerController;


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
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        var planeModel = playerController.transform.GetChild(0);
        playerController.transform.position = spawnPosition.position;
        playerController.transform.rotation = spawnPosition.rotation;
        planeModel.transform.position = Vector3.zero;
        planeModel.transform.rotation = Quaternion.identity;

        playerController.collision = false;
        Rigidbody rb = playerController.GetComponentInChildren<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        playerController.verticalInput = 0;
        playerController.transform.rotation = Quaternion.identity;
    }
}