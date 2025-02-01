using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_Shiranui_OutsideHome : MonoBehaviour
{
    [Header("Audio Elements")]
    public GameObject audioAngryCrowdObject;
    public AudioSource audioAngryCrowd;

    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1;

    public ExplorationNavigation exp;

    private void Start()
    {
        audioAngryCrowd = GameObject.Find("Angry Crowd").GetComponent<AudioSource>();
        audioAngryCrowd.Play();
        Invoke("InvokeText1", 5.0f);
    }

    private void InvokeText1()
    {
        textPanel.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
    }

    public void BtnShowNext()
    {
        if (text1.activeSelf)
        {
            exp.BtnNextNoDelay();
        }
    }
}
