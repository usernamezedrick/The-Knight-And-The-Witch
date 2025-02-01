using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene6_ShiranuiContinue : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6, text7, text8, text9;
    public GameObject KnifeContainer;
    public GameObject StabContainer;
    public Button Knife;

    public Image KitchenBackground;

    public ExplorationNavigation exp;

    public Color targetColor, targetColor1, targetColor2, targetColor3; // The target color you want to transition to
    public float transitionDuration = 1f; // Duration of the transition

    private Coroutine colorTransitionCoroutine;

    public void BtnShowNext()
    {
        HidePanels();

        if (text9.activeSelf)
            exp.BtnNextNoDelay();

        if (text8.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            text9.gameObject.SetActive(true);
            text8.gameObject.SetActive(false);
        }

        if (text7.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            text8.gameObject.SetActive(true);
            text7.gameObject.SetActive(false);
        }

        if (text6.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            text7.gameObject.SetActive(true);
            text6.gameObject.SetActive(false);
        }

        if (text5.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            ChangeKitchenColor3();
            text6.gameObject.SetActive(true);
            text5.gameObject.SetActive(false);
        }

        if (text4.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            ChangeKitchenColor2();
            text5.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            textPanel.gameObject.SetActive(true);
            ChangeKitchenColor1();
            text4.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
            StabContainer.gameObject.SetActive(true);
            Invoke("ChangeKitchenColor", 6.3f);
            Invoke("HideStabContainer", 7f);
            Invoke("ShowText3", 7f);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            KnifeContainer.gameObject.SetActive(true);
            Knife.interactable = true;
        }
            
    }

    private void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
    }

    private void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
    }

    public void GrabKnife()
    {
        Knife.gameObject.SetActive(false);
        KnifeContainer.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(true);
        text2.gameObject.SetActive(true);
    }

    private void HideStabContainer()
    {
        StabContainer.gameObject.SetActive(false);
    }

    private void ChangeKitchenColor()
    {
        // Restart the color transition coroutine if it's already running
        if (colorTransitionCoroutine != null)
        {
            StopCoroutine(colorTransitionCoroutine);
        }
        colorTransitionCoroutine = StartCoroutine(TransitionColor());
    }
    private void ChangeKitchenColor1()
    {
        // Restart the color transition coroutine if it's already running
        if (colorTransitionCoroutine != null)
        {
            StopCoroutine(colorTransitionCoroutine);
        }
        colorTransitionCoroutine = StartCoroutine(TransitionColor1());
    }
    private void ChangeKitchenColor2()
    {
        // Restart the color transition coroutine if it's already running
        if (colorTransitionCoroutine != null)
        {
            StopCoroutine(colorTransitionCoroutine);
        }
        colorTransitionCoroutine = StartCoroutine(TransitionColor2());
    }
    private void ChangeKitchenColor3()
    {
        // Restart the color transition coroutine if it's already running
        if (colorTransitionCoroutine != null)
        {
            StopCoroutine(colorTransitionCoroutine);
        }
        colorTransitionCoroutine = StartCoroutine(TransitionColor3());
    }

    private IEnumerator TransitionColor()
    {
        Color startColor = KitchenBackground.color;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            // Calculate the interpolation parameter based on the elapsed time
            float t = elapsedTime / transitionDuration;

            // Interpolate between the start color and the target color
            KitchenBackground.color = Color.Lerp(startColor, targetColor, t);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the end of the frame before continuing
            yield return null;
        }

        // Ensure the target color is reached precisely
        KitchenBackground.color = targetColor;
    }

    private IEnumerator TransitionColor1()
    {
        Color startColor = KitchenBackground.color;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            // Calculate the interpolation parameter based on the elapsed time
            float t = elapsedTime / transitionDuration;

            // Interpolate between the start color and the target color
            KitchenBackground.color = Color.Lerp(startColor, targetColor1, t);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the end of the frame before continuing
            yield return null;
        }

        // Ensure the target color is reached precisely
        KitchenBackground.color = targetColor1;
    }

    private IEnumerator TransitionColor2()
    {
        Color startColor = KitchenBackground.color;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            // Calculate the interpolation parameter based on the elapsed time
            float t = elapsedTime / transitionDuration;

            // Interpolate between the start color and the target color
            KitchenBackground.color = Color.Lerp(startColor, targetColor2, t);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the end of the frame before continuing
            yield return null;
        }

        // Ensure the target color is reached precisely
        KitchenBackground.color = targetColor2;
    }

    private IEnumerator TransitionColor3()
    {
        Color startColor = KitchenBackground.color;
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            // Calculate the interpolation parameter based on the elapsed time
            float t = elapsedTime / transitionDuration;

            // Interpolate between the start color and the target color
            KitchenBackground.color = Color.Lerp(startColor, targetColor3, t);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the end of the frame before continuing
            yield return null;
        }

        // Ensure the target color is reached precisely
        KitchenBackground.color = targetColor3;
    }

    private void ShowText3()
    {
        ShowPanels();
        text3.gameObject.SetActive(true);
    }
}
