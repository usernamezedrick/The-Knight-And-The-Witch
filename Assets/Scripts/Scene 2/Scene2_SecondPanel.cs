using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scene2_SecondPanel : MonoBehaviour
{
    public GameObject dialoguePanel; //The next Dialogue Panel is referenced here
    public GameObject thisPanel; //Current Panel is referenced here
    public GameObject text1, text2, text3, text5Yes, text5No, text6Prepared; //Text Dialogues are referenced here
    public GameObject textPanel;
    public GameObject characterNamePanel;
    public GameObject characterContainer;
    public GameObject DownArrow;
    public TextMeshProUGUI CharacterName; //Character Name Text is referenced here
    public Animator animator;
    public FadeManager fadeManager; //The FadeManager script is referenced here
    public string animationClip;

    [Header("Image Elements")]
    public Image ArtS;
    public Image ArtNC; //Images of Characters is referenced here

    public TextMeshProUGUI OriginalString1;

    [Header("Game Over Scene")]
    public GameObject SleepEnding;

    private void Start()
    {
        CharacterName.text = "Art";
        Invoke("InvokeStartFadeInArtSad", 0f);
    }

    public void BtnShowNext()
    {
        if (text6Prepared.activeSelf)
        {
            text6Prepared.SetActive(false);
            DownArrow.SetActive(true);
            HidePanels();
        }

        if (text5Yes.activeSelf)
        {
            HidePanels();
            text5Yes.SetActive(false);
            thisPanel.SetActive(false);
            SleepEnding.SetActive(true);
        }

        if (text5No.activeSelf)
        {
            HidePanels();
            text5No.SetActive(false);
            DownArrow.SetActive(true);
        }

        if (text3.activeSelf)
        {
            Invoke("InvokeStartFadeOutArtNC", 1.0f);
            HidePanels();
            text3.SetActive(false);
            DownArrow.SetActive(true);
        }

        if (text2.activeSelf)
        {
            Invoke("ShowText3", 0.0f);
        }

        if (text1.activeSelf)
        {
            Invoke("ShowText2", 0.0f);
        }
    }

    private void ShowText3()
    {
        text2.SetActive(false);
        text3.SetActive(true);
        ArtS.gameObject.SetActive(false);
        ArtNC.gameObject.SetActive(true);
    }

    private void HidePanels()
    {
        characterNamePanel.SetActive(false);
        textPanel.SetActive(false);
        characterContainer.SetActive(false);
    }

    private void ShowText2()
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }

    private void InvokeStartFadeInArtSad()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtS });
    }

    private void InvokeStartFadeOutArtNC()
    {
        fadeManager.StartFadeOut(new List<Image> { ArtNC });
    }

    public void onBedPressed()
    {
        Debug.Log("Bed is pressed");
    }
}
