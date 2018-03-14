using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsScenes : MonoBehaviour {

    public GameObject SceneOne;
    public GameObject SceneTwo;

    private int changeScreen = 0;

    // Use this for initialization
    void Start () {
        SceneOne.SetActive(true);
        SceneTwo.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey("space") && changeScreen == 0)
        {
            SceneOne.SetActive(false);
            SceneTwo.SetActive(true);
            Invoke("canChange", 0.5f);
        }

        else if (Input.GetKey("space") && changeScreen >= 1)
        {
            SceneManager.LoadScene(1);
        }

    }

    private void canChange()
    {
        ++changeScreen;
        Debug.Log(changeScreen);
    }
}
