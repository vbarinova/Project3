using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {

	public static ButtonSound instance = null;
	//public static ButtonSound buttonSound;
	//public AudioClip buttonClick;

	private AudioSource source;

	// Use this for initialization
	void Awake () {
            source = GetComponent<AudioSource> ();
			instance = this;
			DontDestroyOnLoad(gameObject);
	
	}
	

	public void Play() {
        Debug.Log("Button sound plays!");
		source.PlayOneShot (source.clip, 1f);
	}
}
