using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_Windows : MonoBehaviour
{
    [Header("Audio Elements")]
    public GameObject audioAngryCrowdObject;
    public AudioSource audioAngryCrowd;

    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4, text5;

    public ExplorationNavigation exp;

    private void Start()
    {
        audioAngryCrowd = GameObject.Find("Angry Crowd").GetComponent<AudioSource>();
    }

    public void ShowBtnNext()
    {
        if (text5.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
            text5.gameObject.SetActive(true);
        }

        if (text3.activeSelf)
        {
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
            HideTextPanel();
            audioAngryCrowd.Play();
            Invoke("InvokeText3", 5.0f);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }

    private void HideTextPanel()
    {
        textPanel.gameObject.SetActive(false);
    }

    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
    }

    private void InvokeText3()
    {
        ShowTextPanel();
        text3.gameObject.SetActive(true);
    }
}
