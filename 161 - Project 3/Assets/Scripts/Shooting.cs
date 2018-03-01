using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject m_BulletPrefab;

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
			Instantiate(m_BulletPrefab, transform.position, transform.rotation);
            canShoot = false;
        }
        else if (!canShoot && !Input.anyKey)
        {
            Debug.Log("Reload!");
            canShoot = true;
        }
    }
}
