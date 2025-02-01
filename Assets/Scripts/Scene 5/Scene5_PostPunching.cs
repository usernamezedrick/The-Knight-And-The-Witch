using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene5_PostPunching : MonoBehaviour
{
    public void BtnShowNext()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Scene6");
    }
}
