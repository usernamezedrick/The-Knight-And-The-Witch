using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_BlackScreen : MonoBehaviour
{
    public GameObject text1, text2;

    public ExplorationNavigation exp;

    public GameObject audioFootstepsObject;
    public AudioSource audioFootsteps;

    private void Start()
    {
        audioFootsteps = GameObject.Find("Footsteps").GetComponent<AudioSource>();
    }

    public void BtnShowNext()
    {
        if (text2.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }
}
