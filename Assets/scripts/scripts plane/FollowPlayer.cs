using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    

    void LateUpdate()
    {
        //offset camera behind the player by adding to the player's position
        transform.position = player.transform.position + (-player.transform.forward * 7) + (Vector3.up * 5);
        transform.eulerAngles = new Vector3 (transform.eulerAngles.x, player.transform.eulerAngles.y, transform.eulerAngles.z);
    }
}