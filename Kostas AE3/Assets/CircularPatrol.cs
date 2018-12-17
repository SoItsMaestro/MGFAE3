using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularPatrol : MonoBehaviour
{
    public float Speed;
    public float Width;
    public float Height;
    public float timeCounter = 0;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        timeCounter += Time.deltaTime * Speed;

        float x = Mathf.Cos(timeCounter) * Width;
        float y = Mathf.Sin(timeCounter) * Height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
	}
}
