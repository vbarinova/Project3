using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    private bool canShoot = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Shoot();

    }


    private void Shoot()
    {
        if (canShoot && (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Slash)
            || Input.GetKey(KeyCode.Slash) && Input.GetKey(KeyCode.Space)))
        {
            Debug.Log("Shots fired!");
            canShoot = false;
        }
        else if (!canShoot && !Input.anyKey)
        {
            Debug.Log("Reload!");
            canShoot = true;
        }
    }
}
