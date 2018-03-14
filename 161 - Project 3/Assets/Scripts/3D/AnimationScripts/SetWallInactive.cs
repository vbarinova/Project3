using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWallInactive : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        if (10 - DisplayUI.numShards == 0)
        {
            setInactive();
        }
    }

    private void setInactive()
    {
        gameObject.SetActive(false);
    }
}
