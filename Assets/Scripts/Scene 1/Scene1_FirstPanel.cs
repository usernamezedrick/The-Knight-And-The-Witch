using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_FirstPanel : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject thisPanel;
    public GameObject text1, text2, text3, text4;
    public Animator animator;
    public string animationClip;

    public void BtnShowNext(){
        if (text4.activeSelf) {
            animator.Play(animationClip);
            Invoke("DeLayShow",1f);
        }

        if (text3.activeSelf) {
            text3.SetActive(false);
            text4.SetActive(true);
        }

        if (text2.activeSelf) {
            text2.SetActive(false);
            text3.SetActive(true);
        }

        if (text1.activeSelf) {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }

    void DeLayShow(){
        thisPanel.gameObject.SetActive(false);
        dialoguePanel.gameObject.SetActive(true);
    }
}
