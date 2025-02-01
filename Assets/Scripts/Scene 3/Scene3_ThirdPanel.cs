using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_ThirdPanel : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2;
    public Button SchoolEntrance;

    public ExplorationNavigation exp;

    public void BtnShowNext()
    {
        if (text2.activeSelf)
        {
            SchoolEntrance.interactable = true;
            HidePanels();
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text2.gameObject.SetActive(true);
            text1.gameObject.SetActive(false);
        }
    }

    private void HidePanels()
    {
        textPanel.gameObject.SetActive(false);
        namePanel.gameObject.SetActive(false);
    }
}
