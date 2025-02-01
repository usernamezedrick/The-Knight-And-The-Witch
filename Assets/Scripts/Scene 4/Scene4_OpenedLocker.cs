using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene4_OpenedLocker : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2;
    public GameObject goToLockerHallwayArrow;

    public Scene4_LockerHallway LockerHallway;

    public Button IndoorShoes;
    public Button OutdoorShoes;

    public void BtnShowNext()
    {
        HidePanels();

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);

            IndoorShoes.gameObject.SetActive(false);
            OutdoorShoes.gameObject.SetActive(true);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);

            IndoorShoes.gameObject.SetActive(true);
            OutdoorShoes.gameObject.SetActive(false);
        }
            
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        goToLockerHallwayArrow.gameObject.SetActive(true);
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
        goToLockerHallwayArrow.gameObject.SetActive(false);
    }

    public void ClickOutdoorShoes()
    {;
        textPanel.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);
        LockerHallway.IndoorShoes = false;

        IndoorShoes.interactable = true;
        OutdoorShoes.interactable = false;
    }

    public void ClickIndoorShoes()
    {
        textPanel.gameObject.SetActive(true);
        text2.gameObject.SetActive(true);
        LockerHallway.IndoorShoes = true;

        IndoorShoes.interactable = false;
        OutdoorShoes.interactable = true;
    }
}
