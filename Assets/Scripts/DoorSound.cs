using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Audio Elements")]
    public GameObject audioOpenCloseDoorObject; //this is referenced to the object where the audio is attached
    public AudioSource audioOpenCloseDoor; //this is the Dragon Roar audio

    private void Start()
    {
        audioOpenCloseDoor = GameObject.Find("Open and Close Door").GetComponent<AudioSource>();
    }

    public void PlayOpenCloseDoorSound()
    {
        audioOpenCloseDoor.Play(); 
    }
}
