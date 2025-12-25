using UnityEngine;

public class MainAudioManager : MonoBehaviour
{
    private static MainAudioManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    } 

[Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("---------- Audio Clip ----------")]
    public AudioClip countDown;
    public AudioClip button;
    public AudioClip success;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void buttonAudio()
    {
        SFXSource.clip = button;
        SFXSource.Play();
    }

}


