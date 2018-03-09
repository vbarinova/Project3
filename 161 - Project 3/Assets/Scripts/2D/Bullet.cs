using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour {

	public float m_Speed = 15f;


	private Rigidbody m_Rigidbody;

	private void Awake()
	{
		m_Rigidbody = GetComponent<Rigidbody> ();

		Invoke ("DestorySelf", 2.0f); // Invoke calls a function after an alotted time
	}

	private void FixedUpdate()
	{
		//transform.position += transform.forward * m_Speed * Time.deltaTime;
		m_Rigidbody.MovePosition(m_Rigidbody.position + transform.up * m_Speed * Time.deltaTime);
	}

	private void DestorySelf()
	{
		Destroy (gameObject);
	}

    private void OnTriggerEnter(Collider trig)
    {

        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HIT");
        }
        if (trig.gameObject.tag == "Wall")
        {
            DestorySelf();
        }

    }

}
