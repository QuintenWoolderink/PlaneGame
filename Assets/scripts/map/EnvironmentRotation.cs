using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentRotation : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = FindAnyObjectByType<PlayerControllerX>().gameObject;
        }
        transform.position = player.transform.position;
        transform.localEulerAngles += new Vector3(0, RotationSpeed, 0);
    }
}