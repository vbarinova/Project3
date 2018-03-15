using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossApprocahing : MonoBehaviour {

    public CanvasGroup uiElement;
    public AudioClip displaySound;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        gameObject.SetActive(false);
        Invoke("reActivate", 10f);

    }

    private void reActivate()
    {
        gameObject.SetActive(true);
        source.PlayOneShot(displaySound, .3f);
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
