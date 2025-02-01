using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextRevealer : MonoBehaviour
{
    public TextMeshProUGUI text;
    private bool tapDetected = false;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartCoroutine(RevealText());
    }

    void OnEnable()
    {
        // Reset tapDetected flag
        tapDetected = false;
        StartCoroutine(RevealText());
    }

    IEnumerator RevealText()
    {
        var originalString = text.text;
        text.text = "";

        var numCharsRevealed = 0;
        while (numCharsRevealed < originalString.Length)
        {
            while (originalString[numCharsRevealed] == ' ')
                ++numCharsRevealed;

            ++numCharsRevealed;

            text.text = originalString.Substring(0, numCharsRevealed);

            // If tap detected, show the entire text and exit the loop
            if (tapDetected)
            {
                text.text = originalString;
                yield break;
            }

            yield return new WaitForSeconds(0.07f);
        }
    }
}