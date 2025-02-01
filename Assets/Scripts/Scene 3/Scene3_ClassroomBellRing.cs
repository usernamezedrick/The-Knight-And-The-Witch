using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene3_ClassroomBellRing : MonoBehaviour
{
    public GameObject namePanel;
    public TextMeshProUGUI characterName;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6;
    public GameObject transitionContainer;

    public Image YamauchiBig;
    public Image ArtShocked;
    public Image ArtNonchalant;
    public Image transitionPanel;
    public Image BlackScreen;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;

    [Header("Audio Elements")]
    public GameObject audioBellRingObject;
    public AudioSource audioBellRing;

    private void Start()
    {
        audioBellRing = GameObject.Find("Bell Ring").GetComponent<AudioSource>();

        RingBell();
        Invoke("InvokeStartFadeOutImage", 4.0f);
        Invoke("InvokeRemoveTransitionText", 7.0f);
        Invoke("InvokeStartFadeInYamauchiBig", 8.0f);
        Invoke("ShowPanels", 8.0f);
    }

    public void BtnShowNext()
    {
        if (text6.activeSelf)
        {
            InvokeStartFadeInBlackScreen();
            Invoke("LoadNewScene", 3.0f);
        }

        if (text5.activeSelf)
        {
            InvokeStartFadeOutArtNonchalant();
            InvokeStartFadeOutYamauchiBig();
            namePanel.gameObject.SetActive(false);
            text5.gameObject.SetActive(false);
            Invoke("InvokeText6", 1.0f);
        }

        if (text4.activeSelf)
        {
            ArtShocked.color = new Color(255, 255, 255, 0);
            ArtNonchalant.color = new Color(255, 255, 255, 255);
            text5.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            HidePanels();
            InvokeStartFadeInYamauchiBig();
            Invoke("InvokeText4", 1.0f);
            Invoke("ShowPanels", 1.0f);
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            HidePanels();
            characterName.text = "";
            InvokeStartFadeOutYamauchiBig();
            Invoke("MoveYamauchiToLeft", 1.0f);
            Invoke("InvokeStartFadeInArtShocked", 1.0f);
            Invoke("InvokeText3", 2.0f);
            Invoke("ShowPanels", 2.0f);
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text2.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
        }
    }

    public void RingBell()
    {
        audioBellRing.Play();
    }
    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
    }
    private void HidePanels()
    {
        textPanel.gameObject.SetActive(false);
        namePanel.gameObject.SetActive(false);
        characterName.text = "";
    }

    private void InvokeStartFadeInYamauchiBig()
    {
        fadeManager.StartFadeIn(new List<Image> { YamauchiBig });
    }

    private void InvokeStartFadeOutYamauchiBig()
    {
        fadeManager.StartFadeOut(new List<Image> { YamauchiBig });
    }
    private void InvokeStartFadeInArtShocked()
    {
        fadeManager.StartFadeIn(new List<Image> { ArtShocked });
    }
    private void InvokeStartFadeOutArtShocked()
    {
        fadeManager.StartFadeOut(new List<Image> { ArtShocked });
    }
    private void InvokeStartFadeOutArtNonchalant()
    {
        fadeManager.StartFadeOut(new List<Image> { ArtNonchalant });
    }

    private void InvokeStartFadeOutImage()
    {
        fadeManager.StartFadeOutSilhouette(new List<Image> { transitionPanel });
    }
    private void InvokeRemoveTransitionText()
    {
        transitionContainer.SetActive(false);
    }
    private void MoveYamauchiToMid()
    {
        YamauchiBig.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(110, -684);
    }

    private void MoveYamauchiToLeft()
    {
        YamauchiBig.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68, -684);
    }

    private void InvokeText3()
    {
        characterName.text = "Art";
        text3.gameObject.SetActive(true);
    }

    private void InvokeText4()
    {
        characterName.text = "Yamauchi";
        text4.gameObject.SetActive(true);
    }
    private void InvokeText6()
    {
        text6.gameObject.SetActive(true);
    }
    private void LoadNewScene()
    {
        SceneManager.LoadScene("Scene4");
    }
    private void InvokeStartFadeInBlackScreen()
    {
        fadeManager.StartFadeInSilhouette(new List<Image> { BlackScreen });
    }
}
