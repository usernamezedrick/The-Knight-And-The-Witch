using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_ThirdPanel : MonoBehaviour
{
    public GameObject dialoguePanel; //Dialogue Panel is referenced here
    public GameObject thisPanel; //Current Panel is referenced here
    public GameObject text1; //Text Dialogues are referenced here
    public Animator animator;
    public string animationClip;

    public void BtnShowNext()
    {
        if (text1.activeSelf)
        {
            animator.Play(animationClip);
            Invoke("DeLayShow", 1f);
        }

        if (text1.activeSelf)
            text1.SetActive(false);
    }

    void DeLayShow()
    {
        thisPanel.gameObject.SetActive(false);
        dialoguePanel.gameObject.SetActive(true);
    }
}
