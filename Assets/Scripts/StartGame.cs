using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject scene1;
    public GameObject panel1;

    public void start_Game() {
        mainMenu.SetActive(false);
        scene1.SetActive(true);
        panel1.SetActive(true);
    }
}
