using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3_OpenedLocker : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3;
    public Button OutdoorShoes;
    public Button IndoorShoes;
    public Button GoToArrow;

    public Scene3_FourthPanel FourthPanel;
    public void BtnShowNext()
    {
        if (text3.activeSelf)
        {
            HidePanels();
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            HidePanels();
            text2.gameObject.SetActive(false);
            OutdoorShoes.gameObject.SetActive(true);
        }

        if (text1.activeSelf)
        {
            HidePanels();
            text1.gameObject.SetActive(false);
        }
    }

    private void HidePanels()
    {
        textPanel.gameObject.SetActive(false);
        namePanel.gameObject.SetActive(false);
        GoToArrow.gameObject.SetActive(true);
        IndoorShoes.interactable = true;
        OutdoorShoes.interactable = true;
    }

    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
        namePanel.gameObject.SetActive(true);
        GoToArrow.gameObject.SetActive(false);
        IndoorShoes.interactable = false;
        OutdoorShoes.interactable = false;
    }

    private void PrivateGrabIndoorShoes()
    {
        FourthPanel.OutdoorShoes = false;
        OutdoorShoes.gameObject.SetActive(true);
        IndoorShoes.gameObject.SetActive(false);

        ShowPanels();
        text2.gameObject.SetActive(true);
    }

    private void PrivateGrabOutdoorShoes()
    {
        ShowPanels();
        text3.gameObject.SetActive(true);
    }

    public void GrabIndoorShoes()
    {
        PrivateGrabIndoorShoes();
    }

    public void GrabOutdoorShoes()
    {
        PrivateGrabOutdoorShoes();
    }
}
