﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

	public GameObject m_BulletPrefab;
	public GameObject m_player;
	public Transform playerLook;

	private float m_Speed = 15f;

    private bool canShoot = true;

	// Use this for initialization
	void Start () {
		m_player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	private void Shoot() {
        if (canShoot)
        {
            Instantiate(m_BulletPrefab, transform.position, transform.rotation);
            canShoot = false;
            Invoke("ResetShoot", 1f);
        }
        
	}
		

	private void OnTriggerStay2D (Collider2D trig) {
        //playerLook = m_player.transform;
        var dir = transform.position - m_player.transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle+90, Vector3.forward);

        //transform.LookAt (playerLook);

        if (trig.gameObject.tag == "Player") {
			Debug.Log ("Enemy within range, shoot!");
			Shoot ();
		}

	}

    private void ResetShoot()
    {
        canShoot = true;
    }
}
