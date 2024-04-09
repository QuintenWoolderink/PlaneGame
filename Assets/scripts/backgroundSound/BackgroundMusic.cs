using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource backgroundSound;

    void Start()
    {

    }
    void Update()
    {
        
    }

    public void playThisSoundEffect()
    {
        backgroundSound.Play();
    }

}
