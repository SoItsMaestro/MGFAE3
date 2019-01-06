using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasingPlatform : MonoBehaviour
{

    public float PhaseOn;
    public float PhaseOff;
    public bool PhaseOnBool;

    public GameObject Platform1, Platform2, Platform3, Platform4, Platform5, 
        Platform6, Platform7, Platform8, Platform9, Platform10, Platform11, Platform12, 
        Platform13, Platform14, Platform15;

    private void Start()
    {
        PhaseOnBool = false;
    }

    void Update()
    {
        PhaseActive();
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

    void PhaseActive()
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
