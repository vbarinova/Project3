using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCanShoot_3D : MonoBehaviour {

   // public static EnemyCanShoot_3D enemyCanShoot;

    public static bool canShoot = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider trig)
    {
        
        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("Player within range, shoot!");
            canShoot = true;
        }
    }

    private void OnTriggerExit(Collider trig)
    {

        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("Player left");
            canShoot = false;
        }
    }


    public static bool check()
    {
        return canShoot;
    }
}
