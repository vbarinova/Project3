using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemy_3D : MonoBehaviour {

    public GameObject m_BulletPrefab;
    public GameObject m_player;
    public Transform playerLook;
    public AudioClip shootSound;

    private float m_Speed = 15f;

    private bool canShoot = true;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (EnemyCanShoot_3D.check())
        {
            lookPlayer();

            if(canShoot)
            {
                Shoot();
            }
          
        }

    }

    private void Shoot()
    {
        source.PlayOneShot(shootSound, .02f);
        Instantiate(m_BulletPrefab, transform.position, transform.rotation);
         canShoot = false;
         Invoke("ResetShoot", 1f);

    }

    private void lookPlayer()
    {

        //var dir = transform.position - m_player.transform.position;
        //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.up);
        //var dir = transform.position - m_player.transform.position;
        //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, angle, 0f);

        //var lookPos = transform.position 0m_player.transform.position;
        //lookPos.x = 0;
        //var rotation = Quaternion.LookRotation(lookPos);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, m_Speed * Time.deltaTime);


        playerLook = m_player.transform;
        transform.LookAt(playerLook);
    }

    /*
    private void OnTriggerStay2D(Collider2D trig)
    {
        //playerLook = m_player.transform;
        var dir = transform.position - m_player.transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);

        //transform.LookAt (playerLook);

        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("Enemy within range, shoot!");
            Shoot();
        }

    }*/

    private void ResetShoot()
    {
        canShoot = true;
    }
}
