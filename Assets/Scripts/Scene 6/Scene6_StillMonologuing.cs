using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene6_StillMonologuing : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4, text5;

    public Image ArtSmiling;
    public Image ArtSmiling_Big;
    public Image LightEffect;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;


    private void Start()
    {
        Invoke("ShowArtSmiling", 1.0f);
        Invoke("ShowLightEffect", 1.0f);
        Invoke("ShowTextPanel", 2.0f);
    }

    public void BtnShowNext()
    {
        if (text5.activeSelf)
        {
            text5.gameObject.SetActive(false);
            exp.BtnNextNoDelay();
        }

        if (text4.activeSelf)
        {
            text5.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            text4.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            HideNamePanel();
            text3.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            HideTextPanel();
            text1.gameObject.SetActive(false);
            HideArtSmiling();
            HideLightEffect();
            Invoke("InvokeText2", 1.0f);
        }    
    }

    private void ShowArtSmiling()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtSmiling });
    }

    private void ShowLightEffect()
    {
        fadeManager.StartFadeIn(new List<Image> { LightEffect });
    }

    private void ShowArtSmiling_Big()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtSmiling_Big });
    }

    private void HideArtSmiling()
    {
        fadeManager.StartFadeOut(new List<Image> { ArtSmiling });
    }

    private void HideLightEffect()
    {
        fadeManager.StartFadeOut(new List<Image> { LightEffect });
    }

    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
    }

    private void ShowNamePanel()
    {
        namePanel.gameObject.SetActive(true);
    }

    private void HideTextPanel()
    {
        textPanel.gameObject.SetActive(false);
    }

    private void HideNamePanel()
    {
        namePanel.gameObject.SetActive(false);
    }

    private void InvokeText2()
    {
        text2.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
    }
}
