using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_SchoolSurrounding : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2;

    public GameObject goToOutskirts;
    public GameObject goToSchoolGate;

    public void BtnShowNext()
    {
        HidePanels();

        if (text2.activeSelf)
            text2.gameObject.SetActive(false);

        if (text1.activeSelf)
            text1.gameObject.SetActive(false);
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        goToOutskirts.gameObject.SetActive(true);
        goToSchoolGate.gameObject.SetActive(true);
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
        goToOutskirts.gameObject.SetActive(false);
        goToSchoolGate.gameObject.SetActive(false);
    }
    
    public void PromptOutskirtsMessage()
    {
        ShowPanels();
        text2.gameObject.SetActive(true);
    }
}
