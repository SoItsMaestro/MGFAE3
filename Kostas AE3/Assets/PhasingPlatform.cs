using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasingPlatform : MonoBehaviour
{

    public float PhaseOn;
    public float PhaseOff;
    public bool PhaseOnBool;

    private void Start()
    {
        PhaseOnBool = false;
    }

    void Update()
    {
        FireActive();
        if (PhaseOn >= 2)
        {
            PhaseOnBool = true;

            if (PhaseOnBool == true)
            {
                Debug.Log("here");
                StartCoroutine(Phasingoff());
            }
        }
        else
        {
            PhaseOnBool = false;
            StartCoroutine(Phasingon());
        }

    }

    void FireActive()
    {
        PhaseOn += Time.deltaTime;

        if (Time.time > PhaseOff)
        {
            PhaseOff = Time.time + PhaseOn;
        }
    }

   // private void OnCollisionEnter2D(Collision2D collision)
   // {
   //     if (PhaseOnBool == true)
   //     {
   //         if (collision.gameObject.CompareTag("Player"))
   //         {
   //             Destroy(collision.gameObject);
   //             Debug.Log("Collide");
   //         }
   //     }
   // }

    

    //private void Update()
    //{
    //    
    //}
    //
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("Player"))
    //    {
    //        StartCoroutine(Phasingoff());
    //    }        
    //}
    //
    IEnumerator Phasingoff()
    {
        yield return new WaitForSeconds(2);
        GetComponent<BoxCollider2D>().enabled = false;
        PhaseOn = 0;
    }
    
    IEnumerator Phasingon()
    {
        yield return new WaitForSeconds(2);
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
