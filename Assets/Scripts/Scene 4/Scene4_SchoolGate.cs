using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_SchoolGate : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1;

    public GameObject goToRoadArrow;
    public GameObject goToSchoolSurroundingArrow;

    public void BtnShowNext()
    {
        HidePanels();

        if (text1.activeSelf)
            text1.gameObject.SetActive(false);
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        goToRoadArrow.gameObject.SetActive(true);
        goToSchoolSurroundingArrow.gameObject.SetActive(true);
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
        goToRoadArrow.gameObject.SetActive(false);
        goToSchoolSurroundingArrow.gameObject.SetActive(false);
    }

    public void PromptGoHome()
    {
        ShowPanels();
        text1.gameObject.SetActive(true);
    }
}
