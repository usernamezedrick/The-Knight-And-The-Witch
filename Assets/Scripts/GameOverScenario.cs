using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScenario : MonoBehaviour
{
    public GameObject activeScene;
    public string mainMenuPanelName;

    public void BtnNextScene()
    {
        activeScene.gameObject.SetActive(false);
        LoadNewScene();
    }
    private void LoadNewScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}
