using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2_BedEvent : MonoBehaviour
{

    public GameObject DialogueBox;
    public GameObject NamePanel;

    [Header("Button Exploration")]
    public Button Bed;
    public Button DownArrow;

    [Header("Text")]
    public GameObject dialogueText;
    public GameObject dialogueFinishedPreparing;
    public GameObject dialogueYes;
    public GameObject dialogueNo;
    public GameObject dialogueYesResult;
    public GameObject dialogueNoResult;

    [Header("Preparation")]
    public Scene2_KitchenEvent Kitchen;
    public Scene2_BathroomEvent Bathroom;
    
    public void onBedPressed()
    {
        if (Kitchen.FinishedCooking == false && Bathroom.Bath_Taken == false && Bathroom.Sink_Taken == false)
        {
            DialogueBox.SetActive(true);
            NamePanel.SetActive(true);
            DownArrow.gameObject.SetActive(false);

            dialogueText.SetActive(true);

            Invoke("InvokeDisplayChoices", 3.0f);
        }

        else if (Kitchen.FinishedCooking == true && Bathroom.Bath_Taken == true && Bathroom.Sink_Taken == true)
        {
            DialogueBox.SetActive(true);
            NamePanel.SetActive(true);
            DownArrow.gameObject.SetActive(false);

            dialogueFinishedPreparing.SetActive(true);
        }
    }

    private void InvokeDisplayChoices()
    {
        dialogueYes.SetActive(true);
        dialogueNo.SetActive(true);
        DownArrow.gameObject.SetActive(false);
    }

    private void HideChoices()
    {
        dialogueYes.SetActive(false);
        dialogueNo.SetActive(false);
    }

    private void ShowPanels()
    {
        DialogueBox.SetActive(true);
        NamePanel.SetActive(true);
    }

    private void YesResult()
    {
        dialogueText.SetActive(false);
        dialogueYesResult.SetActive(true);
    }

    private void NoResult()
    {
        dialogueText.SetActive(false);
        dialogueNoResult.SetActive(true);
    }

    public void onYesPressed()
    {
        HideChoices();
        ShowPanels();
        YesResult();
    }

    public void onNoPressed()
    {
        HideChoices();
        ShowPanels();
        NoResult();
    }
}
