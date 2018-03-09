using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_3D : MonoBehaviour {

    private void OnTriggerEnter(Collider trig)
    {
        // Debug.Log("Touch the end of the level!");
        if (trig.gameObject.tag == "Player")
        {
            PlayerMovement.collected_coin = true;
            Debug.Log("+1 to collected peices, yay");
            DisplayUI.collectedShard();
            Destroy(gameObject);
        }

    }
}
