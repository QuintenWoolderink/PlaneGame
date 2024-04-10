using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject world;

    private void OnTriggerEnter(Collider other)
    {
        var instantiatedWorld = Instantiate(world);
        instantiatedWorld.transform.position = transform.parent.transform.position + new Vector3(0, 0, 978);
    }
}