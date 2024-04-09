using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource backgroundSound;

    public void playThisSoundEffect()
    {
        backgroundSound.Play();
    }

}
