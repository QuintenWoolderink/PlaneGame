using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float RotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.localEulerAngles += new Vector3(0, 0, RotationSpeed);
    }
}
