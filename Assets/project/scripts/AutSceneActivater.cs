using UnityEngine;
using UnityEngine.SceneManagement; // これが必須

public class AutSceneActivater : MonoBehaviour
{
    [SerializeField] private GameObject contentVisual;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (contentVisual != null && (scene.name == "MainScene"))
        {
            contentVisual.SetActive(true);
        }
    }
        public void HideObject()
    {
        if (contentVisual != null)
        {
            contentVisual.SetActive(false);
        }
    }
}
