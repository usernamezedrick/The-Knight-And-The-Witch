using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene4_GymStorage : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject FindObjectsPanels;
    public GameObject HiddenPanel;
    public GameObject Minigame;
    public GameObject Pen;
    public GameObject Scissors;
    public GameObject Bag;
    public GameObject WaterBottle;
    public GameObject Calculator;
    public GameObject text1, text2;

    public TextMeshProUGUI PenText;
    public TextMeshProUGUI ScissorsText;
    public TextMeshProUGUI BagText;
    public TextMeshProUGUI WaterBottleText;
    public TextMeshProUGUI CalculatorText;

    public bool MiniGame = false;
    public bool MiniGame_isCompleted = false;

    public ExplorationNavigation exp;

    private void Update()
    {
        if (!Pen.activeSelf)
            PenText.fontStyle = FontStyles.Strikethrough;

        if (!Scissors.activeSelf)
            ScissorsText.fontStyle = FontStyles.Strikethrough;

        if (!Bag.activeSelf)
            BagText.fontStyle = FontStyles.Strikethrough;

        if (!WaterBottle.activeSelf)
            WaterBottleText.fontStyle = FontStyles.Strikethrough;

        if (!Calculator.activeSelf)
            CalculatorText.fontStyle = FontStyles.Strikethrough;

        if (!Pen.activeSelf && !Scissors.activeSelf && !Bag.activeSelf && !WaterBottle.activeSelf && !Calculator.activeSelf)
        {
            MiniGame_isCompleted = true;
        }

        if (MiniGame_isCompleted)
        {
            MiniGameEnd();
        }
    }

    public void BtnShowNext()
    {
        HidePanels();

        if (text2.activeSelf)
            LoadScene();

        if (text1.activeSelf)
        {
            MiniGameStart();
            text1.gameObject.SetActive(false);
        }    
    }

    public void HidePanels()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
    }

    public void ShowPanels()
    {
        namePanel.gameObject.SetActive(true);
        textPanel.gameObject.SetActive(true);
    }

    public void HideOrShowFindObjectsPanel()
    {
        if (!FindObjectsPanels.activeSelf)
        {
            FindObjectsPanels.gameObject.SetActive(true);
            HiddenPanel.gameObject.SetActive(false);
        }
            

        else if (FindObjectsPanels.activeSelf)
        {
            FindObjectsPanels.gameObject.SetActive(false);
            HiddenPanel.gameObject.SetActive(true);
        }
    }

    public void MiniGameStart()
    {
        MiniGame = true;
        Minigame.gameObject.SetActive(true);
    }

    public void GetBag()
    {
        Bag.gameObject.SetActive(false);
    }

    public void GetScissors()
    {
        Scissors.gameObject.SetActive(false);
    }

    public void GetPen()
    {
        Pen.gameObject.SetActive(false);
    }

    public void GetCalculator()
    {
        Calculator.gameObject.SetActive(false);
    }

    public void GetWaterBottle()
    {
        WaterBottle.gameObject.SetActive(false);
    }

    public void MiniGameEnd()
    {
        MiniGame = false;
        Minigame.gameObject.SetActive(false);

        ShowPanels();
        text2.gameObject.SetActive(true);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Scene5");
    }
}
