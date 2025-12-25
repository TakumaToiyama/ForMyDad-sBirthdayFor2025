using System.Reflection;
using UnityEngine;

public class snowController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float fallSpeed;
    public float initialY;
    public float endY;
    public float x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, (fallSpeed * 333.33f) * Time.deltaTime, 0);
        if (transform.localPosition.y < endY)
        {
            transform.localPosition = new Vector3(x, initialY, 0);
        }
    }
}
