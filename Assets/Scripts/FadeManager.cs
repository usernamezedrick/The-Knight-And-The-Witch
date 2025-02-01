using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FadeAction
{
    FadeIn,
    FadeOut,
    FadeInAndOut,
    FadeOutAndIn
}

public class FadeManager : MonoBehaviour
{
    [Tooltip("The Fade Type.")]
    [SerializeField] private FadeAction fadeType;

    [Tooltip("the image you want to fade, assign in inspector")]
    [SerializeField] private List<Image> img;

    // fade from transparent to opaque
    IEnumerator FadeIn(Image img)
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }
    IEnumerator FadeInSilhouette(Image img)
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(0, 0, 0, i);
            yield return null;
        }
    }

    // fade from opaque to transparent
    IEnumerator FadeOut(Image img)
    {
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }

        img.color = new Color(1, 1, 1, 0);
    }

    IEnumerator FadeOutSilhouette(Image img)
    {
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(0, 0, 0, i);
            yield return null;
        }

        img.color = new Color(0, 0, 0, 0);
    }

    IEnumerator FadeInAndOut(Image img)
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }

        //Temp to Fade Out
        yield return new WaitForSeconds(1);

        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }

    IEnumerator FadeOutAndIn(Image img)
    {
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }

        //Temp to Fade In
        yield return new WaitForSeconds(1);

        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }

    public void StartFadeIn(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeIn(img));
        }
    }

    public void StartFadeInSilhouette(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeInSilhouette(img));
        }
    }

    public void StartFadeOut(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeOut(img));
        }
    }

    public void StartFadeOutSilhouette(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeOutSilhouette(img));
        }
    }

    public void StartFadeInAndOut(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeInAndOut(img));
        }
    }

    public void StartFadeOutAndIn(List<Image> images)
    {
        foreach (Image img in images)
        {
            StartCoroutine(FadeOutAndIn(img));
        }
    }
}
