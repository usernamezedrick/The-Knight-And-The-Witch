using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene4_LockerHallway : MonoBehaviour
{
    public bool IndoorShoes = true;

    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text1_NoOutdoorShoes, text1_CorridorHasOutdoorShoes;
    public GameObject goToCorridorArrow;
    public GameObject goToOutsideArrow;

    public Button Lockers;

    public ExplorationNavigation exp;
    public ExplorationNavigation exp2;

    public void BtnShowNext()
    {
        HidePanels();

        if (text1_CorridorHasOutdoorShoes)
            text1_CorridorHasOutdoorShoes.gameObject.SetActive(false);

        if (text1_NoOutdoorShoes.activeSelf)
            text1_NoOutdoorShoes.gameObject.SetActive(false);

        if (text1.activeSelf)
            text1.gameObject.SetActive(false);
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        goToCorridorArrow.gameObject.SetActive(true);
        goToOutsideArrow.gameObject.SetActive(true);
        Lockers.interactable = true;
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
        goToCorridorArrow.gameObject.SetActive(false);
        goToOutsideArrow.gameObject.SetActive(false);
        Lockers.interactable = false;
    }

    public void goToOutside()
    {
        if (IndoorShoes)
        {
            ShowPanels();
            text1_NoOutdoorShoes.gameObject.SetActive(true);
        }

        if (!IndoorShoes)
            exp2.BtnNextNoDelay();
    }

    public void goToSchoolCorridor()
    {
        if (!IndoorShoes)
        {
            ShowPanels();
            text1_CorridorHasOutdoorShoes.gameObject.SetActive(true);
        }

        if (IndoorShoes)
        {
            exp.BtnNextNoDelay();
        }
    }
}
