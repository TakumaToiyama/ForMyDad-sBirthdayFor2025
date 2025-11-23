using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class PresentController : MonoBehaviour
{
    int ColorNum;
    UnityEngine.Vector3 targetPosition;
    float speed = 100f;
    bool isMoving = false;
    
    void Start()
    {
        ColorNum = UnityEngine.Random.Range(0,5);
        switch(ColorNum)
        {
            case 0:
                GetComponent<Renderer>().material.color = new Color(255, 0, 0); 
                break;
             case 1:
                GetComponent<Renderer>().material.color = new Color(0, 255, 0); 
                break;
             case 2:
                GetComponent<Renderer>().material.color = new Color(0, 0, 255); 
                break;
            case 3:
                GetComponent<Renderer>().material.color = new Color(255,255,0);
                break;
            default:
                GetComponent<Renderer>().material.color = new Color(0, 0, 0); 
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            return;
        }

        float step = speed * Time.deltaTime;
        transform.position = UnityEngine.Vector3.MoveTowards(transform.position,targetPosition,step);

        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }

    public void MovePresentBox()
    {
        targetPosition = new UnityEngine.Vector3(transform.position.x + 5, 0, 0);
        isMoving = true;
    }


    // helper fanction

    public float getX()
    {
        return transform.position.x;
    }

    public int getColorNum()
    {
        return ColorNum;
    }

    public bool getIsMoving()
    {
        return isMoving;
    }

}
