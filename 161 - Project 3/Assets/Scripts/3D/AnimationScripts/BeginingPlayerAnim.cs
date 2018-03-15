using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginingPlayerAnim : MonoBehaviour {

    private float m_speed = 5f;

	// Use this for initialization
	void Start () {

        // Animate initiall movement of player so it's like they are walking onto the screen
        transform.position = new Vector3(101.53f, 2.97f, 58.73f);
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f) * m_speed;
        Invoke("stopAnim", 3f);
        //transform.position = new Vector3(transform.position.x, transform.position.y, 45.2f);

    }
	
	private void stopAnim()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
