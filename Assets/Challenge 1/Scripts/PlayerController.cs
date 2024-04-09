using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 25f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where the imputs are stored
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vihicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // turn the vehicle (stering)
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
       
    }
}