﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string LevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collide");

            NextScene();
        }
    }

    void NextScene()
    {
        StaticHealth.level = LevelName;
        SceneManager.LoadScene("Transition");
    }
}
