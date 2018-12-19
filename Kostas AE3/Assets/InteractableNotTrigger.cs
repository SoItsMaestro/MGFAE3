using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableNotTrigger : MonoBehaviour
{
    public bool Speachm;
    public GameObject SpeachMark;

    private void Start()
    {
        Speachm = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SpeachMark.gameObject.SetActive(true);
            Debug.Log("Collide");

            Speachm = true;
        }
        else
        {
            SpeachMark.gameObject.SetActive(false);
            Speachm = false;
        }
    }    
}
