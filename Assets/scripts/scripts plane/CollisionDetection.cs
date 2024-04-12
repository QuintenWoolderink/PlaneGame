using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private PlayerControllerX playerController;
    private void Start()
    {
        playerController = GetComponentInParent<PlayerControllerX>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerController.TriggerCollision(collision);
       
    }
}
