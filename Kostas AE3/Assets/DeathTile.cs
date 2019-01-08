﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTile : MonoBehaviour
{
    public GameObject Spike;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StaticHealth.health = 0;
            Debug.Log("Collide");
        }
    }
}
