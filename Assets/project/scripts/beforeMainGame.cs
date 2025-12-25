using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class beforeMainGame : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayObject;
    // ゲームが開始していいかどうか
    private bool isGameStart = false;

    // カウントダウン表示用 TextMeshPro
    [SerializeField] private TMP_Text countdownText;
    private static beforeMainGame instance;

    MainAudioManager audioManager;
    void Awake()
    {
        FindAudioManager();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            // ★ ここで登録
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        countdownText.gameObject.SetActive(true);
        // StartCoroutine(CountDown());
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainScene")
        {
            FindAudioManager();
            isGameStart = false;
        }
    }

    void Update()
    {
        
    }

    public void coroutineControle()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        countdownText.gameObject.SetActive(true);
        audioManager.PlaySFX(audioManager.countDown);


        countdownText.text = "3";
        yield return new WaitForSeconds(0.8f);

        countdownText.text = "2";
        yield return new WaitForSeconds(0.8f);

        countdownText.text = "1";
        yield return new WaitForSeconds(0.8f);

        countdownText.text = "Go!";
        yield return new WaitForSeconds(0.8f);

        countdownText.gameObject.SetActive(false);

        isGameStart = true;
    }

    public bool getIsGameStart()
    {
        Debug.Log("isGameStart" + isGameStart);
        return isGameStart;
    }

    void FindAudioManager()
    {
        audioManager = MainAudioManager.Instance;
        
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
