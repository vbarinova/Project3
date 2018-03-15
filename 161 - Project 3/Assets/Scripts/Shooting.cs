using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject m_BulletPrefab;
    public AudioClip shootSound;

    private bool canShoot = true;
    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
        Shoot();

    }


    private void Shoot()
    {
        if (canShoot && (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Return)
            || Input.GetKey(KeyCode.Return) && Input.GetKey(KeyCode.Space)))
        {
            Debug.Log("Shots fired!");
            source.PlayOneShot(shootSound, .3f);
			Instantiate(m_BulletPrefab, transform.position, transform.rotation);
            canShoot = false;
        }
        else if (!canShoot && !(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Return)
            || Input.GetKey(KeyCode.Return) && Input.GetKey(KeyCode.Space)))
        {
            Debug.Log("Reload!");
            canShoot = true;
        }
    }
}
