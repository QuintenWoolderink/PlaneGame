using Microsoft.Win32.SafeHandles;
using NUnit.Framework.Internal.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerControllerX : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public bool collision = false;
    public float distance = 0;
    public AudioSource audio;
    public PauseMenu pauseMenu;

    public deathScreen deathScreenObject;

    public void TriggerCollision(Collision collision)
    {
        var obstacle = collision.gameObject.GetComponent<Obstacle>();
        if (obstacle != null)
        {
            var vfx = GetComponentsInChildren<VisualEffect>();
            foreach (var particle in vfx)
            {
                particle.Play();
            }
            audio.Play();
            Debug.Log("You died!");
            Rigidbody rigidBody = GetComponentInChildren<Rigidbody>();
            rigidBody.useGravity = true;
            this.collision = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input 
        if (!Application.isMobilePlatform)
        {
            verticalInput = Input.GetAxis("Vertical");
        }

        if (collision)
        {
            deathScreenObject.Show();
        }
        else {
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            distance = transform.position.z;
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.isPaused)
            {
                pauseMenu.PlayGame();
            }

            else
            {
                pauseMenu.PauseGame();
            }
        }
    }

   
}
