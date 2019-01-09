using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasingPlatform2 : MonoBehaviour {

    public float PhaseOn;
    public float PhaseOff;
    public bool PhaseOnBool;

    public float alphaLevel = .5f;
    public float alphaLevelFull = 1f;

    private void Start()
    {
        PhaseOnBool = false;
    }

    void Update()
    {
        PhaseActive();
        if (PhaseOn >= 1)
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

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaLevel);
    }

    IEnumerator Phasingon()
    {
        yield return new WaitForSeconds(2);
        GetComponent<BoxCollider2D>().enabled = true;

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaLevelFull);

    }
}
