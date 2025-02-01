using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7_Sky : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject text1, text2, text3;

    public ExplorationNavigation exp;

    [Header("Audio Elements")]
    public GameObject audioCicadaChirpObject;
    public AudioSource audioCicadaChirp;

    private void Start()
    {
        audioCicadaChirp = GameObject.Find("Cicada Chirp").GetComponent<AudioSource>();

        audioCicadaChirp.Play();
        Invoke("InvokeText1", 7.0f);
    }

    public void BtnShowNext()
    {
        if (text3.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }

    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
    }

    private void InvokeText1()
    {
        ShowTextPanel();
        text1.gameObject.SetActive(true);
    }
}
