using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

	public float m_Speed = 5.0f;

	public float amountOfRotate = 90;
	//private Rigidbody2D m_rigidbody;



	// Use this for initialization
	void Awake () {

		//m_rigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement ();

    }


    private void Movement()
	{
		// TODO: Replace GetKey() with GetAxis()
		// W forward
		if (Input.GetKey(KeyCode.W))
			MoveFoward();
		// S backwards
		if (Input.GetKey(KeyCode.S))
			MoveBackward();
		// Left arrow rotate left
		if (Input.GetKeyDown ("right"))
			Rotate (-amountOfRotate);
		// Right arrow rotate right
		if (Input.GetKeyDown ("left"))
			Rotate (amountOfRotate);
	}

	private void Rotate(float amount) {
		// Rotate a set amount

		transform.Rotate (new Vector3(0, 0, amount * m_Speed * Time.deltaTime));
	}

	private void MoveFoward() {
		transform.position += transform.up * Time.deltaTime * m_Speed;
	}

	private void MoveBackward() {
		transform.position -= transform.up * Time.deltaTime * m_Speed;
	}



}
