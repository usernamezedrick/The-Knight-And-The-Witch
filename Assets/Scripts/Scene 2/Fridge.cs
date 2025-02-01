using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject text1, text2;
    public GameObject Arrow;
    public GameObject egg1, egg2, bacon;

    public Scene2_KitchenEvent Kitchen;

    public void Update()
    {
        if (!egg1.activeSelf && !egg2.activeSelf && !bacon.activeSelf)
            Kitchen.Ingredients = true;
    }

    public void BtnShowNext()
    {
        namePanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(true);

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
        }
    }

    public void GrabEgg1()
    {
        if (!textPanel.activeSelf)
        {
            egg1.SetActive(false);
            Kitchen.StartedGettingIngredients = true;
        }  
    }

    public void GrabEgg2()
    {
        if (!textPanel.activeSelf)
        {
            egg2.SetActive(false);
            Kitchen.StartedGettingIngredients = true;
        }
    }

    public void GrabBacon()
    {
        if (!textPanel.activeSelf)
        {
            bacon.SetActive(false);
            Kitchen.StartedGettingIngredients = true;
        }
    }

}
