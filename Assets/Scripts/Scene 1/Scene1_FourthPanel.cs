using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1_FourthPanel : MonoBehaviour
{
    public GameObject dialoguePanel; //The next Dialogue Panel is referenced here
    public GameObject thisPanel; //Current Panel is referenced here
    public GameObject text1, text2, text3; //Text Dialogues are referenced here
    public GameObject textPanel;
    public GameObject characterNamePanel;
    public GameObject mainMenuPanel;
    public TextMeshProUGUI CharacterName; //Character Name Text is referenced here
    public Animator animator;
    public FadeManager fadeManager; //The FadeManager script is referenced here
    public string animationClip;

    [Header("Image Elements")]
    public Image Shiranui, Art, Dragon; //Images of Characters is referenced here
    public Image Slash1, Slash2, DragonBreath; //Images of Visual Effects is referenced here

    [Header("Audio Elements")]
    public GameObject audioDragonRoarObject; //this is referenced to the object where the audio is attached
    public AudioSource audioDragonRoar; //this is the Dragon Roar audio
    public GameObject audioSlashObject;
    public AudioSource audioSlash;
    public GameObject audioDragonBreathObject;
    public AudioSource audioDragonBreath;

    [Header("Color Elements")]
    public Color originalDragonColor;
    private float originalAlpha = 1.0f;

    private void Start()
    {
        originalDragonColor = Dragon.color;
        originalDragonColor.a = originalAlpha;
        audioDragonRoar = GameObject.Find("Dragon Roar").GetComponent<AudioSource>();
        audioSlash = GameObject.Find("Slash").GetComponent<AudioSource>();
        audioDragonBreath = GameObject.Find("dgb").GetComponent<AudioSource>();
        fadeManager = FindObjectOfType<FadeManager>();
        fadeManager.StartFadeIn(new List<Image> { Shiranui });
    }

    public void BtnShowNext()
    {
        if (text3.activeSelf)
        {
            StartCoroutine(RepeatSlashCoroutine());

            text3.SetActive(false);
            textPanel.SetActive(false);
            characterNamePanel.SetActive(false);
        }

        if (text2.activeSelf)
        {
            Invoke("InvokeStartFadeOutArtShiranui", 0.5f);
            text2.SetActive(false);
            Invoke("ShowText3", 1.0f);
            Invoke("InvokeStartFadeInDragon", 1.0f);     
        }

        if (text1.activeSelf)
        {
            Shiranui.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(178, -90.01382f);
            Shiranui.gameObject.SetActive(true);
            Invoke("InvokeStartFadeInArt", 0f);
            text1.SetActive(false);
            Invoke("ShowText2", 1.0f);   
        }
    }
    IEnumerator RepeatSlashCoroutine()
    {
        int count = 1;
        while (count <= 5)
        {
            RepeatSlash();
            
            if (count == 2)
            {
                audioDragonRoar.Play();
                yield return new WaitWhile(() => audioDragonRoar.isPlaying);
                RepeatSlash();
            }

            yield return new WaitForSeconds(1.5f);
            count++;
        }

        Invoke("InvokeStartFadeOutDragon", 0.5f);
        Invoke("InvokeDragonBreath", 1.0f);

        Invoke("LoadNewScene", 5f);
    }

    void RepeatSlash()
    {
        Invoke("InvokeStartFadeInSlash1", 0.1f);
        Invoke("InvokePlaySlashAudio", 0.2f);
        Invoke("InvokeStartFadeOutSlash1", 0.3f);
        Invoke("InvokeStartFadeInSlash2", 0.8f);
        Invoke("InvokePlaySlashAudio", 0.9f);
        Invoke("InvokeStartFadeOutSlash2", 1.0f);
    }

    private void ShowText3()
    {
        CharacterName.text = "Dragon";
        audioDragonRoar.Play();
        text3.SetActive(true);
    }

    private void ShowText2()
    {
        CharacterName.text = "Art";
        text2.SetActive(true);
    }

    private void InvokeStartFadeInArt()
    {
        fadeManager.StartFadeIn(new List<Image> { Art });
    }

    private void InvokeStartFadeOutArtShiranui()
    {
        fadeManager.StartFadeOut(new List<Image> { Art, Shiranui });
    }

    private void InvokeStartFadeInDragon()
    {
        Dragon.gameObject.SetActive(true);
        fadeManager.StartFadeIn(new List<Image> { Dragon });
    }

    private void InvokeStartFadeOutDragon()
    {
        fadeManager.StartFadeOut(new List<Image> { Dragon });
    }

    private void InvokeStartFadeInSlash1()
    {
        fadeManager.StartFadeIn(new List<Image> { Slash1 });
        Dragon.color = new Color(1f, 0.38f, 0.38f, 1f);
        StartCoroutine(ShakeDragon());
    }

    private void InvokeStartFadeInSlash2()
    {
        fadeManager.StartFadeIn(new List<Image> { Slash2 });
        Dragon.color = new Color(1f, 0.38f, 0.38f, 1f);
        StartCoroutine(ShakeDragon());
    }

    private void InvokeStartFadeOutSlash1()
    {
        Dragon.color = originalDragonColor;
        fadeManager.StartFadeOut(new List<Image> { Slash1 });
    }

    private void InvokeStartFadeOutSlash2()
    {
        Dragon.color = originalDragonColor;
        fadeManager.StartFadeOut(new List<Image> { Slash2 });
    }

    private IEnumerator ShakeDragon()
    {
        float duration = 0.5f; // Adjust as needed
        float magnitude = 20f; // Adjust as needed
        RectTransform rectTransform = Dragon.rectTransform;

        Vector3 originalPosition = rectTransform.localPosition;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float randomValue = Random.Range(-1f, 1f);
            float direction = Mathf.Sign(randomValue); // Determine the direction based on the sign of the random value

            float offsetX = direction * magnitude;
            Vector3 offset = new Vector3(offsetX, 0f, 0f);

            // Apply the offset to the local position
            rectTransform.localPosition = originalPosition + offset;

            elapsed += Time.deltaTime;
            yield return null;
        }

        // Reset to the original position
        rectTransform.localPosition = originalPosition;
    }

    private void InvokePlaySlashAudio()
    {
        audioSlash.Play();
    }

    private void InvokePlayDragonBreathAudio()
    {
        audioDragonBreath.Play();
    }

    private void InvokeStartFadeInDragonBreath()
    {
        fadeManager.StartFadeIn(new List<Image> { DragonBreath });
    }

    private void InvokeDragonBreath()
    {
        Dragon.gameObject.SetActive(false);
        Dragon.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(206.0443f, -8);
        Invoke("InvokeStartFadeInDragon", 1.0f);
        Invoke("InvokeStartFadeInDragonBreath", 2.0f);
        Invoke("InvokePlayDragonBreathAudio", 0.0f);
    }

    void DeLayShow()
    {
        thisPanel.gameObject.SetActive(false);
        dialoguePanel.gameObject.SetActive(true);
    }

    private void LoadNewScene()
    {
        // Replace "YourSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("Scene2");
    }
}
