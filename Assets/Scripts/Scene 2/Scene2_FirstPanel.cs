using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2_FirstPanel : MonoBehaviour
{
    public GameObject dialoguePanel; //Dialogue Panel is referenced here
    public GameObject thisPanel; //Current Panel is referenced here
    public GameObject text1; //Text Dialogues are referenced here
    public Animator animator;
    public string animationClip;

    [Header("Audio Elements")]
    public GameObject audioAlarmClockObject; //this is referenced to the object where the audio is attached
    public AudioSource audioAlarmClock; //this is the Dragon Roar audio
    public GameObject audioSnoozeObject;
    public AudioSource audioSnooze;

    // Start is called before the first frame update
    void Start()
    {
        audioAlarmClock = GameObject.Find("Alarm Clock").GetComponent<AudioSource>();
        audioSnooze = GameObject.Find("Snooze").GetComponent<AudioSource>();

        audioAlarmClock.Play();

        Invoke("InvokeSnooze", 1.8f);

        
    }
    private void InvokeSnooze()
    {
        audioSnooze.Play();
        Invoke("DeLayShow", 1f);
    }
    void DeLayShow()
    {
        thisPanel.gameObject.SetActive(false);
        dialoguePanel.gameObject.SetActive(true);
    }
}
