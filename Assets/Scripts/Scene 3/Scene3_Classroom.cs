using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Classroom : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3;

    public ExplorationNavigation exp;

    public void BtnShowNext()
    {
        if (text3.activeSelf)
            exp.BtnNextNoDelay();

        if (text2.activeSelf)
        {
            text3.gameObject.SetActive(true);
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text2.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
        }
    }
}
