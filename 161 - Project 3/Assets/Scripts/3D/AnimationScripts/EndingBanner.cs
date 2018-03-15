using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingBanner : MonoBehaviour {

    public CanvasGroup uiElement;
    public AudioClip displaySound;

    private AudioSource source;
    private bool done = false;

    void Start()
    {
        //gameObject.SetActive(false);
        source = GetComponent<AudioSource>();
        uiElement.alpha = 0;

    }

    void Update()
    {
        if (10 - DisplayUI.numShards == 0 && !done)
        {
            //reActivate();
            //gameObject.SetActive(true);
            done = true;
            Invoke("reActivate", .5f);
        }
    }

    private void reActivate()
    {
        //gameObject.SetActive(true);
        source.PlayOneShot(displaySound, .3f);
        uiElement.alpha = 1;
        Invoke("deActivate", 3f);
    }

    private void deActivate()
    {
        FadeOut();
        
    }




    public void FadeOut()
    {
        StartCoroutine(FadeCanvasElement(uiElement, uiElement.alpha, 0));
    }

    public IEnumerator FadeCanvasElement(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            cg.alpha = currentValue;

            if (percentageComplete >= 1) break;

            yield return new WaitForEndOfFrame();
        }

        Debug.Log("Done Fading");
    }
}
