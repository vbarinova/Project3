using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingOpenDoors : MonoBehaviour {

    public AudioClip doorOpening;
    private AudioSource source;
    private bool done = false;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (10 - DisplayUI.numShards == 0 && !done)
        {
            //reActivate();
            //gameObject.SetActive(true);

            done = true;
            Invoke("playSound", .8f);
        }
    }


    private void playSound()
    {
        source.PlayOneShot(doorOpening, .2f);
    }
}
