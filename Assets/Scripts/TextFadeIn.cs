using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    public float fadeInDuration = 1f; // Duration of fade-in for each text
    public float delayBetweenFades = 0.5f; // Delay between each text's fade-in
    public float delayBeforeFadeOut = 2f; // Delay before all text fade out
    public float fadeOutDuration = 1f; // Duration of fade-out for all text
    public TextMeshProUGUI[] texts;

    private Coroutine currentCoroutine;

    void Start()
    {
        StartFade();
    }

    void StartFade()
    {
        currentCoroutine = StartCoroutine(FadeInTexts());
    }

    IEnumerator FadeInTexts()
    {
        foreach (TextMeshProUGUI text in texts)
        {
            yield return FadeText(text, 0f, 1f, fadeInDuration);
            yield return new WaitForSeconds(delayBetweenFades);
        }

        yield return new WaitForSeconds(delayBeforeFadeOut);
    }

    IEnumerator FadeText(TextMeshProUGUI text, float startAlpha, float targetAlpha, float duration)
    {
        float elapsedTime = 0f;
        Color color = text.color;
        color.a = startAlpha;
        while (elapsedTime < duration)
        {
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
            color.a = alpha;
            text.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        color.a = targetAlpha;
        text.color = color;
    }
}
