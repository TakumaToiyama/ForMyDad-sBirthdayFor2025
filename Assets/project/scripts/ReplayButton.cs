using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    ResultAudioManager audioManager;
    void Awake()
    {
        FindAudioManager();
    }
    public void DoOneTHing()
    {
        FindAudioManager();
        audioManager.PlaySFX(audioManager.button);
        SceneManager.LoadScene("MainScene");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindAudioManager()
    {
        audioManager = ResultAudioManager.Instance;
        
        if (audioManager == null)
        {
            Debug.LogWarning("MainAudioManager.Instance is null!");
        }
        else
        {
            Debug.Log("AudioManager found successfully!");
        }
    }
}
