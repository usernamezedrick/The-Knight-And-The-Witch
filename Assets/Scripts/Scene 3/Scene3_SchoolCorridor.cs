using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_SchoolCorridor : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3;
    public Button GoToArrow;
    public Button GoToClassroom;
    public Button GoToLocker;

    [Header("Audio Elements")]
    public GameObject audioSlidingDoorObject;
    public AudioSource audioSlidingDoor;

    private void Start()
    {
        audioSlidingDoor = GameObject.Find("Sliding Door").GetComponent<AudioSource>();
    }

    public void BtnShowNext()
    {
        if (text3.activeSelf)
        {
            HidePanels();
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            HidePanels();
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            HidePanels();
            text1.gameObject.SetActive(false);
        }
    }

    private void HidePanels()
    {
        textPanel.gameObject.SetActive(false);
        namePanel.gameObject.SetActive(false);
        GoToArrow.gameObject.SetActive(true);
        GoToClassroom.interactable = true;
        GoToLocker.interactable = true;
    }

    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
        GoToArrow.gameObject.SetActive(false);
    }

    public void Click()
    {
        if (!textPanel.activeSelf)
            ShowPanels();
    }

    public void ShowPromptWrongClassroom()
    {
        text3.gameObject.SetActive(true);
    }

    public void ShowPromptCorridor2()
    {
        text2.gameObject.SetActive(true);
    }

    public void SlideDoor()
    {
        audioSlidingDoor.Play();
    }
}
