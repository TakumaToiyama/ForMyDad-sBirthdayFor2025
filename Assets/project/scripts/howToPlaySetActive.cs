using UnityEngine;
using UnityEngine.SceneManagement;


public class howToPlaySetActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool activeTrue = true;
    private static howToPlaySetActive instance;

    void Awake()
    {
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
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainScene")
        {
            if (activeTrue)
            {
                gameObject.SetActive(true);
                activeTrue = false;
            }
        }
        Debug.Log("scene load how to play");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
