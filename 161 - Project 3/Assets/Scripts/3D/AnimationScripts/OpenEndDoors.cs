using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEndDoors : MonoBehaviour {

    private float m_speed = 3f;
    public float moveDirection;

    void Update()
    {
        if (10 - DisplayUI.numShards == 0)
        {
            Invoke("openDoors", 1f);
        }
    }

    private void openDoors()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(moveDirection, 0, 0) * m_speed;
        Invoke("stopAnim", 2.0f);
    }

    private void stopAnim()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
