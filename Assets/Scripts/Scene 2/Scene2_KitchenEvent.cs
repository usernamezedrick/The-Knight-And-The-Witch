using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2_KitchenEvent : MonoBehaviour
{
    public bool Ingredients = false;
    public bool StartedGettingIngredients = false;
    public bool FinishedCooking = false;
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2, text3, text4, text5, text6;
    public GameObject Arrow;

    public Image CookingBaconAndEggs;
    public Button GoToFridge, CookFood;

    public Fridge fridge;
    public FadeManager fadeManager;

    public void BtnShowNext()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(true);
        GoToFridge.interactable = true;
        CookFood.interactable = true;

        if (text6.activeSelf)
        {
            text6.gameObject.SetActive(false);
        }

        if (text5.activeSelf)
        {
            InvokeStartFadeOutBaconAndEggs();
            Invoke("InvokeHideBaconAndEggs", 1.0f);
            text5.gameObject.SetActive(false);
            FinishedCooking = true;
        }

        if (text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
        }

        if (text3.activeSelf)
        {
            namePanel.gameObject.SetActive(true);
            textPanel.gameObject.SetActive(true);
            text3.gameObject.SetActive(false);
            text5.gameObject.SetActive(true);
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
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
            GoToFridge.interactable = false;
            CookFood.interactable = false;

            if (Ingredients == false && (fridge.egg1.activeSelf && fridge.egg2.activeSelf && fridge.bacon.activeSelf))
                ClickStoveWithoutIngredients();

            if (Ingredients == true && FinishedCooking == false)
                ClickStoveWithIngredients();

            if (StartedGettingIngredients == true && (fridge.egg1.activeSelf || fridge.egg2.activeSelf || fridge.bacon.activeSelf))
                ClickStoveIncompleteIngredients();

            if (FinishedCooking == true)
                ClickStoveFinishedCooking();
        }
    }

    public void ClickStoveWithoutIngredients()
    {
        text2.gameObject.SetActive(true);
    }

    public void ClickStoveIncompleteIngredients()
    {
        text4.gameObject.SetActive(true);
    }

    public void ClickStoveWithIngredients()
    {
        CookingBaconAndEggs.gameObject.SetActive(true);
        InvokeStartFadeInBaconAndEggs();
        text3.gameObject.SetActive(true);
    }

    public void ClickStoveFinishedCooking()
    {
        text6.gameObject.SetActive(true);
    }

    private void InvokeStartFadeOutBaconAndEggs()
    {
        fadeManager.StartFadeOut(new List<Image> { CookingBaconAndEggs });
    }

    private void InvokeHideBaconAndEggs()
    {
        CookingBaconAndEggs.gameObject.SetActive(false);
    }

    private void InvokeStartFadeInBaconAndEggs()
    {
        fadeManager.StartFadeIn(new List<Image> { CookingBaconAndEggs });
    }
}
