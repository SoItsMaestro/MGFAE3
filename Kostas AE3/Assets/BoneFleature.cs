using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneFleature : MonoBehaviour
{  

    public GameObject BFProjectile;

    public bool facingRight = true;
    public bool once = false;

    Vector2 BonePos;
    public float FireRate;
    float nextfire;

    private void Update()
    {
        FireActive();
        if (nextfire >= 1)
        {

            once = true;
            fire();
            if (once == true)
            {

                StartCoroutine(FireBoi());
            }
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("work");
    //    if (collision.gameObject.CompareTag("Player") && Time.time > nextfire)
    //    {
    //         nextfire = Time.time + FireRate;
    //         fire();
    //    }       
    //}

    //      IEnumerator ShootyBoi()
    //{
    //    yield return new WaitForSeconds(2);
    //    nextfire = Time.time + FireRate;
    //    fire();
    //}

    void fire() //Fire funcction
    {
        BonePos = transform.position;
        if (facingRight) //Checks the way the player is facing
        {
            BonePos += new Vector2(+1f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(BFProjectile, BonePos, Quaternion.identity); //Creates the arrow       
        }
        else
        {
            BonePos += new Vector2(-1f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(BFProjectile, BonePos, Quaternion.identity); //Creates the arrow  
        }

    }

    void FireActive()
    {
        nextfire += Time.deltaTime;

        if (Time.time > FireRate)
        {
            FireRate = Time.time + nextfire;
        }
    }
    IEnumerator FireBoi()
    {
        yield return new WaitForSeconds(0);
        nextfire = 0;
    }



}
