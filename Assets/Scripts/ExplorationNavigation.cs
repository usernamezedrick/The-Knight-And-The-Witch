using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorationNavigation : MonoBehaviour
{
    public GameObject activeScene;
    public GameObject nextScene;

    public void BtnNext()
    {
        Invoke("InvokeNextScene", 3.0f);
    }
    public void BtnNextNoDelay()
    {
        InvokeNextScene();
    }
    private void InvokeNextScene()
    {
        activeScene.gameObject.SetActive(false);
        nextScene.gameObject.SetActive(true);
    }
}
