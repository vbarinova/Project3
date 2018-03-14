using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour {

    private int maxHeartAmount = 4;
    public int startHearts = 4;
    public int curHealth;
    private int maxHealth;
    private int healthPerHeart = 2;

    public Image[] healthImages;
    public Sprite[] healthSprites;

	// Use this for initialization
	void Start () {
        curHealth = startHearts * healthPerHeart;
        maxHealth = curHealth;
        UpdateHearts();
    }
	
	// Update is called once per frame
	void Update () {
        curHealth = PlayerHealth.s_PlayerHealth;
        UpdateHearts();
		
	}

    private void UpdateHearts()
    {
        bool empty = false;
        int i = 0;

        foreach (Image image in healthImages)
        {
            if (empty)
            {
                // if empty, put an empty heart
                image.sprite = healthSprites[0];
            }
            else
            {
                i++;

                if (curHealth >= i * healthPerHeart)
                {
                    image.sprite = healthSprites [ healthSprites.Length - 1];
                }
                else
                {
                    int currentHeartHealth = (int)(healthPerHeart - (healthPerHeart * i - curHealth));
                    int healthPerImage = healthPerHeart / (healthSprites.Length - 1);
                    int imageIndex = currentHeartHealth / healthPerImage;

                    image.sprite = healthSprites[imageIndex];
                    empty = true;
                }
            }
        }
    }
}
