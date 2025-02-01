using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene5_SchoolPostChoice : MonoBehaviour
{
    public GameObject namePanel;
    public GameObject textPanel;
    public GameObject Choice1Result_PT1, Choice1Result_PT2, Choice1Result_END, Choice2Result_PT1, Choice2Result_PT2;

    public GameObject PunchSFXObject;
    public AudioSource PunchSFX;

    public Scene5_SchoolSurrounding School;
    public ExplorationNavigation exp;

    private void Start()
    {
        PunchSFX = GameObject.Find("Punch SFX").GetComponent<AudioSource>();

        PunchSFX.Play();

        Invoke("ShowPanels", 3.0f);

        if (School.FightBack)
            Choice1Result_PT1.gameObject.SetActive(true);

        else if (!School.FightBack)
            Choice2Result_PT1.gameObject.SetActive(true);
    }

    public void BtnShowNext()
    {
        if (Choice2Result_PT2.activeSelf)
            exp.BtnNextNoDelay();

        if (Choice2Result_PT1.activeSelf)
        {
            Choice2Result_PT1.gameObject.SetActive(false);
            Choice2Result_PT2.gameObject.SetActive(true);
        }

        if (Choice1Result_END.activeSelf)
            LoadScene();

        if (Choice1Result_PT2.activeSelf)
        {
            Choice1Result_PT2.gameObject.SetActive(false);
            Choice1Result_END.gameObject.SetActive(true);
        }

        if (Choice1Result_PT1.activeSelf)
        {
            Choice1Result_PT1.gameObject.SetActive(false);
            Choice1Result_PT2.gameObject.SetActive(true);
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Scene1");
    }

    private void ShowPanels()
    {
        textPanel.gameObject.SetActive(true);
    }
}
