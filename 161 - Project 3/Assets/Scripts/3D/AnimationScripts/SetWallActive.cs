using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWallActive : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        Invoke("reActivate", 2.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void reActivate()
    {
        gameObject.SetActive(true);
    }
}
