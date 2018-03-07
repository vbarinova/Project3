using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

	public GameObject m_BulletPrefab;
	public GameObject m_player;
	public Transform playerLook;

	private float m_Speed = 15f;


	// Use this for initialization
	void Start () {
		m_player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	private void Shoot() {
		Instantiate(m_BulletPrefab, transform.position, transform.rotation);
	}
		

	private void OnTriggerEnter2D (Collider2D trig) {
		transform.LookAt (playerLook);

		if (trig.gameObject.tag == "Player") {
			Debug.Log ("Enemy within range, shoot!");
			Shoot ();
		}

	}
}
