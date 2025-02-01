using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella : MonoBehaviour
{
    public GameObject UmbrellaObject;
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject textToShow1, textToShow4, textToShowOffToSchool, textToShow_NotPrepared;
    public GameObject Arrow;
    public bool Umb = false;

    public ExplorationNavigation exp;
    public Scene2_KitchenEvent Kitchen;
    public Scene2_BathroomEvent Bathroom;

    public void GrabUmbrella()
    {
        if (Umb == false && Kitchen.FinishedCooking == true && Bathroom.Bath_Taken == true && Bathroom.Sink_Taken == true)
        {
            ShowPanel1();
            Umb = true;
            UmbrellaObject.gameObject.SetActive(false);
        }

        else if (Umb == false && (Kitchen.FinishedCooking == false || Bathroom.Bath_Taken == false || Bathroom.Sink_Taken == false))
        {
            ShowPanelUnprepared();
            Umb = false;
            UmbrellaObject.gameObject.SetActive(true);
        }
    }
    public void ShowPanel1()
    {
        if (!textPanel.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            textToShow1.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(false);
        }
    }

    public void ShowPanelUnprepared()
    {
        if (!textPanel.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            textToShow_NotPrepared.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(false);
        }
    }

    public void MissingUmbrella()
    {
        if (Umb == false)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            textToShow4.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(false);
        }
    }

    public void FoundUmbrella()
    {
        if (Umb == true)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            textToShowOffToSchool.gameObject.SetActive(true);
        }
    }
}
