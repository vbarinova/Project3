﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScreenControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Return)
            || Input.GetKey(KeyCode.Return) && Input.GetKey(KeyCode.Space)))
        {
            SceneManager.LoadScene(3);
        }

    }
}
