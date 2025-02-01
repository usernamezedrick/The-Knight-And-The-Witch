using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene7_OpenedLocker : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject namePanel;
    public GameObject text1, text2, text3, text4, text5;

    public Button LoveLetter;
    public Button IndoorShoes;

    public GameObject LoveLetterContent;

    public ExplorationNavigation exp;

    public void ShowBtnNext()
    {
        if (text5.activeSelf)
        {
            exp.BtnNextNoDelay();
        }

        if (text4.activeSelf)
        {
            text5.gameObject.SetActive(true);
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            text4.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
        }

        if (text2.activeSelf)
        {
            HideTextPanel();
            text2.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            HideTextPanel();
            text1.gameObject.SetActive(false);
        }
    }
    private void HideTextPanel()
    {
        textPanel.gameObject.SetActive(false);
        MakeObjectsInteractable();
    }
    private void HideNamePanel()
    {
        namePanel.gameObject.SetActive(false);
    }
    private void ShowTextPanel()
    {
        MakeObjectsNotInteractable();
        textPanel.gameObject.SetActive(true);
    }
    private void ShowNamePanel()
    {
        namePanel.gameObject.SetActive(true);
    }
    private void MakeLLInteractable()
    {
        LoveLetter.interactable = true;
    }
    private void MakeISInteractable()
    {
        IndoorShoes.interactable = true;
    }
    private void MakeObjectsInteractable()
    {
        MakeLLInteractable();
        MakeISInteractable();
    }
    private void MakeLLNotInteractable()
    {
        LoveLetter.interactable = false;
    }
    private void MakeISNotInteractable()
    {
        IndoorShoes.interactable = false;
    }
    private void MakeObjectsNotInteractable()
    {
        MakeLLNotInteractable();
        MakeISNotInteractable();
    }
    public void ClickIndoorShoes()
    {
        ShowTextPanel();
        text2.gameObject.SetActive(true);
    }
    public void ShowLLContent()
    {
        LoveLetterContent.gameObject.SetActive(true);
        ShowTextPanel();
        text3.gameObject.SetActive(true);
    }
}
