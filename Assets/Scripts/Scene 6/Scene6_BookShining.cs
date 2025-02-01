using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6_BookShining : MonoBehaviour
{
    public GameObject text1, text2, text3, text4, text5;

    public void ShowBtnNext()
    {
        if (text5.activeSelf)
        {
            LoadScene();
        }

        if (text4.activeSelf)
        {
            text4.gameObject.SetActive(false);
            text5.gameObject.SetActive(true);
        }

        if (text3.activeSelf)
        {
            text3.gameObject.SetActive(false);
            text4.gameObject.SetActive(true);
        }

        if (text2.activeSelf)
        {
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);
        }

        if (text1.activeSelf)
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Scene7");
    }
}
