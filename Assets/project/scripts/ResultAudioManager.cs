using UnityEngine;

public class ResultAudioManager : MonoBehaviour
{
    private static ResultAudioManager instance;
    public static ResultAudioManager Instance => instance;
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
    [SerializeField] AudioSource SFXSource;


    [Header("---------- Audio Clip ----------")]
    public AudioClip button;


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

