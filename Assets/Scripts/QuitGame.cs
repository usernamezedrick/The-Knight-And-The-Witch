using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void quit_Game() {
        Application.Quit();
        Debug.Log("Game is closed");
    }
}
