using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene7_Classroom : MonoBehaviour
{
    [Header("Audio Elements")]
    public GameObject audioBellRingObject;
    public AudioSource audioBellRing;
    public GameObject audioChatterObject;
    public AudioSource audioChatter;

    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject arrowSchoolCorridor;
    public GameObject text1, text2, text3;

    public TextMeshProUGUI characterName;

    private void Start()
    {
        audioBellRing = GameObject.Find("Bell Ring").GetComponent<AudioSource>();
        audioChatter = GameObject.Find("Indistinct Chatter").GetComponent<AudioSource>();

        audioBellRing.Play();
        Invoke("ShowTextPanel", 4.0f);
    }

    public void ShowBtnNext()
    {
        if (text3.activeSelf)
        {
            arrowSchoolCorridor.gameObject.SetActive(true);
            HideNamePanel();
            HideTextPanel();
            audioChatter.Stop();
        }

        if (text2.activeSelf)
        {
            characterName.text = "Student B";
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
        }

        if (text1.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
            audioChatter.Play();
            audioChatter.loop = true;
            text2.gameObject.SetActive(true);
        }
    }

    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
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
    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
    }
    private void ShowNamePanel()
    {
        namePanel.gameObject.SetActive(true);
    }
}
