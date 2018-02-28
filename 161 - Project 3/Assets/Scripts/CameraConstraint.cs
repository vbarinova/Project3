using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConstraint : MonoBehaviour {

	public float xMax; // stop camera at certain points
	public float xMin;
	public float yMax;
	public float yMin;

	private GameObject player;

	private void Awake() {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void LateUpdate () {  // Calls at the end of an update
		// Clamps the camera within the min and max positions
		float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
		float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);

		// Camera follows the player around up until the max and min values
		gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z); // dont wanna change the z, cuz its 2d

	}
}
