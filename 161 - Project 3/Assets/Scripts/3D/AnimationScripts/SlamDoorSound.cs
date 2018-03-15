using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamDoorSound : MonoBehaviour {

    public AudioClip doorClosing;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        Invoke("playSound", 3.9f);

    }


    private void playSound()
    {
        source.PlayOneShot(doorClosing, .3f);
    }
}
