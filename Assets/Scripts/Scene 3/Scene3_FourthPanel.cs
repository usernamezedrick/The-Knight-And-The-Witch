using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_FourthPanel : MonoBehaviour
{
    public bool OutdoorShoes = true;
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1;
    public Button GoToArrow;
    public Button OpenLocker;

    public ExplorationNavigation exp;

    public void BtnShowNext()
    {
        if (text1.activeSelf)
        {
            HidePanels();
            GoToArrow.gameObject.SetActive(true);
            OpenLocker.interactable = true;
            text1.gameObject.SetActive(false);

        }
    }

    public void GoNextScene()
    {
        GoToNextPanel();
    }

    private void HidePanels()
    {
        textPanel.gameObject.SetActive(false);
        namePanel.gameObject.SetActive(false);
    }

    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
        GoToArrow.gameObject.SetActive(false);
        OpenLocker.interactable = false;
    }
    private void GoToNextPanel()
    {
        if (OutdoorShoes)
        {
            ShowPanels();
            text1.gameObject.SetActive(true);
        }

        else if (!OutdoorShoes)
        {
            exp.BtnNextNoDelay();
        }
    }
}
