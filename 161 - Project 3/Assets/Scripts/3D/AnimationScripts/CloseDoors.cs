using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CloseDoors : MonoBehaviour {

    private float m_speed = 3f;
    public float moveDirection;

    // Use this for initialization
    void Start()
    {

        // Animate initiall movement of player so it's like they are walking onto the screen
        Invoke("closeDoors", 2.2f);

    }

    private void closeDoors()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(moveDirection, 0, 0) * m_speed;
        Invoke("stopAnim", 2.0f);
    }

    private void stopAnim()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
