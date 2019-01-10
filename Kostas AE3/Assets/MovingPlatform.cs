using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Platform;
    public float Speed;
    public Transform CurrentPoint;
    public Transform[] Points;

    public int PointSelection;

	
	void Start ()
    {
        CurrentPoint = Points[PointSelection];
	}
	
	
	void Update ()
    {
        Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, CurrentPoint.position, Time.deltaTime * Speed);
        if(Platform.transform.position == CurrentPoint.position)
        {
            PointSelection++;
            if(PointSelection == Points.Length)
            {
                PointSelection = 0;
            }
            CurrentPoint = Points[PointSelection];
        }
	}

}
