using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberPatrolplus : MonoBehaviour {

    public float Speed;
    public float Width;
    public float Height;
    public float timeCounter = 0;
    public float PositionX;
    public float PositionY;

    void Start()
    {

    }


    void Update()
    {
        timeCounter += Time.deltaTime * Speed;

        float x = Mathf.Cos(timeCounter) * Width + PositionX;
        float y = Mathf.Sin(timeCounter) * Height + PositionY;

        transform.position = new Vector3(x, y, 0);
    }
}



