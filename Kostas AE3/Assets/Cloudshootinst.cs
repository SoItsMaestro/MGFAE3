using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudshootinst : MonoBehaviour
{

    public GameObject cloudtears;
    public GameObject cloudtears2;

    public bool facingRight;
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

    void fire() //Fire funcction
    {
        BonePos = transform.position;
        if (facingRight) //Checks the way the player is facing
        {
            BonePos += new Vector2(+1f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(cloudtears, BonePos, Quaternion.identity); //Creates the arrow 
            
        }
       // else
       // {
       //     BonePos += new Vector2(-1f, 0f); //Sets the Right position of the arrow on the player
       //     Instantiate(cloudtears, BonePos, Quaternion.identity); //Creates the arrow  
       // }

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
