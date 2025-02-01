using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.CompilerServices;

public class Scene5_SchoolSurrounding : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6, text7, text8, text9, text9_FightBack, text9_GetBeaten;
    public GameObject ChoicesList;

    public TextMeshProUGUI characterName;
    public GameObject BodyImpactThudObject;
    public AudioSource BodyImpactThud;

    public Image BulliedNPC;
    public Image BullyNPC;
    public Image ArtNonchalant;
    public Image ArtAngry;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;

    public bool FightBack = false;

    private void Start()
    {
        BodyImpactThud = GameObject.Find("Body Impact Thud").GetComponent<AudioSource>();
    }

    public void BtnShowNext()
    {
        HidePanels();

        if (text9_FightBack.activeSelf || text9_GetBeaten.activeSelf)
            exp.BtnNextNoDelay();

        if (text8.activeSelf)
        {
            HideEveryone();
            ShowPanels();
            text8.gameObject.SetActive(false);
            text9.gameObject.SetActive(true);
            Invoke("ShowChoices", 1.0f);
        }

        if (text7.activeSelf)
        {
            text7.gameObject.SetActive(false);
            ShowPanels();
            text8.gameObject.SetActive(true);
        }

        if (text6.activeSelf)
        {
            text6.gameObject.SetActive(false);
            ShowPanels();
            text7.gameObject.SetActive(true);
        }

        if (text5.activeSelf)
        {
            text5.gameObject.SetActive(false);
            ShowPanels();
            text6.gameObject.SetActive(true);
            characterName.text = "Bully";
        }

        if (text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
            HideBulliedNPC();
            Invoke("ShowArtNonchalant", 1.0f);
            Invoke("InvokeText5", 2.0f);
        }

        if (text3.activeSelf)
        {
            text3.gameObject.SetActive(false);
            ShowBullyNPC();
            Invoke("InvokeText4", 1f);
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
            ShowBulliedNPC();
            Invoke("InvokeText3", 1f);
        }

        if (text1.activeSelf)
        {
            BodyImpactThud.Play();
            text1.gameObject.SetActive(false);
            Invoke("InvokeText2", 2f);
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

    private void InvokeText2()
    {
        ShowPanels();
        text2.gameObject.SetActive(true);
    }
    private void InvokeText3()
    {
        ShowPanels();
        characterName.text = "Bullied Girl";
        text3.gameObject.SetActive(true);
    }

    private void InvokeText4()
    {
        ShowPanels();
        characterName.text = "Bully";
        text4.gameObject.SetActive(true);
    }

    private void InvokeText5()
    {
        ShowPanels();
        characterName.text = "Art";
        text5.gameObject.SetActive(true);
    }

    private void InvokeText9_FightBack()
    {
        text9_FightBack.gameObject.SetActive(true);
    }

    private void InvokeText9_GetBeaten()
    {
        text9_GetBeaten.gameObject.SetActive(true);
    }

    private void ShowBulliedNPC()
    {
        fadeManager.StartFadeIn(new List<Image> { BulliedNPC });
    }

    private void ShowBullyNPC()
    {
        fadeManager.StartFadeIn(new List<Image> { BullyNPC });
    }

    private void HideBulliedNPC()
    {
        fadeManager.StartFadeOut(new List<Image> { BulliedNPC });
    }

    private void ShowArtNonchalant()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtNonchalant });
    }

    private void ShowArtAngry()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtAngry });
    }

    private void HideEveryone()
    {
        fadeManager.StartFadeOut(new List<Image> { ArtNonchalant, BullyNPC });
    }
    private void ShowChoices()
    {
        ChoicesList.gameObject.SetActive(true);
    }

    public void Choice1Result()
    {
        ShowPanels();
        ShowArtAngry();
        ChoicesList.gameObject.SetActive(false);
        text9.gameObject.SetActive(false);
        characterName.text = "Art";
        Invoke("InvokeText9_FightBack", 1.0f);
        FightBack = true;
    }

    public void Choice2Result()
    {
        ShowPanels();
        ShowArtAngry();
        ChoicesList.gameObject.SetActive(false);
        text9.gameObject.SetActive(false);
        characterName.text = "Art";
        Invoke("InvokeText9_GetBeaten", 1.0f);
        FightBack = false;
    }
}
