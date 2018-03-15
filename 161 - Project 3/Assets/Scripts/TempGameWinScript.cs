using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempGameWinScript : MonoBehaviour {

    public GameObject GameWin_UI;
    public GameObject boss;
    public GameObject currentMusic;
    public GameObject endMusic;

    public void Awake()
    {
        GameWin_UI.SetActive(false);
        endMusic.SetActive(false);
        currentMusic.SetActive(true);
    }
    private void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("YOU WON THE GAME YAY!");
            GameWin_UI.SetActive(true);
            currentMusic.SetActive(false);
            endMusic.SetActive(true);

            Destroy(boss);
            
        }
    }
}
