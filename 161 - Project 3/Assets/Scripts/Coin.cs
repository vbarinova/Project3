using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	private float m_Speed = .8f;
	private int amount = 90;
	
	// Update is called once per frame
	void Update () {
		turn ();
	}

	private void turn() {
		transform.Rotate (new Vector3(0, amount * m_Speed * Time.deltaTime, 0));
	}

	private void OnTriggerEnter2D (Collider2D trig) {
		// Debug.Log("Touch the end of the level!");
		if (trig.gameObject.tag == "Player") {
			Debug.Log ("+1 to collected peices, yay");
			DisplayUI.collectedShard ();
			Destroy (gameObject);
		}

		}
}
