using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoControl : MonoBehaviour {

    public VideoPlayer video;
	// Use this for initialization
	void Awake () {

    }
	
	// Update is called once per frame
	void Update () {
		if (!video.isPlaying)
        {
            SceneManager.LoadScene(1);
        }
	}
}
