using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public static int s_PlayerHealth;
    public Canvas GameUI_Death;
    public Text HealthText;

	// Use this for initialization
	void Start () {
        s_PlayerHealth = 5;
        HealthText.text = "Health: " + s_PlayerHealth.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (s_PlayerHealth <= 0 && Time.timeScale == 1f)
        {
            gameObject.SetActive(false);
            GameUI_Death.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Bullet_3D.s_PlayerHit)
        {
            HealthText.text = "Health: " + s_PlayerHealth.ToString();
            Bullet_3D.s_PlayerHit = false;
        }
	}

}
