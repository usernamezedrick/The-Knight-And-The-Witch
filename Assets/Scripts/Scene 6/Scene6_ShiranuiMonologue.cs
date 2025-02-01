using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene6_ShiranuiMonologue : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6, text7, text8, text9, text10;

    public Image Shiranui;
    public Image Shiranui_Nonchalant_BIG;
    public Image Shiranui_Angry_BIG;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;

    private void Start()
    {
        ShowShiranui();
        Invoke("ShowPanels", 1.0f);
    }

    public void BtnShowNext()
    {
        if (text10.activeSelf)
            exp.BtnNextNoDelay();

        if (text9.activeSelf)
        {
            HideShiranuiAngryBig();
            HidePanels();
            Invoke("ShowShiranuiNCBig", 2.0f);
            Invoke("ShowText10", 3.0f);
            text9.gameObject.SetActive(false);
        }

        if (text8.activeSelf)
        {
            text9.gameObject.SetActive(true);
            text8.gameObject.SetActive(false);
        }

        if (text7.activeSelf)
        {
            text8.gameObject.SetActive(true);
            text7.gameObject.SetActive(false);
        }

        if (text6.activeSelf)
        {
            text7.gameObject.SetActive(true);
            text6.gameObject.SetActive(false);
        }

        if (text5.activeSelf)
        {
            text6.gameObject.SetActive(true);
            text5.gameObject.SetActive(false);
        }

        if (text4.activeSelf)
        {
            HideShiranui();
            HidePanels();
            Invoke("ShowShiranuiAngryBig", 2.0f);
            Invoke("ShowText5", 3.0f);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            text4.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            text3.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
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

    private void ShowShiranui()
    {
        fadeManager.StartFadeIn(new List<Image> { Shiranui });
    }

    private void ShowShiranuiNCBig()
    {
        fadeManager.StartFadeIn(new List<Image> { Shiranui_Nonchalant_BIG });
    }

    private void ShowShiranuiAngryBig()
    {
        fadeManager.StartFadeIn(new List<Image> { Shiranui_Angry_BIG });
    }

    private void HideShiranui()
    {
        fadeManager.StartFadeOut(new List<Image> { Shiranui });
    }

    private void HideShiranuiAngryBig()
    {
        fadeManager.StartFadeOut(new List<Image> { Shiranui_Angry_BIG });
    }

    private void ShowText5()
    {
        ShowPanels();
        text5.gameObject.SetActive(true);
    }

    private void ShowText10()
    {
        ShowPanels();
        text10.gameObject.SetActive(true);
    }
}
