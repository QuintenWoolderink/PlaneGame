using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public GameObject player;
    public TMP_Text distanceText;

    void Start()
    {
        
    }

    
    void Update()
    {

        int distance = Mathf.FloorToInt(player.GetComponent<PlayerControllerX>().distance);
        distanceText.text = distance.ToString();
    }
}
