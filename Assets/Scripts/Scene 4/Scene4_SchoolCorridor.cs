using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene4_SchoolCorridor : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text1Corridor2;
    public GameObject goToCorridor2Arrow;

    public Button Classroom;
    public Button Lockers;

    public void BtnShowNext()
    {
        HidePanels();

        if (text1Corridor2.activeSelf)
            text1Corridor2.gameObject.SetActive(false);

        if (text1.activeSelf)
            text1.gameObject.SetActive(false);
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        goToCorridor2Arrow.gameObject.SetActive(true);
        Classroom.interactable = true;
        Lockers.interactable = true;
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
        goToCorridor2Arrow.gameObject.SetActive(false);
        Classroom.interactable = false;
        Lockers.interactable = false;
    }

    public void PromptCorridor2Message()
    {
        ShowPanels();
        text1Corridor2.gameObject.SetActive(true);
    }
}
