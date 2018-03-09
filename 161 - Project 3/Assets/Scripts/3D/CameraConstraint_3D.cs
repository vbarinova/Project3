using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConstraint_3D : MonoBehaviour {

    public float xMax; // stop camera at certain points
    public float xMin;
    public float zMax;
    public float zMin;

    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {  // Calls at the end of an update
       // Clamps the camera within the min and max positions
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float z = Mathf.Clamp(player.transform.position.z, zMin, zMax);

        // Camera follows the player around up until the max and min values
        gameObject.transform.position = new Vector3(x, gameObject.transform.position.y, z); // dont wanna change the z, cuz its 2d

    }
}
