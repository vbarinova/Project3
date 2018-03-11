using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    private int enemyHealth = 1;

    private void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Bullet")
        {
            --enemyHealth;
        }
    }
}
