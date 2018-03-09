using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_3D : MonoBehaviour {

    public AudioSource coin_sound;

    public float m_Speed = 5.0f;

    public float amountOfRotate = 45;
    //private Rigidbody2D m_rigidbody;

    public static bool collected_coin = false;

    // Use this for initialization
    void Awake()
    {

        //m_rigidbody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (collected_coin)
        {
            coin_sound.Play();
            collected_coin = false;
        }
        Movement();

    }


    private void Movement()
    {
        // TODO: Replace GetKey() with GetAxis()
        // W forward
        if (Input.GetKey(KeyCode.W))
        {
            MoveFoward();
            //MovePause ();
        }
        // S backwards
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
            //MovePause ();
        }
        // Left arrow rotate left
        if (Input.GetKey("right"))
            Rotate(amountOfRotate);
        // Right arrow rotate right
        if (Input.GetKey("left"))
            Rotate(-amountOfRotate);
    }

    private void Rotate(float amount)
    {
        // Rotate a set amount

        transform.Rotate(new Vector3(0, amount * m_Speed * Time.deltaTime, 0));
    }

    private void MoveFoward()
    {
        transform.position -= transform.forward * Time.deltaTime * m_Speed;
    }

    private void MoveBackward()
    {
        transform.position += transform.forward * Time.deltaTime * m_Speed;
    }

    // Trying to make a jumpy movement like the turning
    //IEnumerator MovePause () {
    //	yield return new WaitForSeconds (1);
    //}
}
