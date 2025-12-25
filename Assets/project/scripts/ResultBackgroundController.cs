using UnityEngine;

public class ResultBackgroundController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * Time.deltaTime, 0, 0);
        if (transform.localPosition.x < -440.393f)
        {
            Debug.Log("move initial position");
            transform.localPosition = new Vector3(-422f, -275.1f, 0);
        }
    }
}
