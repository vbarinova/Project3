using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {

	public GameObject ShardsLeftUI;
	public static int numShards;

	// Use this for initialization
	void Start () {
        numShards = 0;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

		ShardsLeftUI.gameObject.GetComponent<Text>().text = ("Shards: " + (10 - numShards));
		
	}

	public static void collectedShard() {
		++numShards;
	}
}
