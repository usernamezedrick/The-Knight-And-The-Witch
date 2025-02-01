using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_ShiranuiTSHome : MonoBehaviour
{
    [Header("Audio Elements")]
    public GameObject audioFootstepsObject;
    public AudioSource audioFootsteps;

    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4;

    public ExplorationNavigation exp;

    private void Start()
    {
        audioFootsteps = GameObject.Find("Footsteps").GetComponent<AudioSource>();
    }

    public void BtnShowNext()
    {
        if (text4.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text3.activeSelf)
        {
            HideTextPanel();
            audioFootsteps.Play();
            text3.gameObject.SetActive(false);
            Invoke("InvokeText4", 3.0f);
        }

        if (text2.activeSelf)
        {
            HideTextPanel();
            audioFootsteps.Play();
            text2.gameObject.SetActive(false);
            Invoke("InvokeText3", 3.0f);
        }

        if (text1.activeSelf)
        {
            HideTextPanel();
            audioFootsteps.Play();
            text1.gameObject.SetActive(false);
            Invoke("InvokeText2", 3.0f);
        }
    }

    private void InvokeText2()
    {
        ShowTextPanel();
        text2.gameObject.SetActive(true);
    }

    private void InvokeText3()
    {
        ShowTextPanel();
        text3.gameObject.SetActive(true);
    }

    private void InvokeText4()
    {
        ShowTextPanel();
        text4.gameObject.SetActive(true);
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
