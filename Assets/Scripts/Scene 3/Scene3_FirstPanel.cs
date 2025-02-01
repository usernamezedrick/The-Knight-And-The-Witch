using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_FirstPanel : MonoBehaviour
{
    public GameObject namePanel;
    public TextMeshProUGUI characterName;
    public GameObject textPanel;
    public GameObject text1, text2Girl1, text2Girl2, text3, text4;

    public FadeManager fadeManager;
    public ExplorationNavigation exp;

    public Image Girl1;
    public Image Girl2;

    public void BtnShowNext()
    {
        if (text4.gameObject.activeSelf)
        {
            text4.gameObject.SetActive(false);
            exp.BtnNextNoDelay();
        }

        if (text3.activeSelf)
        {
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }

        if (text2Girl2.activeSelf)
        {
            InvokeStartFadeOutGirls();
            text2Girl2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
            characterName.text = "Art";
        }

        if (text2Girl1.activeSelf)
        {
            InvokeStartFadeInGirl2();
            text2Girl2.gameObject.SetActive(true);
            text2Girl1.gameObject.SetActive(false);
            characterName.text = "Girl 2";
        }

        if (text1.activeSelf)
        {
            InvokeStartFadeInGirl1();
            text2Girl1.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
            characterName.text = "Girl 1";
        }
    }

    private void InvokeStartFadeInGirl1()
    {
        fadeManager.StartFadeInSilhouette(new List<Image> { Girl1 });
    }

    private void InvokeStartFadeInGirl2()
    {
        fadeManager.StartFadeInSilhouette(new List<Image> { Girl2 });
    }

    private void InvokeStartFadeOutGirls()
    {
        fadeManager.StartFadeOutSilhouette(new List<Image> { Girl1, Girl2 });
    }
}
