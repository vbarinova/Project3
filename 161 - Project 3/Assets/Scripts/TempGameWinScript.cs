using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGameWinScript : MonoBehaviour {

    private void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("YOU WON THE GAME YAY!");
        }
    }
}
