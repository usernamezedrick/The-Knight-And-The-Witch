using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_PicnicBasket : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4, text5, text6;

    public ExplorationNavigation exp;

    public void BtnShowNext()
    {
        if (text6.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text5.activeSelf)
        {
            text5.gameObject.SetActive(false);
            text6.gameObject.SetActive(true);
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
            text3.gameObject.SetActive(true);
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
