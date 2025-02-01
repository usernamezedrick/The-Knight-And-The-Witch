using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2_BathroomEvent : MonoBehaviour
{
    public bool Bath_Taken = false;
    public bool Sink_Taken = false;

    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2_AskBath, text2_YesResult, text2_NoResult, text3_BathTaken, text4_AskSink, text4_YesResult, text4_NoResult, text5_SinkTaken;
    public GameObject Arrow;

    [Header("Bath Choices")]
    public Button Bath_Yes;
    public Button Bath_No;

    [Header("Sink Choices")]
    public Button Sink_Yes;
    public Button Sink_No;

    [Header("Bath and Sink Button")]
    public Button Bath;
    public Button Sink;


    public void BtnShowNext()
    {
        HidePanel();

        if (text5_SinkTaken.activeSelf)
        {
            text5_SinkTaken.gameObject.SetActive(false);
        }

        if (text4_NoResult.activeSelf)
        {
            text4_NoResult.gameObject.SetActive(false);
        }

        if (text4_YesResult.activeSelf)
        {
            text4_YesResult.gameObject.SetActive(false);
        }

        if (text3_BathTaken.activeSelf)
        {
            text3_BathTaken.gameObject.SetActive(false);
        }

        if (text2_NoResult.activeSelf)
        {
            text2_NoResult.gameObject.SetActive(false);
        }

        if (text2_YesResult.activeSelf)
        {
            text2_YesResult.gameObject.SetActive(false);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
        }
    }

    public void ShowPanel()
    {
        if (!textPanel.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(false);
            Bath.interactable = false;
            Sink.interactable = false;
        }
    }

    public void HidePanel()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(true);
        Bath.interactable = true;
        Sink.interactable = true;
    }

    public void DisplaySinkChoices()
    {
        ShowPanel();
        if (Sink_Taken == false)
        {
            Sink_Yes.gameObject.SetActive(true);
            Sink_No.gameObject.SetActive(true);
            text4_AskSink.gameObject.SetActive(true);
        }

        if (Sink_Taken == true)
        {
            text5_SinkTaken.gameObject.SetActive(true);
        }
    }

    public void ChooseSinkChoice()
    {
        if (text4_AskSink.activeSelf)
        {
            text4_AskSink.gameObject.SetActive(false);
        }

        Sink_Yes.gameObject.SetActive(false);
        Sink_No.gameObject.SetActive(false);
        HidePanel();
    }

    public void SinkYesResult()
    {
        textPanel.gameObject.SetActive(true);
        Arrow.gameObject.SetActive(false);
        text4_YesResult.gameObject.SetActive(true);
        Sink_Taken = true;
        Bath.interactable = false;
        Sink.interactable = false;
    }

    public void SinkNoResult()
    {
        textPanel.gameObject.SetActive(true);
        Arrow.gameObject.SetActive(false);
        text4_NoResult.gameObject.SetActive(true);
        Bath.interactable = false;
        Sink.interactable = false;
    }

    public void DisplayBathChoices()
    {
        ShowPanel();
        if (Bath_Taken == false)
        {
            Bath_Yes.gameObject.SetActive(true);
            Bath_No.gameObject.SetActive(true);
            text2_AskBath.gameObject.SetActive(true);
        }

        if (Bath_Taken == true)
        {
            text3_BathTaken.gameObject.SetActive(true);
        }
    }

    public void ChooseBathChoice()
    {

        if (text2_AskBath.activeSelf)
        {
            text2_AskBath.gameObject.SetActive(false);
        }

        Bath_Yes.gameObject.SetActive(false);
        Bath_No.gameObject.SetActive(false);
        HidePanel();
    }

    public void BathYesResult()
    {
        textPanel.gameObject.SetActive(true);
        Arrow.gameObject.SetActive(false);
        text2_YesResult.gameObject.SetActive(true);
        Bath_Taken = true;
        Bath.interactable = false;
        Sink.interactable = false;
    }

    public void BathNoResult()
    {
        textPanel.gameObject.SetActive(true);
        Arrow.gameObject.SetActive(false);
        text2_NoResult.gameObject.SetActive(true);
        Bath.interactable = false;
        Sink.interactable = false;
    }
}
