using NUnit.Framework.Internal.Commands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerControllerX : MonoBehaviour
{

    public deathScreen deathScreen;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public bool collision = false;
    public VisualEffect explosion;
    public float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        if (collision)
        {
            deathScreen.Show();
        }
        else {
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            distance = transform.position.z;
            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var obstacle = collision.gameObject.GetComponent<Obstacle>();
        if (obstacle != null)
        {
            explosion.Play();
            Debug.Log("You died!");
            Rigidbody rigidBody = GetComponent<Rigidbody>();
            rigidBody.useGravity = true;

            this.collision = true;
        }
    }
}
