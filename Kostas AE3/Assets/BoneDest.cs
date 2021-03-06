﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneDest : MonoBehaviour {

    public float Speed;
    

    Rigidbody2D Rigid;

    private void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rigid.velocity = new Vector2(Speed * Time.deltaTime, 0);
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("DestObj"))
        {
            Destroy(gameObject);
        }
        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    Destroy(gameObject);
        //}
    }
}
