﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet_3D : MonoBehaviour
{

    public float m_Speed = 15f;

    private Rigidbody m_Rigidbody;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        Invoke("DestorySelf", 2.0f); // Invoke calls a function after an alotted time
    }

    private void FixedUpdate()
    {
        //transform.position += transform.forward * m_Speed * Time.deltaTime;
        m_Rigidbody.MovePosition(m_Rigidbody.position + (transform.forward) * m_Speed * Time.deltaTime);
    }

    private void DestorySelf()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider trig)
    {

        if (trig.gameObject.tag == "Enemy")
        {
            Debug.Log("Stationary ENEMY HIT");
            DestorySelf();
        }
        if (trig.gameObject.tag == "BossEnemy")
        {
            Debug.Log("Stall Boss enemy");
            DestorySelf();
        }
        if (trig.gameObject.tag == "Wall")
        {
            DestorySelf();
        }

    }

}
