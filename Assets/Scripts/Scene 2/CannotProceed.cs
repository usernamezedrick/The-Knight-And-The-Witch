using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CannotProceed : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6;
    public GameObject Arrow;

    public ExplorationNavigation exp;

    public void BtnShowNext()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(true);

        if (text6 != null && text6.activeSelf)
            text6.gameObject.SetActive(false);

        if (text5 != null && text5.activeSelf)
            text5.gameObject.SetActive(false);

        if (text4 != null && text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            text6.gameObject.SetActive(true);
        }   

        if (text3 != null && text3.activeSelf)
        {
            text3.gameObject.SetActive(false);
            exp.BtnNextNoDelay();
            LoadNewScene();
        }   

        if (text2.activeSelf)
            text2.gameObject.SetActive(false);

        if (text1.activeSelf)
            text1.gameObject.SetActive(false);
    }

    public void ShowPanel()
    {
        if (!textPanel.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            text1.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(false);
        }
    }
    private void LoadNewScene()
    {
        // Replace "YourSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("Scene3");
    }
}
