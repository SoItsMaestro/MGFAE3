using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesStart : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        StaticHealth.health = 4;
    }
}
