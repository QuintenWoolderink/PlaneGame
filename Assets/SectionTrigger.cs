using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject world;
    public static int instantiateCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        var instantiatedWorld = Instantiate(world);
        instantiatedWorld.transform.position += new Vector3(0, 0, 978) * instantiateCount;
        instantiateCount++;
    }
}