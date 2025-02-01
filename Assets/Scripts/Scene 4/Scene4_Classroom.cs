using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_Classroom : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1;
    public GameObject goToCorridorArrow;

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
        goToCorridorArrow.gameObject.SetActive(true);
    }
}
