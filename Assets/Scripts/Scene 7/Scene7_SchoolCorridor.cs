using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene7_SchoolCorridor : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2;
    public GameObject corridor2Arrow;

    public Button LockerHallway;
    public Button SchoolClassroom;

    public void ShowBtnNext()
    {
        HideTextPanel();

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
        }
    }

    public void ClickLockerHallway()
    {
        ShowTextPanel();
        text2.gameObject.SetActive(true);
    }

    private void HideTextPanel()
    {
        textPanel.gameObject.SetActive(false);
        corridor2Arrow.gameObject.SetActive(true);
        LockerHallway.interactable = true;
        SchoolClassroom.interactable = true;
    }

    private void ShowTextPanel()
    {
        textPanel.gameObject.SetActive(true);
        corridor2Arrow.gameObject.SetActive(false);
        LockerHallway.interactable = false;
        SchoolClassroom.interactable = false;
    }
}
