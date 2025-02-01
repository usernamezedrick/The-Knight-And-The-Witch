using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_ClassroomTS : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject transitionContainer;

    public GameObject text1, text2, text3, text4, text5, text6_BlackboardChoice1, text6_BlackboardChoice2, text7_BlackboardReply1, text7_BlackboardReply2, text8, text8_TokinawaStatement, text9, text10;

    public Image transitionPanel;
    public Image Yamauchi;
    public Image YamauchiBig;
    public Image MCBrowsRaised;
    public Image MCShocked;
    public Image Tokinawa;
    public Image Blackboard;
    public Image MathProblem;
    public Image BlackScreen;

    public TextMeshProUGUI characterName;
    public TextMeshProUGUI TokinawaStatement;

    public Button Blackboard_Choice1;
    public Button Blackboard_Choice2;

    [Header("Audio Elements")]
    public GameObject audioSlidingDoorObject;
    public AudioSource audioSlidingDoor;
    public GameObject audioChatterObject;
    public AudioSource audioChatter;

    public bool Choice1 = false;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;

    private void Start()
    {
        audioSlidingDoor = GameObject.Find("Sliding Door").GetComponent<AudioSource>();
        audioChatter = GameObject.Find("Indistinct Chatter").GetComponent<AudioSource>();

        //Invokes
        Invoke("InvokeStartFadeOutImage", 2.0f);
        Invoke("InvokeRemoveTransitionText", 4.0f);
        Invoke("InvokeChatter", 2.0f);
        Invoke("InvokeSlideDoor", 6.0f);
        Invoke("InvokeStartFadeInYamauchi", 8.0f);
        Invoke("InvokeYamauchiStartingDialogue", 9.0f);
    }

    public void BtnShowNext()
    {
        if (text10.activeSelf)
        {
            InvokeStartFadeInBlackScreen();
            Invoke("InvokeNextScene", 3.0f);
        }

        if (text9.activeSelf)
        {
            InvokeStartFadeOutTokinawa();
            Invoke("InvokeStartFadeInMCShocked", 1.0f);
            characterName.text = "";
            Invoke("InvokeText10", 1.0f);
            text9.gameObject.SetActive(false);
        }

        if (text8_TokinawaStatement.activeSelf)
        {
            MoveYamauchiToLeft();
            InvokeStartFadeInYamauchiBig();
            text9.gameObject.SetActive(true);
            text8_TokinawaStatement.gameObject.SetActive(false);
            characterName.text = "Yamauchi";
        }

        if (text8.activeSelf)
        {
            if (Choice1 == true)
            {
                TokinawaStatement.text = "Sensei, I don't know!";
            }

            else if (Choice1 == false)
            {
                TokinawaStatement.text = "Sensei, this topic wasn't covered yesterday~";
            }

            characterName.text = "";
            text8.gameObject.SetActive(false);
            Invoke("InvokeTokinawaStatement", 2.0f);
            Invoke("InvokeStartFadeInTokinawa", 1.0f);
            InvokeStartFadeOutYamauchiBig();
        }

        if (text7_BlackboardReply1.activeSelf || text7_BlackboardReply2.activeSelf)
        {

            text7_BlackboardReply1.gameObject.SetActive(false);
            text7_BlackboardReply2.gameObject.SetActive(false);
            InvokeStartFadeOutMCBrowsRaised();
            InvokeStartFadeOutYamauchiBig();
            Invoke("HidePanels", 1.0f);
            Invoke("MoveYamauchiToMid", 1.0f);
            Invoke("InvokeStartFadeInYamauchiBig", 2.0f);
            Invoke("ShowPanels", 2.0f);
            Invoke("InvokeText8", 3.0f);
        }

        if (text6_BlackboardChoice2.activeSelf)
        {
            MoveYamauchiToLeft();
            InvokeStartFadeInYamauchiBig();
            characterName.text = "Yamauchi";
            text7_BlackboardReply2.gameObject.SetActive(true);
            text6_BlackboardChoice2.gameObject.SetActive(false);
        }

        if (text6_BlackboardChoice1.activeSelf)
        {
            MoveYamauchiToLeft();
            InvokeStartFadeInYamauchiBig();
            characterName.text = "Yamauchi";
            text7_BlackboardReply1.gameObject.SetActive(true);
            text6_BlackboardChoice1.gameObject.SetActive(false);
        }

        if (text5.activeSelf)
        {
            InvokeStartFadeOutBlackboard();
            InvokeStartFadeOutMathProblem();
            Invoke("InvokeShowBlackboardChoices", 1.0f);
            HidePanels();
        }

        if (text4.activeSelf)
        {
            InvokeStartFadeOutYamauchi();
            Invoke("InvokeStartFadeInBlackboard", 1.0f);
            Invoke("InvokeStartFadeInMathProblem", 1.0f);
            namePanel.gameObject.SetActive(false);
            Invoke("InvokeText5", 2.0f);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            InvokeStartFadeInYamauchi();
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
            ShowPanels();
            characterName.text = "Yamauchi";
        }

        if (text2.activeSelf)
        {
            InvokeStartFadeOutYamauchiBig();
            text3.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            InvokeStartFadeOutYamauchi();
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
            Invoke("InvokeStartFadeInYamauchiBig", 1.0f);
            namePanel.gameObject.SetActive(false);
        }
    }

    private void InvokeStartFadeOutImage()
    {
        fadeManager.StartFadeOutSilhouette(new List<Image> { transitionPanel });
    }
    private void InvokeRemoveTransitionText()
    {
        transitionContainer.SetActive(false);
    }
    private void InvokeChatter()
    {
        audioChatter.Play();
    }
    private void InvokeSlideDoor()
    {
        audioSlidingDoor.Play();
    }
    private void InvokeStartFadeInYamauchi()
    {
        fadeManager.StartFadeIn(new List<Image> { Yamauchi });
    }
    private void InvokeStartFadeInYamauchiBig()
    {
        fadeManager.StartFadeIn(new List<Image> { YamauchiBig });
    }

    private void InvokeStartFadeOutYamauchi()
    {
        fadeManager.StartFadeOut(new List<Image> { Yamauchi });
    }

    private void InvokeStartFadeOutYamauchiBig()
    {
        fadeManager.StartFadeOut(new List<Image> { YamauchiBig });
    }

    private void InvokeYamauchiStartingDialogue()
    {
        ShowPanels();
        text1.gameObject.SetActive(true);
    }

    private void InvokeStartFadeInBlackboard()
    {
        fadeManager.StartFadeIn(new List<Image> { Blackboard });
    }

    private void InvokeStartFadeInMathProblem()
    {
        fadeManager.StartFadeIn(new List<Image> { MathProblem });
    }

    private void InvokeStartFadeOutBlackboard()
    {
        fadeManager.StartFadeOut(new List<Image> { Blackboard });
    }

    private void InvokeStartFadeOutMathProblem()
    {
        fadeManager.StartFadeOut(new List<Image> { MathProblem });
    }
    private void InvokeStartFadeInMCBrowsRaised()
    {
        fadeManager.StartFadeIn(new List<Image> { MCBrowsRaised });
    }
    private void InvokeStartFadeOutMCBrowsRaised()
    {
        fadeManager.StartFadeOut(new List<Image> { MCBrowsRaised });
    }

    private void InvokeStartFadeInMCShocked()
    {
        fadeManager.StartFadeIn(new List<Image> { MCShocked });
    }

    private void InvokeStartFadeOutMCShocked()
    {
        fadeManager.StartFadeOut(new List<Image> { MCShocked });
    }

    private void InvokeStartFadeInTokinawa()
    {
        fadeManager.StartFadeIn(new List<Image> { Tokinawa });
    }

    private void InvokeStartFadeOutTokinawa()
    {
        fadeManager.StartFadeOut(new List<Image> { Tokinawa });
    }

    private void InvokeStartFadeInBlackScreen()
    {
        fadeManager.StartFadeInSilhouette(new List<Image> { BlackScreen });
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
    }

    private void InvokeShowBlackboardChoices()
    {
        Blackboard_Choice1.gameObject.SetActive(true);
        Blackboard_Choice2.gameObject.SetActive(true);
    }

    private void InvokeText5()
    {
        text5.gameObject.SetActive(true);
    }

    private void InvokeText8()
    {
        text8.gameObject.SetActive(true);
    }

    private void InvokeTokinawaStatement()
    {
        characterName.text = "Tokinawa";
        text8_TokinawaStatement.gameObject.SetActive(true);
    }

    private void InvokeText10()
    {
        characterName.text = "Art";
        text10.gameObject.SetActive(true);
    }

    private void InvokeHideBlackboardChoices()
    {
        Blackboard_Choice1.gameObject.SetActive(false);
        Blackboard_Choice2.gameObject.SetActive(false);
    }

    public void BlackboardChoice1Text()
    {
        Choice1 = true;
        InvokeHideBlackboardChoices();
        ShowPanels();
        characterName.text = "Art";
        text5.gameObject.SetActive(false);
        text6_BlackboardChoice1.gameObject.SetActive(true);
        InvokeStartFadeInMCBrowsRaised();
    }

    public void BlackboardChoice2Text()
    {
        Choice1 = false;
        InvokeHideBlackboardChoices();
        ShowPanels();
        characterName.text = "Art";
        text5.gameObject.SetActive(false);
        text6_BlackboardChoice2.gameObject.SetActive(true);
        InvokeStartFadeInMCBrowsRaised();
    }

    private void MoveYamauchiToMid()
    {
        YamauchiBig.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(110, -684);
    }

    private void MoveYamauchiToLeft()
    {
        YamauchiBig.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68, -684);
    }

    private void InvokeNextScene()
    {
        exp.BtnNextNoDelay();
    }

}
