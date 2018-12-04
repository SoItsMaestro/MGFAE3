using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour
{
    public float Speed;
    public float Stop;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > Stop)
        { 
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
    }

}
