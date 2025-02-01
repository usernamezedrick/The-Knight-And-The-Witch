using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene7_Rooftop : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4, text5, text6, text7, text8, text9;
    public GameObject text10Result1, text10Result2, text10Result3, text10Result4, text10Result5, text10Result6;
    public GameObject text11Result1, text11Result2, text11Result3, text11Result4, text11Result5, text11Result6, text11Result7;
    public GameObject text12Result1, text12Result2, text12Result3, text12Result4, text12Result5, text12Result6, text12Result7;
    public GameObject ListOfChoices;

    public Image Art, ShiranuiSmileCenter, ShiranuiSmile;

    public TextMeshProUGUI characterName;

    public FadeManager fadeManager;

    public void ShowBtnNext()
    {
        if (text12Result7.activeSelf)
        {
            LoadScene();
        }

        if (text12Result6.activeSelf)
        {
            text12Result6.gameObject.SetActive(false);
            text12Result7.gameObject.SetActive(true);
        }

        if (text12Result5.activeSelf)
        {
            text12Result5.gameObject.SetActive(false);
            text12Result6.gameObject.SetActive(true);
        }

        if (text12Result4.activeSelf)
        {
            text12Result4.gameObject.SetActive(false);
            text12Result5.gameObject.SetActive(true);
        }

        if (text12Result3.activeSelf)
        {
            HideNamePanel();
            text12Result3.gameObject.SetActive(false);
            text12Result4.gameObject.SetActive(true);
        }

        if (text12Result2.activeSelf)
        {
            characterName.text = "Shiranui";
            text12Result2.gameObject.SetActive(false);
            text12Result3.gameObject.SetActive(true);
        }

        if (text12Result1.activeSelf)
        {
            text12Result1.gameObject.SetActive(false);
            text12Result2.gameObject.SetActive(true);
        }

        if (text11Result7.activeSelf)
        {
            LoadScene();
        }

        if (text11Result6.activeSelf)
        {
            HideNamePanel();
            text11Result6.gameObject.SetActive(false);
            text11Result7.gameObject.SetActive(true);
        }

        if (text11Result5.activeSelf)
        {
            text11Result5.gameObject.SetActive(false);
            text11Result6.gameObject.SetActive(true);
            characterName.text = "Shiranui";
        }

        if (text11Result4.activeSelf)
        {
            text11Result4.gameObject.SetActive(false);
            text11Result5.gameObject.SetActive(true);
        }

        if (text11Result3.activeSelf)
        {
            text11Result3.gameObject.SetActive(false);
            text11Result4.gameObject.SetActive(true);
            characterName.text = "Art";
        }

        if (text11Result2.activeSelf)
        {
            ShowNamePanel();
            text11Result2.gameObject.SetActive(false);
            text11Result3.gameObject.SetActive(true);
            characterName.text = "Shiranui";
        }

        if (text11Result1.activeSelf)
        {
            HideNamePanel();
            text11Result1.gameObject.SetActive(false);
            text11Result2.gameObject.SetActive(true);
        }

        if (text10Result6.activeSelf)
        {
            LoadScene();
        }

        if (text10Result5.activeSelf)
        {
            text10Result5.gameObject.SetActive(false);
            text10Result6.gameObject.SetActive(true);
        }

        if (text10Result4.activeSelf)
        {
            text10Result4.gameObject.SetActive(false);
            text10Result5.gameObject.SetActive(true);
        }

        if (text10Result3.activeSelf)
        {
            text10Result3.gameObject.SetActive(false);
            text10Result4.gameObject.SetActive(true);
        }

        if (text10Result2.activeSelf)
        {
            HideNamePanel();
            text10Result2.gameObject.SetActive(false);
            text10Result3.gameObject.SetActive(true);
        }

        if (text10Result1.activeSelf)
        {
            text10Result1.gameObject.SetActive(false);
            text10Result2.gameObject.SetActive(true);
        }

        if (text9.activeSelf)
        {
            FadeOutShiranuiSmileCenter();
            Invoke("ShowChoices", 1.0f);
        }

        if (text8.activeSelf)
        {
            HideNamePanel();
            text8.gameObject.SetActive(false);
            text9.gameObject.SetActive(true);
        }

        if (text7.activeSelf)
        {
            HideTextPanel();
            HideNamePanel();
            text7.gameObject.SetActive(false);
            FadeOutArt();
            FadeOutShiranuiSmile();
            Invoke("FadeInShiranuiSmileCenter", 1.0f);
            Invoke("InvokeText8", 1.0f);
        }

        if (text6.activeSelf)
        {
            HideTextPanel();
            HideNamePanel();
            text6.gameObject.SetActive(false);
            FadeInShiranuiSmile();
            Invoke("InvokeText7", 1.0f);
        }

        if (text5.activeSelf)
        {
            HideTextPanel();
            HideNamePanel();
            text5.gameObject.SetActive(false);
            FadeOutShiranuiSmileCenter();
            Invoke("FadeInArt", 1.0f);
            Invoke("InvokeText6", 2.0f);
        }

        if (text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
            text5.gameObject.SetActive(true);
        }

        if (text3.activeSelf)
        {
            HideNamePanel();
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }

        if (text2.activeSelf)
        {
            HideNamePanel();
            HideTextPanel();
            text2.gameObject.SetActive(false);
            FadeInShiranuiSmileCenter();
            Invoke("InvokeText3", 1.0f);
        }

        if (text1.activeSelf)
        {
            ShowNamePanel();

            text2.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
        }
    }
    private void HideTextPanel()
    {
        namePanel.gameObject.SetActive(false);
    }

    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
    }

    private void HideNamePanel()
    {
        namePanel.gameObject.SetActive(false);
    }

    private void ShowNamePanel()
    {
        namePanel.gameObject.SetActive(true);
    }

    private void FadeInShiranuiSmileCenter()
    {
        fadeManager.StartFadeIn(new List<Image> { ShiranuiSmileCenter });
    }

    private void FadeInShiranuiSmile()
    {
        fadeManager.StartFadeIn(new List<Image> { ShiranuiSmile });
    }

    private void FadeInArt()
    {
        fadeManager.StartFadeIn(new List<Image> { Art });
    }

    private void FadeOutShiranuiSmileCenter()
    {
        fadeManager.StartFadeOut(new List<Image> { ShiranuiSmileCenter });
    }
    private void FadeOutShiranuiSmile()
    {
        fadeManager.StartFadeOut(new List<Image> { ShiranuiSmile });
    }

    private void FadeOutArt()
    {
        fadeManager.StartFadeOut(new List<Image> { Art });
    }

    private void InvokeText3()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Shiranui";
        text3.gameObject.SetActive(true);
    }

    private void InvokeText6()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Art";
        text6.gameObject.SetActive(true);
    }
    private void InvokeText7()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Shiranui";
        text7.gameObject.SetActive(true);
    }
    private void InvokeText8()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Shiranui";
        text8.gameObject.SetActive(true);
    }

    private void ShowChoices()
    {
        ListOfChoices.gameObject.SetActive(true);
    }

    public void DisplayChoice1Result()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Art";
        ListOfChoices.gameObject.SetActive(false);
        text9.gameObject.SetActive(false);
        text10Result1.gameObject.SetActive(true);
    }

    public void DisplayChoice2Result()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Art";
        ListOfChoices.gameObject.SetActive(false);
        text9.gameObject.SetActive(false);
        text11Result1.gameObject.SetActive(true);
    }

    public void DisplayChoice3Result()
    {
        ShowTextPanel();
        ShowNamePanel();
        characterName.text = "Art";
        ListOfChoices.gameObject.SetActive(false);
        text9.gameObject.SetActive(false);
        text12Result1.gameObject.SetActive(true);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}
